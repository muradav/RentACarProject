import React, { useEffect, useState } from "react";
import { NavLink } from "react-router-dom";
import "./Rent.css";

function RentCard() {
  const [cars, setCars] = useState([]);

  useEffect(() => {
    fetch("https://localhost:44352/api/cars")
      .then((res) => {
        if (res.ok && res.status === 200) {
          return res.json();
        }
      })
      .then(res=> console.log(res))
      .then((data) => setCars(data.items))
      .catch((err) => console.log(err));

  }, []);

  // console.log(cars);

  // const getCarId = (ev) => {
  //   console.log(ev.currentTarget.id);
  // };

  return (
    <div className="row mb-5">
      {cars &&
        cars.map((car, index) => (
          <div className="col-sm-4 card-col mb-5" key={index}>
            <div className="card" id={car.id}>
              <img
                className="card-img-top"
                src={car.carImages[0].imageUrl}
                alt=""
                style={{ width: "100%", height: "180px" }}
              ></img>
              <div className="card-body pt-3 px-0 pb-0">
                <div className="d-flex flex-row justify-content-between px-3">
                  <div className="d-flex flex-column">
                    <h3 className="text-muted" id="carName">
                      {car.brand.name} {car.name}
                    </h3>
                    <h4 className="text-muted">
                      Günlük İcarə Haqqı: {car.dailyPrice} AZN
                    </h4>
                  </div>
                </div>
                <hr className="mt-2 mx-3"></hr>
                <div className="mid">
                  <div className="d-flex flex-row justify-content-between px-3 pb-2 pt-2">
                    <div className="d-flex flex-column">
                      <span className="text-muted">Buraxılış ili</span>
                    </div>
                    <div className="d-flex flex-column">
                      <h5 className="mb-0">{car.modelYear}</h5>
                    </div>
                  </div>
                  <div className="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div className="d-flex flex-column">
                      <span className="text-muted">Yanacaq Növü</span>
                    </div>
                    <div className="d-flex flex-column">
                      <h5 className="mb-0">{car.fuelType}</h5>
                    </div>
                  </div>
                  <div className="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div className="d-flex flex-column">
                      <span className="text-muted">Ötürücü</span>
                    </div>
                    <div className="d-flex flex-column">
                      <h5 className="mb-0">{car.transmissionType}</h5>
                    </div>
                  </div>
                  <div className="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div className="d-flex flex-column">
                      <span className="text-muted">Rəng</span>
                    </div>
                    <div className="d-flex flex-column">
                      <h5 className="mb-0">{car.color.name}</h5>
                    </div>
                  </div>
                  <div className="d-flex flex-row justify-content-between px-3 pb-2 pt-1 mid">
                    <div className="d-flex flex-column">
                      <span className="text-muted">Oturacaq Sayı</span>
                    </div>
                    <div className="d-flex flex-column">
                      <h5 className="mb-0">{car.passengerCount}</h5>
                    </div>
                  </div>
                </div>
                <div className="rent-btn mt-3 pt-2 text-center">
                  <NavLink
                    // onClick={getCarId}
                    id={car.id}
                    className="text-decoration-none text-light"
                    to="/rentDetails"
                  >
                    <h5>Icarə Et</h5>
                  </NavLink>
                </div>
              </div>
            </div>
          </div>
        ))}
    </div>
  );
}

export default RentCard;
