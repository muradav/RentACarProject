import React from "react";
import { NavLink } from "react-router-dom";
import Breadcrumb from "react-bootstrap/Breadcrumb";

function About() {
  return (
    <div>
      <div style={{ display: "block", width: 700, padding: 30 }}>
        <Breadcrumb>
          <Breadcrumb.Item>
            <NavLink to="/">Əsas Səhifə</NavLink>
          </Breadcrumb.Item>
          <Breadcrumb.Item>
            <NavLink to="/about" active>
              Haqqımızda
            </NavLink>
          </Breadcrumb.Item>
        </Breadcrumb>
      </div>
      <div className="container col-6 "></div>
      <div className="col-1"></div>
      <div className="col-5">
        <h1>About</h1>
      </div>
    </div>
  );
}

export default About;
