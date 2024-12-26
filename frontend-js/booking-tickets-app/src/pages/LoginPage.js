import { React, useState } from "react";
import { useNavigate, Link } from "react-router-dom";
import axios from "axios";

import "./LoginPage.css";

function LoginPage({ setToken }) {
  const [login, setLogin] = useState("");
  const [password, setPassword] = useState("");
  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();
    axios
      .post("https://localhost:6001/gateway/auth/viewer/verify", {
        login,
        password,
      })
      .then((response) => {
        setToken(response.data);
        navigate("/");
      })
      .catch((error) => {
        if (error.response) {
          const { detail, status } = error.response.data;
          alert(`Статус ошибки ${status}: ${detail}`);
        }
      });
  };

  return (
    <div className="login-container">
      <h1 className="login-header">Вход</h1>
      <form className="login-form" onSubmit={handleSubmit}>
        <input
          type="text"
          name="username"
          id="username"
          className="login-input"
          placeholder="Логин пользователя"
          value={login}
          onChange={(e) => setLogin(e.target.value)}
        />
        <input
          type="password"
          name="password"
          id="password"
          className="login-input"
          placeholder="Пароль"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
        />
        <button type="submit" className="login-button">
          Войти
        </button>
        <div className="register-link">
          <p>
            <Link to="/signup" className="register-link-text">
              Зарегистрироваться
            </Link>
          </p>
        </div>
      </form>
    </div>
  );
}

export default LoginPage;
