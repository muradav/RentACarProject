import React from "react";
import { NavLink } from "react-router-dom";

function Login() {
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
                E-poçt ünvanı və şifrənizi daxil edin!
              </p>

              <input
                className="my-2 w-100"
                labelClass="text-white"
                placeholder="E-poçt"
                id="email"
                type="email"
                size="lg"
              />
              <input
                className="my-2 w-100"
                labelClass="text-white"
                placeholder="Şifrə"
                id="password"
                type="password"
                size="lg"
              />

              <p className="small mb-3 pb-lg-2">
                <a class="text-white-50" href="#!">
                  Şifrəni unutmusunuz?
                </a>
              </p>
              <button
                outline
                className="mx-2 px-5 btn btn-dark"
                color="white"
                size="lg"
              >
                Daxil Ol
              </button>

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
