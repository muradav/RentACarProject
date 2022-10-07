import React from "react";
import { NavLink } from "react-router-dom";
import Breadcrumb from "react-bootstrap/Breadcrumb";
import "./rentPage/Rent.css";

function ElectricCarRent() {
  return (
    <div>
      <div style={{ display: "block", width: 700, padding: 30 }}>
        <Breadcrumb>
          <Breadcrumb.Item>
            <NavLink to="/">Əsas Səhifə</NavLink>
          </Breadcrumb.Item>
          <Breadcrumb.Item>
            <NavLink to="/electicCarRent" active>
              Elektrik avtomobil icarəsi
            </NavLink>
          </Breadcrumb.Item>
        </Breadcrumb>
      </div>
      <div className="container">
        <h2 className="container text-light bg-dark mb-5 pt-2 pb-2 text-center">
        Elektrik avtomobil icarəsi
        </h2>
        <div className="row mb-5">
          <div className="col-sm-4 card-col">
            <div className="card">
              <img
                className="card-img-top"
                src="https://images.unsplash.com/photo-1612468008274-9445bd56161e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Y29vbCUyMGNhcnxlbnwwfHwwfHw%3D&w=1000&q=80"
                alt=""
                style={{ width: "100%", height: "230px" }}
              ></img>
              <div className="card-body pt-3 px-0 pb-0">
                <div class="d-flex flex-row justify-content-between px-3">
                  <div class="d-flex flex-column">
                    <h3 class="text-muted">Audi TT</h3>
                    <h4 class="text-muted">Günlük İcarə Haqqı: 30 AZN</h4>
                  </div>
                </div>
                <hr class="mt-2 mx-3"></hr>
                <div className="mid">
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-2">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Buraxılış ili</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">2005</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Yanacaq Növü</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">Benzin</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Ötürücü</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">Avtomat</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Oturacaq Sayı</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">5</h5>
                    </div>
                  </div>
                </div>
                <div class="rent-btn mt-3 pt-1 text-center">
                  <NavLink
                    className="text-decoration-none text-light"
                    to="/rentDetails"
                  >
                    <h5>Icarə Et</h5>
                  </NavLink>
                </div>
              </div>
            </div>
          </div>
          <div className="col-sm-4 card-col">
            <div className="card">
              <img
                className="card-img-top"
                src="https://images.unsplash.com/photo-1612468008274-9445bd56161e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Y29vbCUyMGNhcnxlbnwwfHwwfHw%3D&w=1000&q=80"
                alt=""
                style={{ width: "100%", height: "230px" }}
              ></img>
              <div className="card-body pt-3 px-0 pb-0">
                <div class="d-flex flex-row justify-content-between px-3">
                  <div class="d-flex flex-column">
                    <h3 class="text-muted">Audi TT</h3>
                    <h4 class="text-muted">Günlük İcarə Haqqı: 30 AZN</h4>
                  </div>
                </div>
                <hr class="mt-2 mx-3"></hr>
                <div className="mid">
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-2">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Buraxılış ili</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">2005</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Yanacaq Növü</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">Benzin</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Ötürücü</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">Avtomat</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Oturacaq Sayı</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">5</h5>
                    </div>
                  </div>
                </div>
                <div class="rent-btn mt-3 pt-1 text-center">
                  <NavLink
                    className="text-decoration-none text-light"
                    to="/rentDetails"
                  >
                    <h5>Icarə Et</h5>
                  </NavLink>
                </div>
              </div>
            </div>
          </div>
          <div className="col-sm-4 card-col">
            <div className="card">
              <img
                className="card-img-top"
                src="https://images.unsplash.com/photo-1612468008274-9445bd56161e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Y29vbCUyMGNhcnxlbnwwfHwwfHw%3D&w=1000&q=80"
                alt=""
                style={{ width: "100%", height: "230px" }}
              ></img>
              <div className="card-body pt-3 px-0 pb-0">
                <div class="d-flex flex-row justify-content-between px-3">
                  <div class="d-flex flex-column">
                    <h3 class="text-muted">Audi TT</h3>
                    <h4 class="text-muted">Günlük İcarə Haqqı: 30 AZN</h4>
                  </div>
                </div>
                <hr class="mt-2 mx-3"></hr>
                <div className="mid">
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-2">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Buraxılış ili</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">2005</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Yanacaq Növü</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">Benzin</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Ötürücü</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">Avtomat</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Oturacaq Sayı</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">5</h5>
                    </div>
                  </div>
                </div>
                <div class="rent-btn mt-3 pt-1 text-center">
                  <NavLink
                    className="text-decoration-none text-light"
                    to="/rentDetails"
                  >
                    <h5>Icarə Et</h5>
                  </NavLink>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div className="row mb-5">
          <div className="col-sm-4 card-col">
            <div className="card">
              <img
                className="card-img-top"
                src="https://images.unsplash.com/photo-1612468008274-9445bd56161e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Y29vbCUyMGNhcnxlbnwwfHwwfHw%3D&w=1000&q=80"
                alt=""
                style={{ width: "100%", height: "230px" }}
              ></img>
              <div className="card-body pt-3 px-0 pb-0">
                <div class="d-flex flex-row justify-content-between px-3">
                  <div class="d-flex flex-column">
                    <h3 class="text-muted">Audi TT</h3>
                    <h4 class="text-muted">Günlük İcarə Haqqı: 30 AZN</h4>
                  </div>
                </div>
                <hr class="mt-2 mx-3"></hr>
                <div className="mid">
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-2">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Buraxılış ili</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">2005</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Yanacaq Növü</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">Benzin</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Ötürücü</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">Avtomat</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Oturacaq Sayı</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">5</h5>
                    </div>
                  </div>
                </div>
                <div class="rent-btn mt-3 pt-1 text-center">
                  <NavLink
                    className="text-decoration-none text-light"
                    to="/rentDetails"
                  >
                    <h5>Icarə Et</h5>
                  </NavLink>
                </div>
              </div>
            </div>
          </div>
          <div className="col-sm-4 card-col">
            <div className="card">
              <img
                className="card-img-top"
                src="https://images.unsplash.com/photo-1612468008274-9445bd56161e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Y29vbCUyMGNhcnxlbnwwfHwwfHw%3D&w=1000&q=80"
                alt=""
                style={{ width: "100%", height: "230px" }}
              ></img>
              <div className="card-body pt-3 px-0 pb-0">
                <div class="d-flex flex-row justify-content-between px-3">
                  <div class="d-flex flex-column">
                    <h3 class="text-muted">Audi TT</h3>
                    <h4 class="text-muted">Günlük İcarə Haqqı: 30 AZN</h4>
                  </div>
                </div>
                <hr class="mt-2 mx-3"></hr>
                <div className="mid">
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-2">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Buraxılış ili</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">2005</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Yanacaq Növü</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">Benzin</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Ötürücü</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">Avtomat</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Oturacaq Sayı</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">5</h5>
                    </div>
                  </div>
                </div>
                <div class="rent-btn mt-3 pt-1 text-center">
                  <NavLink
                    className="text-decoration-none text-light"
                    to="/rentDetails"
                  >
                    <h5>Icarə Et</h5>
                  </NavLink>
                </div>
              </div>
            </div>
          </div>
          <div className="col-sm-4 card-col">
            <div className="card">
              <img
                className="card-img-top"
                src="https://images.unsplash.com/photo-1612468008274-9445bd56161e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Y29vbCUyMGNhcnxlbnwwfHwwfHw%3D&w=1000&q=80"
                alt=""
                style={{ width: "100%", height: "230px" }}
              ></img>
              <div className="card-body pt-3 px-0 pb-0">
                <div class="d-flex flex-row justify-content-between px-3">
                  <div class="d-flex flex-column">
                    <h3 class="text-muted">Audi TT</h3>
                    <h4 class="text-muted">Günlük İcarə Haqqı: 30 AZN</h4>
                  </div>
                </div>
                <hr class="mt-2 mx-3"></hr>
                <div className="mid">
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-2">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Buraxılış ili</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">2005</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Yanacaq Növü</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">Benzin</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Ötürücü</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">Avtomat</h5>
                    </div>
                  </div>
                  <div class="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div class="d-flex flex-column">
                      <span class="text-muted">Oturacaq Sayı</span>
                    </div>
                    <div class="d-flex flex-column">
                      <h5 class="mb-0">5</h5>
                    </div>
                  </div>
                </div>
                <div class="rent-btn mt-3 pt-1 text-center">
                  <NavLink
                    className="text-decoration-none text-light"
                    to="/rentDetails"
                  >
                    <h5>Icarə Et</h5>
                  </NavLink>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default ElectricCarRent;
