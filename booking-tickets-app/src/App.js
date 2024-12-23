import "./App.css";

import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { React, useState } from "react";

import LoginPage from "./pages/LoginPage.js";
import MainPage from "./pages/MainPage.js";
import SignUpPage from "./pages/SignUpPage.js";

function App() {
  const [token, setToken] = useState(null);

  return (
    <Router>
      <Routes>
        <Route path="/login" element={<LoginPage setToken={setToken} />} />
        <Route
          path="/"
          element={<MainPage token={token} setToken={setToken} />}
        />
        <Route path="/signup" element={<SignUpPage />} />
      </Routes>
    </Router>
  );
}

export default App;
