import Button from "react-bootstrap/Button";
import Container from "react-bootstrap/Container";
import Form from "react-bootstrap/Form";
import Nav from "react-bootstrap/Nav";
import Navbar from "react-bootstrap/Navbar";
import NavDropdown from "react-bootstrap/NavDropdown";
import logo from "../img/logo.png";

function Header() {
  const myStyle = {
    height: "55px",
    top: "10px",
  };
  return (
    <div>
      <Navbar collapseOnSelect expand="lg" bg="dark" variant="dark">
        <Container>
          <Navbar.Brand href="#home" className="brandName">
            <img style={myStyle} src={logo} alt={"logo"} />
          </Navbar.Brand>
          <Navbar.Toggle aria-controls="responsive-navbar-nav" />
          <Navbar.Collapse id="responsive-navbar-nav">
            <Nav className="me-auto">
              <Nav.Link className="text-light fw-bold" href="#features">
                Əsas Səhifə
              </Nav.Link>
              {/* <NavDropdown
                className="fw-bold"
                title={
                  <span className="text-light">
                    Kirayə maşınlar
                  </span>
                }
                menuVariant="dark"
                id="collasible-nav-dropdown"
              >
                <NavDropdown.Item href="#action/3.1">
                Ekonom klass maşınların icarəsi
                </NavDropdown.Item>
                <NavDropdown.Item href="#action/3.2">
                Biznes klass maşınların icarəsi
                </NavDropdown.Item>
                <NavDropdown.Item href="#action/3.3">
                VİP klass maşınların icarəsi
                </NavDropdown.Item>
              </NavDropdown> */}
              <Nav.Link className="text-light fw-bold" href="#pricing">
              Avtomobil icarəsi
              </Nav.Link>
              <Nav.Link className="text-light fw-bold" href="#pricing">
                Bloq
              </Nav.Link>
              <Nav.Link className="text-light fw-bold" href="#pricing">
                Haqqımızda
              </Nav.Link>
              <Nav.Link className="text-light fw-bold" href="#pricing">
                Əlaqə
              </Nav.Link>
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
    </div>
  );
}

export default Header;
