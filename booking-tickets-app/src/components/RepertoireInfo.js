import { React, useState } from "react";
import "./RepInfo.css";
import TheatreHall from "./TheatreHall";

// Пример компонента, который будет отображать информацию о каждом спектакле
const RepertoireInfoCard = ({ repertoire }) => {
  const [showModal, setShowModal] = useState(false);
  const [actId, setActId] = useState(null);

  const handleDateClick = (id) => {
    console.log("id", id);
    setActId(id);
    setShowModal(true); // Показываем модальное окно
  };

  const closeModal = () => {
    setShowModal(false); // Закрываем модальное окно
  };

  return (
    <div className="repertoire-card">
      <h2>Спектакль "{repertoire.name}"</h2>
      <p>
        <strong>Рейтинг:</strong> {repertoire.rating}
      </p>
      <p>
        <strong>Жанр:</strong> {repertoire.genre}
      </p>
      <p>
        <strong>Продолжительность:</strong> {repertoire.duration}
      </p>
      <p>
        <strong>Сюжет:</strong> {repertoire.plot}
      </p>

      <div className="info-list">
        <br></br>
        <h3>Роли:</h3>
        <div>
          {repertoire.roles &&
            repertoire.roles.map((role, index) => (
              <div key={index} className="info">
                <p>
                  <strong>Актер:</strong> {role.empName}
                </p>
                <p>
                  <strong>Роль:</strong> {role.roleName}
                </p>
              </div>
            ))}
        </div>
      </div>

      <div className="acts-container">
        {repertoire.acts.map((item) => (
          <div
            key={item.id}
            className="date-time-date"
            onClick={() => handleDateClick(item.id)}
          >
            {formatDate(item.date)}
          </div>
        ))}
      </div>

      {showModal && <TheatreHall closeModal={closeModal} id={actId} />}
    </div>
  );
};

const formatDate = (isoString) => {
  const date = new Date(isoString);
  const day = String(date.getDate()).padStart(2, "0");
  const month = String(date.getMonth() + 1).padStart(2, "0");
  const year = date.getFullYear();
  const hours = String(date.getHours()).padStart(2, "0");
  const minutes = String(date.getMinutes()).padStart(2, "0");

  return `${day}.${month}.${year} ${hours}:${minutes}`;
};

// Основной компонент для отображения списка спектаклей
const RepertoireList = ({ repertories }) => {
  return (
    <div className="repertoire-list">
      {repertories &&
        repertories.map((repertoire) => (
          <RepertoireInfoCard key={repertoire.id} repertoire={repertoire} />
        ))}
    </div>
  );
};

export default function RepertoireInfo({ data }) {
  return (
    <div style={{ padding: "20px" }}>
      <RepertoireList repertories={data} />
    </div>
  );
}
