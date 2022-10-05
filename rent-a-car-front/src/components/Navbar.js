import React from "react";
import {NavLink } from "react-router-dom";
import Button from "react-bootstrap/Button";
import Container from "react-bootstrap/Container";
import Form from "react-bootstrap/Form";
import Nav from "react-bootstrap/Nav";
import Navbar from "react-bootstrap/Navbar";
import logo from "../img/logo.png";
import "./Navbar.css"

function Header() {
  const brandStyle = {
    height: "55px",
    top: "10px",
  };
  return (
      <Navbar collapseOnSelect expand="lg" bg="dark" variant="dark">
        <Container>
          <Navbar.Brand href="#home" className="brandName">
            <img style={brandStyle} src={logo} alt={"logo"} />
          </Navbar.Brand>
          <Navbar.Toggle aria-controls="responsive-navbar-nav" />
          <Navbar.Collapse id="responsive-navbar-nav">
            <Nav className="nav-links me-auto">
              <NavLink className="text-light fw-bold text-decoration-none" to="/">
                Əsas Səhifə
              </NavLink>
              <NavLink className="text-light fw-bold text-decoration-none" to="/rent">
              Avtomobil icarəsi
              </NavLink>
              <NavLink className="text-light fw-bold text-decoration-none" to="/blog">
                Bloq
              </NavLink>
              <NavLink className="text-light fw-bold text-decoration-none" to="/about">
                Haqqımızda
              </NavLink>
              <NavLink className="text-light fw-bold text-decoration-none" to="/contact">
                Əlaqə
              </NavLink>
            </Nav>
            <Nav>
              <Nav.Link className="text-light fw-bold" href="#signIn">
                Daxil Ol
              </Nav.Link>
              <Nav.Link className="text-light fw-bold" href="#signUp">
                Qeydiyyat
              </Nav.Link>
            </Nav>
            <Form className="d-flex">
              <Form.Control
                type="search"
                placeholder="Axtarış"
                className="me-2"
                aria-label="Search"
              />
              <Button className="text-light fw-bold" variant="outline-success">
                Axtar
              </Button>
            </Form>
          </Navbar.Collapse>
        </Container>
      </Navbar>
  );
}

export default Header;
