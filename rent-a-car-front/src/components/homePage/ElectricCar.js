import React from "react";
import { NavLink } from "react-router-dom";
import Button from "react-bootstrap/Button";
import ScrollToTopButton from "../ScrollTopButton";
import "./ElectricCar.css";

function ElectricCar() {
  return (
    <>
    <div className="container ">
      <div className="row pt-5">
        <div className="col-5 text-light text-center justify-content-start">
          <h3 className="pt-5 pb-4 mt-5">
            Elektrik avtomobillər ilə gələcək nəsillərə daha sağlam təbiət bəxş
            edək!
          </h3>
          <NavLink to="/electicCarRent">
            <Button variant="dark" size="lg">
              Indi Sifariş Et
            </Button>
          </NavLink>
        </div>
        <div className="electric col-7"></div>
      </div>
    </div>
    <ScrollToTopButton />
    </>
  );
}

export default ElectricCar;
