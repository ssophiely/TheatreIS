import { React, useState } from "react";
import { useNavigate, Link } from "react-router-dom";
import axios from "axios";

import "./LoginPage.css";

function SignUpPage() {
  const [mail, setMail] = useState("");
  const [password, setPassword] = useState("");
  const [password2, setPassword2] = useState("");
  const navigate = useNavigate();

  // Регулярное выражение для проверки формата почты
  const emailRegex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;

  const handleSubmit = (e) => {
    e.preventDefault();

    if (!emailRegex.test(mail)) {
      alert("Неверный формат почты!");
      return;
    }

    if (password !== password2) {
      alert("Пароли не совпадают!");
      return;
    }

    axios
      .post("https://localhost:6001/gateway/auth/viewer", {
        mail,
        password,
      })
      .then(() => {
        navigate("/login");
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
      <h1 className="login-header">Регистрация</h1>
      <form className="login-form" onSubmit={handleSubmit}>
        <input
          type="text"
          name="username"
          id="username"
          className="login-input"
          placeholder="Введите почту"
          value={mail}
          onChange={(e) => setMail(e.target.value)}
        />
        <input
          type="password"
          name="password"
          id="password"
          className="login-input"
          placeholder="Придумайте пароль"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
        />
        <input
          type="password"
          name="password"
          id="password"
          className="login-input"
          placeholder="Подтвердите пароль"
          value={password2}
          onChange={(e) => setPassword2(e.target.value)}
        />
        <button type="submit" className="login-button">
          Зарегистрироваться
        </button>
        <div className="register-link">
          <p>
            <Link to="/login" className="register-link-text">
              Войти
            </Link>
          </p>
        </div>
      </form>
    </div>
  );
}

export default SignUpPage;
