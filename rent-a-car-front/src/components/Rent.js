import React from "react";
import { NavLink } from "react-router-dom";
import Breadcrumb from "react-bootstrap/Breadcrumb";
import ScrollToTopButton from "./ScrollTopButton";
import RentCard from "./rentPage/RentCard";

function Rent() {

  return (
    <div>
      <div style={{ display: "block", width: 700, padding: 30 }}>
        <Breadcrumb>
          <Breadcrumb.Item>
            <NavLink to="/">Əsas Səhifə</NavLink>
          </Breadcrumb.Item>
          <Breadcrumb.Item>
            <NavLink className="text-muted" to="/rent">
              Avtomobil icarəsi
            </NavLink>
          </Breadcrumb.Item>
        </Breadcrumb>
      </div>
      <div className="container">
        <h2 className="container text-light bg-dark mb-5 pt-2 pb-2 text-center">
          Avtomobil icarəsi
        </h2>
        <RentCard />
      </div>
      <ScrollToTopButton />
    </div>
  );
}

export default Rent;
