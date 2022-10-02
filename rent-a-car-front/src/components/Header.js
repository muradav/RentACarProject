import Button from "react-bootstrap/Button";
import Card from "react-bootstrap/Card";
import "../components/Header.css";

function Header(props) {
  return (
    <Card className="header border-0 text-center align-text-bottom fw-bold text-light">
      <Card.Body className="header-content">
        <h1 className="align-text-bottom">{props.data ? props.data.title : 'Loading'}</h1>
        <Button variant="primary">Onlayn Sifariş</Button>
      </Card.Body>
    </Card>
  );
}

export default Header;
