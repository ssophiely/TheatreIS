import { React, useState } from "react";
import { useNavigate } from "react-router-dom";
import "../pages/MainPage.css";

export default function MainHeader({
  activeSection,
  setActiveSection,
  token,
  setToken,
}) {
  const [showDropdown, setShowDropdown] = useState(false);
  const navigate = useNavigate();

  return (
    <header className="header">
      <nav className="nav">
        <ul className="nav-list">
          <li
            className={`nav-item ${
              activeSection === "репертуар" ? "active" : ""
            }`}
            onClick={() => setActiveSection("репертуар")}
          >
            Репертуар
          </li>
          <li
            className={`nav-item ${
              activeSection === "актеры и роли" ? "active" : ""
            }`}
            onClick={() => setActiveSection("актеры и роли")}
          >
            Актеры и роли
          </li>
          <li
            className="nav-item"
            onMouseEnter={() => setShowDropdown(true)}
            onMouseLeave={() => setShowDropdown(false)}
          >
            Личный кабинет
            {showDropdown && (
              <div className="dropdown">
                {token == null ? (
                  <ul>
                    <li onClick={() => navigate("/login")}>Войти</li>
                    <li onClick={() => navigate("/signup")}>
                      Зарегистрироваться
                    </li>
                  </ul>
                ) : (
                  <ul>
                    <li onClick={() => setActiveSection("личные данные")}>
                      Личная информация
                    </li>
                    <li onClick={() => setActiveSection("билеты")}> Билеты</li>
                    <li onClick={() => setActiveSection("статистика")}>
                      Статистика
                    </li>
                    <li
                      onClick={() => {
                        setToken(null);
                        navigate("/login");
                      }}
                    >
                      Выйти
                    </li>
                  </ul>
                )}
              </div>
            )}
          </li>
        </ul>
      </nav>
    </header>
  );
}
