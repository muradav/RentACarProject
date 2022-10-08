import React, { useState } from "react";
import { createBrowserRouter, useNavigate } from "react-router-dom";

function Register() {
  const [name, setName] = useState("");
  const [surname, setSurname] = useState("");
  const [username, setUsername] = useState("");
  const [email, setEmail] = useState("");
  const [phoneNumber, setPhoneNumber] = useState("");
  const [password, setPassword] = useState("");
  const [checkPassword, setCheckPassword] = useState("");

  function checkConfirmPassword(e) {
    setCheckPassword(e.target.value);
    const password = document.querySelector("input[name=password]");
    const confirm = document.querySelector("input[name=confirmPass]");
    if (confirm.value === password.value) {
      confirm.setCustomValidity("");
    } else {
      confirm.setCustomValidity("Zəhmət olmasa şifrəni düzgün daxil edin");
    }
  }

  async function signUp(e) {
    e.preventDefault();

    let dataToSubmit = {
      name,
      surname,
      username,
      email,
      phoneNumber,
      password,
      checkPassword,
    };

    console.log(dataToSubmit);

    await fetch("https://localhost:44352/api/auth/register", {
      method: "POST",
      body: JSON.stringify(dataToSubmit),
      headers: {
        "Content-type": "application/json",
        Accept: "application/json",
      },
    })
      .then((res) => {
        if (res.ok && res.status === 200) {
          return res.json().then(data=>{
            window.localStorage.setItem("user",JSON.stringify(data));
            console.log(JSON.parse(window.localStorage.getItem("user")));
          });
        }
      })
      .then((res) => console.log(res))
      .catch((err) => console.log(err));
  }

  return (
    <>
      <div className="container">
        <div className="row d-flex align-items-center justify-content-center ">
          <div className="col-12">
            <div
              className="bg-dark text-white my-5 mx-auto"
              style={{ borderRadius: "1rem", maxWidth: "600px" }}
            >
              <div className="p-5 d-flex flex-column align-items-center mx-auto w-100">
                <h2 className="text-uppercase text-center mb-5">
                  Hesab yaradın
                </h2>
                <form className="row" method="post" action="#">
                  <div className="mb-3 col-sm-6">
                    <label for="name" className="form-label">
                      Ad
                    </label>
                    <input
                      type="text"
                      className="form-control"
                      id="name"
                      value={name}
                      name="name"
                      onChange={(e) => setName(e.target.value)}
                    />
                  </div>
                  <div className="mb-3 col-sm-6">
                    <label for="surname" className="form-label">
                      Soyad
                    </label>
                    <input
                      type="text"
                      className="form-control"
                      id="Surname"
                      value={surname}
                      name="surname"
                      onChange={(e) => setSurname(e.target.value)}
                    />
                  </div>
                  <div className="mb-3 col-sm-6">
                    <label for="username" className="form-label">
                      İstifadəçi Adı
                    </label>
                    <input
                      type="text"
                      className="form-control"
                      id="username"
                      value={username}
                      name="username"
                      onChange={(e) => setUsername(e.target.value)}
                    />
                  </div>
                  <div className="mb-3 col-sm-6">
                    <label for="email" className="form-label">
                      Elektron poçt ünvanı
                    </label>
                    <input
                      type="email"
                      className="form-control"
                      id="email"
                      value={email}
                      name="email"
                      onChange={(e) => setEmail(e.target.value)}
                    />
                  </div>
                  <div className="mb-3 col-sm-6">
                    <label for="phone" className="form-label">
                      Telefon Nömrəsi
                    </label>
                    <input
                      type="tel"
                      className="form-control"
                      id="phoneNumber"
                      value={phoneNumber}
                      name="phoneNumber"
                      onChange={(e) => setPhoneNumber(e.target.value)}
                    />
                  </div>
                  <div className="mb-3 col-sm-6">
                    <label for="password" className="form-label">
                      Şifrə
                    </label>
                    <input
                      type="password"
                      className="form-control"
                      id="password"
                      value={password}
                      name="password"
                      onChange={(e) => setPassword(e.target.value)}
                    />
                  </div>
                  <div className="mb-3 col-sm-6">
                    <label for="password" className="form-label">
                      Təkrar Şifrə
                    </label>
                    <input
                      type="password"
                      className="form-control"
                      id="confirmPass"
                      value={checkPassword}
                      name="confirmPass"
                      onChange={checkConfirmPassword}
                    />
                  </div>
                  {/* <div className="d-flex flex-row justify-content-center mb-4">
                  <input
                    type="checkbox"
                    name="flexCheck"
                    id="flexCheckDefault"
                    label="I agree all statements in Terms of service"
                  />
                </div> */}
                  <button
                    className="mt-4 px-5 btn btn-dark"
                    color="white"
                    size="lg"
                    type="submit"
                    onClick={signUp}
                  >
                    Hesab Yarat
                  </button>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
}

export default Register;
