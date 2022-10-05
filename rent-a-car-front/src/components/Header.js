import React from "react";
import Button from "react-bootstrap/Button";
// import Card from "react-bootstrap/Card";
import "./Header.css";

function Header(props) {
  return (
    <div className="header text-light">
        <h1>
          {props.data ? props.data.title : "Loading"}
        </h1>
        <Button variant="dark">Onlayn Sifariş</Button>
    </div>
  );
}

export default Header;
