import { React, useState, useEffect } from "react";
import axios from "axios";

import "./MainPage.css";

import RepertoireInfo from "../components/RepertoireInfo";
import EmployeesInfo from "../components/EmployeesInfo";
import MainHeader from "../components/MainHeader";
import UserProfile from "../components/UserProfile";
import Statistics from "../components/Statistics";

const GetSpecInfo = async (id) => {
  try {
    const response = await axios.get(
      `https://localhost:6001/gateway/spectacles/id?id=${id}`
    );
    return response.data; // возвращаем данные
  } catch (error) {
    if (error.response) {
      const { detail, status } = error.response.data;
      alert(`Статус ошибки ${status}: ${detail}`);
    }
  }
};

function MainPage({ token, setToken }) {
  const [activeSection, setActiveSection] = useState("репертуар");
  const [repertoire, setRepertoire] = useState([]);
  const [employees, setEmployees] = useState([]);
  const [loading, setLoading] = useState(true);

  const GetEmps = async () => {
    try {
      const response = await axios.get(
        `https://localhost:6001/gateway/employees`
      );
      const data = response.data;

      setEmployees(data);
    } catch (error) {
      if (error.response) {
        const { detail, status } = error.response.data;
        alert(`Статус ошибки ${status}: ${detail}`);
      }
    }
  };

  const GetRepertoire = async () => {
    const today = new Date();
    const year = today.getFullYear();
    const month = (today.getMonth() + 1).toString().padStart(2, "0");

    try {
      const response = await axios.get(
        `https://localhost:6001/gateway/repertoire/date?date=${year}-${month}-01`
      );
      const data = response.data;

      let repData = [];

      // Проходим по каждому спектаклю и получаем информацию о нем
      for (const spec of data) {
        const specInfo = await GetSpecInfo(spec.spectacleId); // ждем получения данных

        repData.push({
          id: spec.id,
          rating: spec.rating,
          name: specInfo.name,
          duration: specInfo.duration,
          plot: specInfo.plot,
          genre: specInfo.genre,
          roles: specInfo.role.map((role) => ({
            roleName: role.name,
            empName: role.empName,
          })),
          acts: spec.acts
            .map((act) => ({ id: act.id, date: act.date }))
            .sort((a, b) => new Date(a.date) - new Date(b.date)),
        });
      }
      setRepertoire(repData);
    } catch (error) {
      if (error.response) {
        const { detail, status } = error.response.data;
        alert(`Статус ошибки ${status}: ${detail}`);
      }
    }
  };

  useEffect(() => {
    GetRepertoire();
    GetEmps();
    setLoading(false);
  }, []);

  return (
    <div className="app">
      <MainHeader
        activeSection={activeSection}
        setActiveSection={setActiveSection}
        token={token}
        setToken={setToken}
      />
      <main className="main-content">
        {activeSection === "репертуар" ? (
          loading ? (
            <div>Загрузка...</div>
          ) : (
            <RepertoireInfo data={repertoire} />
          )
        ) : null}
      </main>
      <main className="main-content">
        {activeSection === "актеры и роли" ? (
          loading ? (
            <div>Загрузка...</div>
          ) : (
            <EmployeesInfo data={employees} />
          )
        ) : null}
      </main>
      <main className="main-content">
        {activeSection === "личные данные" && <UserProfile token={token} />}
      </main>
      <main className="main-content">
        {activeSection === "статистика" && <Statistics token={token} />}
      </main>
    </div>
  );
}

export default MainPage;
