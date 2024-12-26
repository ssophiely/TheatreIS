import React, { useEffect, useState } from "react";
import axios from "axios";
import "./TheatreHall.css";
import { jwtDecode } from "jwt-decode";

// Данные для мест
const sections = [
  {
    name: "Партер",
    id: 1,
    rows: [
      { seats: 20, row: 1 },
      { seats: 20, row: 2 },
      { seats: 24, row: 3 },
      { seats: 24, row: 4 },
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
    name: "Левый Бенуар",
    id: 3,
    rows: [
      { seats: 6, row: 1, side: "left" },
      { seats: 6, row: 2, side: "left" },
    ],
  },
  {
    name: "Правый Бенуар",
    id: 4,
    rows: [
      { seats: 6, row: 1, side: "right" },
      { seats: 6, row: 2, side: "right" },
    ],
  },
];

const TheatreHall = ({ id, token }) => {
  const [locations, setLocations] = useState([]);
  const [loading, setLoading] = useState(true);
  const [selectedSeats, setSelectedSeats] = useState(new Set());
  const [componentKey, setComponentKey] = useState(0);

  const inSelected = (seat) => {
    const seatString = JSON.stringify(seat);
    return Array.from(selectedSeats).some(
      (s) => JSON.stringify(s) === seatString
    );
  };

  const locationClick = (seat) => {
    if (token === null || token === undefined) {
      alert("Пройдите авторизацию!");
      return;
    }

    if (seat.stateId === 2) return;

    setSelectedSeats((prevSelectedSeats) => {
      const updatedSeats = new Set(prevSelectedSeats);
      console.log(inSelected(seat));
      if (inSelected(seat)) {
        updatedSeats.forEach((s) => {
          if (s.seatId === seat.seatId) updatedSeats.delete(s);
        });
      } else {
        updatedSeats.add(seat);
      }
      console.log(updatedSeats);
      return updatedSeats;
    });
  };

  const CreateTicket = async (stateId) => {
    for (const seat of selectedSeats) {
      await axios
        .post(
          `https://localhost:6001/gateway/tickets`,
          {
            viewerId: jwtDecode(token).id,
            stateId: stateId,
            locationId: seat.seatId,
          },
          {
            headers: {
              Authorization: `Bearer ${token}`,
            },
          }
        )
        .catch((error) => {
          console.error("Ошибка при создании билета", error);
          setLoading(false);
        });
    }
    setSelectedSeats(new Set());
    setComponentKey((prevKey) => prevKey + 1);
  };

  // Функция для загрузки данных
  useEffect(() => {
    axios
      .get(`https://localhost:6001/gateway/location/act/${id}`)
      .then((response) => {
        console.log("места", response.data);
        setLocations(response.data); // Сохраняем полученные данные
        setLoading(false);
      })
      .catch((error) => {
        console.error("Ошибка при загрузке данных", error);
        setLoading(false);
      });
  }, [id, componentKey]);

  // Функция для распределения мест
  const assignSeats = (sections, locations) => {
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
              seatId: seat ? seat.id : null, // сохраняем идентификатор места
              seatNumber: index + 1, // отображаем номер места
              row: seat.row,
              price: seat.price,
              stateId: seat.locationStateId,
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
        {/* Размещение остальных секторов (Партер и Амфитеатр) по-прежнему вертикально */}
        {updatedSections
          .filter((section) => section.id !== 3 && section.id !== 4)
          .map((section, sectionIndex) => (
            <div
              key={sectionIndex}
              className={`section ${section.name
                .toLowerCase()
                .replace(" ", "-")}`}
            >
              <h2>{section.name}</h2>
              {section.rows.map((row, rowIndex) => (
                <div
                  key={rowIndex}
                  className={`row ${row.side ? row.side : ""}`}
                >
                  {row.seats.map((seat, seatIndex) => (
                    <div
                      key={seatIndex}
                      className={
                        seat.stateId === 2
                          ? "redSeat"
                          : inSelected(seat)
                          ? "greenSeat"
                          : "seat"
                      }
                      onClick={() => locationClick(seat)}
                    >
                      {seat.seatNumber}
                    </div>
                  ))}
                </div>
              ))}
            </div>
          ))}

        {/* Размещение Левого и Правого Бенуара рядом, внизу */}
        <div className="benuar-sections">
          {updatedSections
            .filter((section) => section.id === 3 || section.id === 4)
            .map((section, sectionIndex) => (
              <div
                key={sectionIndex}
                className={`section benuar ${section.name
                  .toLowerCase()
                  .replace(" ", "-")}`}
              >
                <h2>{section.name}</h2>
                {section.rows.map((row, rowIndex) => (
                  <div
                    key={rowIndex}
                    className={`row ${row.side ? row.side : ""}`}
                  >
                    {row.seats.map((seat, seatIndex) => (
                      <div
                        key={seatIndex}
                        className={
                          seat.stateId === 2
                            ? "redSeat"
                            : inSelected(seat)
                            ? "greenSeat"
                            : "seat"
                        }
                        onClick={() => locationClick(seat)}
                      >
                        {seat.seatNumber}
                      </div>
                    ))}
                  </div>
                ))}
              </div>
            ))}
        </div>
        {selectedSeats.size > 0 && (
          <div className="pay_container">
            <h3 className="pay">
              Сумма:{" "}
              {[...selectedSeats].reduce((sum, item) => sum + item.price, 0)}{" "}
            </h3>
            <button
              className="create_ticket_btn"
              onClick={() => CreateTicket(1)}
            >
              Забронировать
            </button>
            <button
              className="create_ticket_btn2"
              onClick={() => CreateTicket(2)}
            >
              Оплатить
            </button>
          </div>
        )}
      </div>
    </div>
  );
};

export default TheatreHall;
