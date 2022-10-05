import React from "react";
import { NavLink } from "react-router-dom";
import Button from "react-bootstrap/Button";
// import Card from "react-bootstrap/Card";
import "./Header.css";

function Header(props) {
  return (
    <div className="header text-light">
        <h1>
          {props.data ? props.data.title : "Loading"}
        </h1>
        <NavLink to="/rent">
          <Button variant="dark">Onlayn Sifariş</Button>
        </NavLink>
    </div>
  );
}

export default Header;
