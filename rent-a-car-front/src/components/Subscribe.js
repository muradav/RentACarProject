import React from 'react';
import Button from "react-bootstrap/Button";
import Form from "react-bootstrap/Form";
import InputGroup from "react-bootstrap/InputGroup";
import "./Subscribe.css";

function Subscribe(props) {
  return (
    <div className="subscribe">
      <div className="col-lg-8">
        <h2 className="text-light fw-bold">
        {props.data ? props.data.message : 'Loading'}
        </h2>
      </div>
      <div className="col-lg-8 pb-5">
        <InputGroup className="mb-3">
          <Form.Control
            placeholder="E-poçt ünvanı daxil edin"
            type="email"
            className="w-50"
          />
          <Button variant="dark" id="button-addon2">
            Abune Ol
          </Button>
        </InputGroup>
      </div>
    </div>
  );
}

export default Subscribe;
