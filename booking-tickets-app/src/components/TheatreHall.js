import React, { useEffect, useState } from "react";
import axios from "axios";
import "./TheatreHall.css"; // Импортируем стили

const TheatreHall = ({ id }) => {
  const [locations, setLocations] = useState([]);
  const [loading, setLoading] = useState(true);

  // Данные для мест
  const sections = [
    {
      name: "Партер",
      id: 1,
      rows: [
        { seats: 20, row: 1 },
        { seats: 20, row: 2 },
        { seats: 20, row: 3 },
        { seats: 20, row: 4 },
        { seats: 24, row: 5 },
        { seats: 24, row: 6 },
      ],
    },
    {
      name: "Амфитеатр",
      id: 2,
      rows: [
        { seats: 20, row: 1 },
        { seats: 20, row: 2 },
        { seats: 20, row: 3 },
        { seats: 24, row: 4 },
        { seats: 24, row: 5 },
      ],
    },
    {
      name: "Бенуар",
      id: 3,
      rows: [
        { seats: 6, row: 1, side: "left" },
        { seats: 6, row: 2, side: "left" },
        { seats: 6, row: 1, side: "right" },
        { seats: 6, row: 2, side: "right" },
      ],
    },
  ];

  // Функция для загрузки данных
  useEffect(() => {
    console.log(id);
    axios
      .get(`https://localhost:6001/gateway/location/act/${id}`)
      .then((response) => {
        console.log(response.data);
        setLocations(response.data); // Сохраняем полученные данные
        setLoading(false);
      })
      .catch((error) => {
        console.error("Ошибка при загрузке данных", error);
        setLoading(false);
      });
  }, []);

  // Функция для распределения мест
  const assignSeats = (sections, locations) => {
    // Создаем копию секций и заполняем их данными
    const updatedSections = sections.map((section) => {
      return {
        ...section,
        rows: section.rows.map((row) => {
          // Находим все места для этого ряда и сектора
          const seatsInRow = locations.filter(
            (location) =>
              location.row === row.row && location.sectorId === section.id
          );

          // Создаем массив мест на основе количества мест в ряду
          const seats = Array.from({ length: row.seats }, (_, index) => {
            const seat = seatsInRow.find(
              (location) => location.seat === index + 1
            );
            return {
              seatId: seat ? seat.id : null,
              seatNumber: index + 1,
            };
          });

          return {
            ...row,
            seats: seats,
          };
        }),
      };
    });

    return updatedSections;
  };

  if (loading) {
    return <div>Загрузка...</div>;
  }

  const updatedSections = assignSeats(sections, locations);

  return (
    <div className="theater-layout">
      <div className="sections-container">
        {updatedSections.map((section, sectionIndex) => (
          <div
            key={sectionIndex}
            className={`section ${section.name.toLowerCase()}`}
          >
            <h2>{section.name}</h2>
            {section.rows.map((row, rowIndex) => (
              <div key={rowIndex} className={`row ${row.side ? row.side : ""}`}>
                {row.seats.map((seat, seatIndex) => (
                  <div key={seatIndex} className="seat">
                    {seat.seatId
                      ? `Место ${seat.seatNumber} (ID: ${seat.seatId})`
                      : `Место ${seat.seatNumber}`}
                  </div>
                ))}
              </div>
            ))}
          </div>
        ))}
      </div>
    </div>
  );
};

export default TheatreHall;
