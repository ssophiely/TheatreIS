import React, { useEffect, useState } from "react";
import "./Tickets.css";
import { jwtDecode } from "jwt-decode";
import axios from "axios";

// Функция для получения данных билетов с сервера
const fetchTicketData = async (id) => {
  try {
    const response = await axios.get(
      `https://localhost:6001/gateway/tickets/viewer/${id}`
    );
    return response.data;
  } catch (error) {
    console.error("Ошибка получения билетов", error);
  }
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

// Компонент таблицы с данными билетов
const TicketTable = ({ token }) => {
  const [tickets, setTickets] = useState([]);
  const [loading, setLoading] = useState(true);
  const [componentKey, setComponentKey] = useState(0); // Состояние для обновления ключа
  const [newRating, setNewRating] = useState(""); // Для нового рейтинга

  // Загрузка данных при монтировании компонента
  useEffect(() => {
    const loadTickets = async () => {
      const ticketData = await fetchTicketData(jwtDecode(token).id);
      setTickets(ticketData);
      setLoading(false);
    };

    loadTickets();
  }, [componentKey]);

  // Функция для изменения рейтинга билета в локальном состоянии
  const handleRatingChange = (id, newRating) => {
    setTickets((prevTickets) =>
      prevTickets.map((ticket) =>
        ticket.id === id ? { ...ticket, rating: newRating } : ticket
      )
    );
  };

  // Функция для сохранения рейтинга
  const saveRating = async (id, rating) => {
    if (isNaN(rating) || rating < 0 || rating > 10) {
      alert("Пожалуйста, введите правильное значение рейтинга от 0 до 10.");
      return;
    }

    try {
      await axios.put(
        `https://localhost:6001/gateway/tickets/rate`,
        {
          id,
          rating,
        },
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        }
      );
      setComponentKey((prevKey) => prevKey + 1);
    } catch (error) {
      console.error("Ошибка изменения рейтинга", error);
    }
  };

  // Функция для обработки оплаты билета
  const handlePay = async (id) => {
    try {
      await axios.put(
        `https://localhost:6001/gateway/tickets/state`,
        {
          id,
          stateId: 2,
        },
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        }
      );
      setComponentKey((prevKey) => prevKey + 1); // Обновляем компонент после изменения состояния
    } catch (error) {
      console.error("Ошибка оплаты билета", error);
    }
  };

  // Функция для обработки возврата билета
  const handleReturn = async (id) => {
    try {
      await axios.put(
        `https://localhost:6001/gateway/tickets/state`,
        {
          id,
          stateId: 3,
        },
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        }
      );
      setComponentKey((prevKey) => prevKey + 1); // Обновляем компонент после изменения состояния
    } catch (error) {
      console.error("Ошибка возврата билета", error);
    }
  };

  if (loading) {
    return <div>Загрузка...</div>;
  }

  return (
    <div className="ticket-table-container">
      <h2>Список билетов</h2>
      <table className="ticket-table">
        <thead>
          <tr>
            <th>Спектакль</th>
            <th>Дата</th>
            <th>Ряд</th>
            <th>Место</th>
            <th>Сектор</th>
            <th>Цена</th>
            <th>Рейтинг</th>
            <th>Статус</th>
            <th></th> {/* Пустая ячейка для кнопок */}
          </tr>
        </thead>
        <tbody>
          {tickets.map((ticket) => (
            <tr key={ticket.id}>
              <td>{ticket.spectacleName}</td>
              <td>{formatDate(ticket.date)}</td>
              <td>{ticket.row}</td>
              <td>{ticket.seat}</td>
              <td>{ticket.sector}</td>
              <td>{ticket.price}</td>
              <td>
                {ticket.stateId === 2 && new Date(ticket.date) < new Date() && (
                  <>
                    {ticket.rating === 0 ? (
                      <>
                        <input
                          type="number"
                          value={newRating !== "" ? newRating : ""}
                          onChange={(e) => setNewRating(e.target.value)}
                          min="0"
                          max="10"
                          step="0.1"
                          className="rating-input"
                        />
                        <button
                          className="rate_btn"
                          onClick={() => {
                            const ratingValue = parseFloat(newRating);
                            if (
                              !isNaN(ratingValue) &&
                              ratingValue >= 0 &&
                              ratingValue <= 10
                            ) {
                              saveRating(ticket.id, ratingValue);
                              setNewRating("");
                            } else {
                              alert(
                                "Введите корректное значение рейтинга от 0 до 10!"
                              );
                            }
                          }}
                        >
                          Сохранить
                        </button>
                      </>
                    ) : (
                      <span>{ticket.rating}</span> // Если рейтинг уже установлен, не показываем поле для ввода
                    )}
                  </>
                )}{" "}
              </td>
              <td>{ticket.stateName}</td>
              <td>
                <button
                  onClick={() => handlePay(ticket.id)}
                  disabled={
                    [2, 3].includes(ticket.stateId) ||
                    new Date(ticket.date) < new Date()
                  } // Кнопка будет неактивной, если состояние не позволяет оплатить
                >
                  Оплатить
                </button>
                <button
                  className="return_btn"
                  onClick={() => handleReturn(ticket.id)}
                  disabled={
                    ticket.stateId === 3 || new Date(ticket.date) < new Date()
                  } // Кнопка будет неактивной, если билет уже возвращён
                >
                  Вернуть
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default TicketTable;
