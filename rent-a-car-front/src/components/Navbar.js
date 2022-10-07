import React from "react";
import {NavLink } from "react-router-dom";
import Button from "react-bootstrap/Button";
import Container from "react-bootstrap/Container";
import Form from "react-bootstrap/Form";
import Nav from "react-bootstrap/Nav";
import Navbar from "react-bootstrap/Navbar";
import NavDropdown from 'react-bootstrap/NavDropdown';
import logo from "../img/logo.png";
import account from "../img/account.png";
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
            {/* <Nav>
              <NavLink className="text-light fw-bold mx-2" to="/signIn">
                Daxil Ol
              </NavLink>
              <NavLink className="text-light fw-bold mx-2" to="/signUp">
                Qeydiyyat
              </NavLink>
            </Nav> */}
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
            <Nav>
            <NavDropdown
              id="nav-dropdown-dark-example"
              title={<img style={{height:"35px", paddingLeft:"20px"}} src={account} alt={"account"} />}
              menuVariant="dark"
            >
              <NavDropdown.Item>
                <NavLink to="/signIn" className="text-white">Daxil Ol</NavLink>
                </NavDropdown.Item>
              <NavDropdown.Divider />
              <NavDropdown.Item>
              <NavLink to="/register" className="text-white">Qeydiyyat</NavLink>
                </NavDropdown.Item>
            </NavDropdown>
          </Nav>
          </Navbar.Collapse>
        </Container>
      </Navbar>
  );
}

export default Header;
