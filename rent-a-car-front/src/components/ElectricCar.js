import React from "react";
import Button from "react-bootstrap/Button";
import "./ElectricCar.css";

function ElectricCar() {
  return (
    <div className=" container ">
      <div className="row pt-5">
        <div className="col-5 text-light text-center justify-content-start">
          <h3 className="pt-5 pb-4 mt-5">
            Elektrik avtomobillər ilə gələcək nəsillərə daha sağlam təbiət bəxş
            edək!
          </h3>
          <Button variant="dark" size="lg">
            Indi Sifariş Et
          </Button>
        </div>
        <div className="electric col-7"></div>
      </div>
    </div>
  );
}

export default ElectricCar;
