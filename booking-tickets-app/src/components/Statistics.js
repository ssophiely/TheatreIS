import React, { useState, useEffect } from "react";
import axios from "axios";
import { Pie } from "react-chartjs-2";
import {
  ArcElement,
  Tooltip,
  Legend,
  Title,
  CategoryScale,
  LinearScale,
  Chart as ChartJS,
} from "chart.js";
import { jwtDecode } from "jwt-decode";
import "./Statistics.css";

ChartJS.register(
  ArcElement,
  Tooltip,
  Legend,
  Title,
  CategoryScale,
  LinearScale
);

const Statistics = ({ token }) => {
  const [genreVisits, setGenreVisits] = useState([]);
  const [hoursWatched, setHoursWatched] = useState(null);
  const [tickets, setTickets] = useState(null);

  useEffect(() => {
    const decoded = jwtDecode(token);

    // Получение статистики по посещаемости жанров
    const fetchGenreVisits = async () => {
      try {
        const response = await axios.get(
          `https://localhost:6001/gateway/statistics/viewer/genre-visits/${decoded.id}`,
          {
            headers: {
              Authorization: `Bearer ${token}`,
            },
          }
        );
        console.log(response.data);
        setGenreVisits(response.data);
      } catch (error) {
        console.error("Ошибка получения данных по жанрам", error);
      }
    };

    // Получение статистики по часам просмотра спектаклей
    const fetchHoursWatched = async () => {
      try {
        const response = await axios.get(
          `https://localhost:6001/gateway/statistics/viewer/hours-watching/${decoded.id}`,
          {
            headers: {
              Authorization: `Bearer ${token}`,
            },
          }
        );
        console.log(response.data);
        let hours = response.data[0] ? response.data[0].totalHoursWatched : 0;
        setHoursWatched(hours);
      } catch (error) {
        console.error("Ошибка получения данных по часам", error);
      }
    };

    const fetchGetTickets = async () => {
      try {
        const response = await axios.get(
          `https://localhost:6001/gateway/statistics/viewer/bought-tickets/${decoded.id}`,
          {
            headers: {
              Authorization: `Bearer ${token}`,
            },
          }
        );
        let tickets = response.data[0] ? response.data[0].ticketsCount : 0;
        setTickets(tickets);
      } catch (error) {
        console.error("Ошибка получения купленных билетов", error);
      }
    };

    fetchGenreVisits();
    fetchHoursWatched();
    fetchGetTickets();
  }, []);

  // Форматирование данных для круговой диаграммы
  const genreData = {
    labels: genreVisits.map((visit) => `${visit.genreName}`),
    datasets: [
      {
        label: "  Количество посещений",
        data: genreVisits.map((visit) => visit.visitCount),
        backgroundColor: [
          "#FF6384",
          "#36A2EB",
          "#FFCE56",
          "#4BC0C0",
          "#9966FF",
        ],
      },
    ],
  };

  const options = {
    responsive: true, // Адаптивность диаграммы
    plugins: {
      legend: {
        position: "top", // Позиция легенды
      },
    },
    maintainAspectRatio: false, // Отключаем пропорции, чтобы контейнер регулировал размер диаграммы
  };

  return (
    <div className="user-statistics-container">
      <h4 className="user-statistics-title">
        Статистика пользователя {jwtDecode(token).mail}
      </h4>

      <h5>
        Часов просмотра спектаклей: {"  "}
        {hoursWatched !== null ? `${hoursWatched}` : "Загружаются данные..."}
      </h5>
      <h5>
        Число купленных билетов: {"  "}
        {hoursWatched !== null ? `${tickets}` : "Загружаются данные..."}
      </h5>

      <div className="user-statistics-chart-box">
        <h4>Посещаемость по жанрам</h4>
        {genreVisits.length > 0 ? (
          <Pie data={genreData} options={options} />
        ) : (
          <p>Данных нет</p>
        )}
      </div>
    </div>
  );
};

export default Statistics;
