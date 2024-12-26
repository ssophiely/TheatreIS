import { React, useState } from "react";
import "./RepInfo.css";

const Employee = ({ emp }) => {
  return (
    <div className="repertoire-card">
      <h2>{emp.fullName}</h2>
      <p>
        <strong>Стаж работы (лет):</strong> {emp.experience}
      </p>
      <p>
        <strong>Должность:</strong> {emp.position}
      </p>

      <div className="info-list">
        <br></br>
        <h3>Участия в спектаклях:</h3>
        <div>
          {emp.role &&
            emp.role.map((role, index) => (
              <div key={index} className="info">
                <p>
                  <strong>{role.spectacle}</strong> {" - "}
                  {role.name}
                </p>
              </div>
            ))}
        </div>
      </div>
    </div>
  );
};

// Основной компонент для отображения списка спектаклей
const EmployeeList = ({ emps }) => {
  return (
    <div className="repertoire-list">
      {emps && emps.map((emp) => <Employee key={emp.id} emp={emp} />)}
    </div>
  );
};

export default function EmployeesInfo({ data }) {
  const [filterPosition, setFilterPosition] = useState(""); // Состояние для фильтрации по должности
  const [sortBy, setSortBy] = useState("name"); // Состояние для сортировки (по имени)

  // Фильтрация сотрудников по должности
  const filteredEmployees = filterPosition
    ? data.filter(
        (emp) => emp.position.toLowerCase() === filterPosition.toLowerCase()
      )
    : data;

  // Сортировка сотрудников по первой букве полного имени
  const sortedEmployees = filteredEmployees.sort((a, b) => {
    if (sortBy === "name") {
      const nameA = a.fullName[0].toUpperCase();
      const nameB = b.fullName[0].toUpperCase();
      if (nameA < nameB) {
        return -1;
      }
      if (nameA > nameB) {
        return 1;
      }
      return 0;
    } else if (sortBy === "position") {
      const positionA = a.position.toUpperCase();
      const positionB = b.position.toUpperCase();
      if (positionA < positionB) {
        return -1;
      }
      if (positionA > positionB) {
        return 1;
      }
      return 0;
    }
    return 0;
  });

  // Обработчик для изменения фильтра по должности
  const handlePositionChange = (event) => {
    setFilterPosition(event.target.value);
  };

  // Обработчик для изменения сортировки (по имени)
  const handleSortChange = (event) => {
    setSortBy(event.target.value);
  };

  return (
    <div style={{ padding: "20px" }}>
      <div className="filters">
        <label>
          Фильтрация по должности:
          <input
            type="text"
            value={filterPosition}
            onChange={handlePositionChange}
            placeholder="Введите должность"
          />
        </label>

        <label>
          Сортировать по:
          <select value={sortBy} onChange={handleSortChange}>
            <option value="name">Имя</option>
            <option value="position">Должность</option>
          </select>
        </label>
      </div>
      <EmployeeList emps={sortedEmployees} />
    </div>
  );
}
