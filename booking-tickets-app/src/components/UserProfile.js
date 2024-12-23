import React, { useState, useEffect } from "react";
import axios from "axios";
import { jwtDecode } from "jwt-decode";
import "./UserProfile.css";

const UserProfile = ({ token }) => {
  const [userInfo, setUserInfo] = useState({
    id: null,
    login: null,
    fullName: null,
    phone: null,
  });

  const [isEditing, setIsEditing] = useState(false);
  const [editedFullName, setEditedFullName] = useState("");
  const [editedPhone, setEditedPhone] = useState("");

  const GetUserInfo = async () => {
    const decoded = jwtDecode(token);
    try {
      const response = await axios.get(
        `https://localhost:6001/gateway/auth/viewer/${decoded.id}`,
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        }
      );
      const data = response.data;

      console.log(data);
      setUserInfo({
        id: decoded.id,
        login: data.mail,
        fullName: data.fullName,
        phone: data.phone,
      });
    } catch (error) {
      console.log(error);
      if (error.response) {
        const { detail, status } = error.response.data;
        alert(`Статус ошибки ${status}: ${detail}`);
      }
    }
  };

  // Декодирование JWT токена и извлечение данных о пользователе
  useEffect(() => {
    GetUserInfo();
  }, [token]);

  // Обработчик изменений в полях
  const handleEditChange = (e) => {
    if (e.target.name === "fullName") {
      setEditedFullName(e.target.value);
    } else if (e.target.name === "phone") {
      setEditedPhone(e.target.value);
    }
  };

  // Сохранение изменений
  const handleSaveChanges = () => {
    setUserInfo({
      ...userInfo,
      fullName: editedFullName || userInfo.fullName,
      phone: editedPhone || userInfo.phone,
    });
    setIsEditing(false);
    console.log(5, userInfo);
    axios
      .put(
        "https://localhost:6001/gateway/auth/viewer",
        {
          id: userInfo.id,
          fullName: editedFullName || userInfo.fullName,
          phone: editedPhone || userInfo.phone,
        },
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        }
      )
      .catch((error) => {
        console.log(error);
        if (error.response) {
          const { detail, status } = error.response.data;
          alert(`Статус ошибки ${status}: ${detail}`);
        }
      });
  };

  return (
    <div className="user-profile">
      <div className="profile-card">
        <div className="profile-item">
          <label>Логин:</label>
          <span>{userInfo.login}</span>
        </div>

        <div className="profile-item">
          <label>Полное имя:</label>
          {isEditing ? (
            <input
              type="text"
              name="fullName"
              value={editedFullName || userInfo.fullName}
              onChange={handleEditChange}
            />
          ) : (
            <span>{userInfo.fullName}</span>
          )}
        </div>

        <div className="profile-item">
          <label>Телефон:</label>
          {isEditing ? (
            <input
              type="text"
              name="phone"
              value={editedPhone || userInfo.phone}
              onChange={handleEditChange}
            />
          ) : (
            <span>{userInfo.phone}</span>
          )}
        </div>

        <div className="profile-actions">
          {isEditing ? (
            <button className="save-button" onClick={handleSaveChanges}>
              Сохранить
            </button>
          ) : (
            <button className="edit-button" onClick={() => setIsEditing(true)}>
              Редактировать
            </button>
          )}
        </div>
      </div>
    </div>
  );
};

export default UserProfile;
