import React, { useState } from "react";
import { createBrowserRouter, Navigate, NavLink, useNavigate } from "react-router-dom";

function Login() {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
//  const history = createBrowserRouter();
 const navigate=useNavigate();

  async function signIn(e) {
    e.preventDefault();

    let dataToLogin = {
      username,
      password,
    };

    console.log(dataToLogin);

    await fetch("https://localhost:44352/api/auth/login", {
      method: "POST",
      body: JSON.stringify(dataToLogin),
      headers: {
        "Content-type": "application/json",
        Accept: "application/json",
      },
    })
      .then((res) => {
        if (res.ok && res.status === 200) {
          return res.json();
        }
      })
      .then((res) => console.log(res))
      .catch((err) => console.log(err))
  }

  function routeChange(e){

  e.preventDefault();
  window.history.pushState({}, undefined, "/");
  }

  return (
    <div className="container-fluid">
      <div className="row d-flex justify-content-center align-items-center h-100">
        <div col="12">
          <div
            className="bg-dark text-white my-5 mx-auto"
            style={{ borderRadius: "1rem", maxWidth: "400px" }}
          >
            <div className="p-5 d-flex flex-column align-items-center mx-auto w-100">
              <h2 className="fw-bold mb-2 text-uppercase">Daxil Ol</h2>
              <p className="text-white-50 mb-5">
                İstifadəçi Adı və Şifrənizi daxil edin!
              </p>
              <form method="post" action="#">
                <div className="mb-3">
                  <label for="username" className="form-label">
                    İstifadəçi Adı
                  </label>
                  <input
                    type="text"
                    className="form-control"
                    id="usernameLog"
                    value={username}
                    name="usernameLog"
                    onChange={(e) => setUsername(e.target.value)}
                  />
                </div>
                <div className="mb-3">
                  <label for="password" className="form-label">
                    Password
                  </label>
                  <input
                    type="password"
                    className="form-control"
                    id="passLog"
                    value={password}
                    name="passLog"
                    onChange={(e) => setPassword(e.target.value)}
                  />
                </div>
                <div className="mb-3 form-check">
                  <input
                    type="checkbox"
                    className="form-check-input"
                    id="rememberMe"
                    value=""
                    name="rememberMe"
                  />
                  <label className="form-check-label" for="rememberMe">
                    Yadda saxla
                  </label>
                </div>
                <button
                  className="mx-4 px-5 btn btn-dark"
                  color="white"
                  size="lg"
                  onClick={()=>{
                    signIn();
                    routeChange();
                  }}
                >
                  Daxil Ol
                </button>
              </form>
              {/* <div className="d-flex flex-row mt-3 mb-5">
                <MDBBtn
                  tag="a"
                  color="none"
                  className="m-3"
                  style={{ color: "white" }}
                >
                  <MDBIcon fab icon="facebook-f" size="lg" />
                </MDBBtn>

                <MDBBtn
                  tag="a"
                  color="none"
                  className="m-3"
                  style={{ color: "white" }}
                >
                  <MDBIcon fab icon="twitter" size="lg" />
                </MDBBtn>

                <MDBBtn
                  tag="a"
                  color="none"
                  className="m-3"
                  style={{ color: "white" }}
                >
                  <MDBIcon fab icon="google" size="lg" />
                </MDBBtn>
              </div> */}

              <div>
                <p className="mb-0">
                  Hesabınız yoxdur?{" "}
                  <NavLink to="/register" className="text-white-50 fw-bold">
                    Qeydiyyat
                  </NavLink>
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Login;
