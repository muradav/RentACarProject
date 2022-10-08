import React, { useState } from "react";
import { NavLink } from "react-router-dom";
import Breadcrumb from "react-bootstrap/Breadcrumb";
import Form from "react-bootstrap/Form";
import Button from "react-bootstrap/Button";
import { Col, Row } from "react-bootstrap";
import { format } from "date-fns";
import { DayPicker } from "react-day-picker";
import "react-day-picker/dist/style.css";

function RentDetail() {
  const [startDate, setStartDate] = useState();
  const [endDate, setEndDate] = useState();

  let footerStart = <p>Xahiş edirik başlanğıc tarixi seçin</p>;
  if (startDate) {
    footerStart = <p>Siz {format(startDate, "PP")} seçdiniz.</p>;
  }

  let footerEnd = <p>Xahiş edirik bitmə tarixi seçin</p>;
  if (endDate) {
    footerEnd = <p>Siz {format(endDate, "PP")} seçdiniz.</p>;
  }


  return (
    <div>
      <div style={{ display: "block", width: 700, padding: 30 }}>
        <Breadcrumb>
          <Breadcrumb.Item>
            <NavLink to="/">Əsas Səhifə</NavLink>
          </Breadcrumb.Item>
          <Breadcrumb.Item>
            <NavLink className="text-muted" to="/rentDetails">
              İcarə Detalları
            </NavLink>
          </Breadcrumb.Item>
        </Breadcrumb>
      </div>
      <div className="container">
        <h2 className="container text-light bg-dark mb-5 pt-2 pb-2 text-center">
          Avtomobil icarəsi detalları
        </h2>
        <div className="row bg-light mb-4">
          <Form>
            <Col>
              <h3 className="mt-3">Şəxsi məlumatlar</h3>
              <Row>
                <Form.Group
                  className="mb-3 col-sm-6"
                  controlId="renterName"
                >
                  <Form.Label>Ad</Form.Label>
                  <Form.Control type="text" placeholder="Ad" />
                </Form.Group>
                <Form.Group
                  className="mb-3 col-sm-6"
                  controlId="renterSurname"
                >
                  <Form.Label>Soyad</Form.Label>
                  <Form.Control type="text" placeholder="Soyad" />
                </Form.Group>
                <Form.Group
                  className="mb-3 col-sm-6"
                  controlId="renterEmail"
                >
                  <Form.Label>Elektron poçt ünvanı</Form.Label>
                  <Form.Control type="text" placeholder="E-poçt" />
                </Form.Group>
                <Form.Group
                  className="mb-3 col-sm-6"
                  controlId="renterPhone"
                >
                  <Form.Label>Telefon Nömrəsi</Form.Label>
                  <Form.Control type="text" placeholder="Telefon Nömrəsi" />
                </Form.Group>
              </Row>
              <h3>İcarə Detalları</h3>
              <Row>
                <Form.Group
                  className="mb-3 col-sm-6"
                  controlId="rentCarName"
                >
                  <Form.Label>Avtomobil</Form.Label>
                  <Form.Control type="text" placeholder="Brand CarName" />
                </Form.Group>
                <Form.Group
                  className="mb-3 col-sm-6"
                  controlId="rentPrice"
                >
                  <Form.Label>Günlük İcarə Haqqı</Form.Label>
                  <Form.Control type="text" placeholder="İcarə Haqqı" />
                </Form.Group>
                <div className="col-sm-6" style={{paddingLeft:"130px"}}>
                <DayPicker
                className="startDate"
                  mode="single"
                  selected={startDate}
                  onSelect={setStartDate}
                  footer={footerStart}
                />
                </div>
                <div className="col-sm-6" style={{paddingLeft:"130px"}}>
                <DayPicker
                className="startDate"
                  mode="single"
                  selected={endDate}
                  onSelect={setEndDate}
                  footer={footerEnd}
                />
                </div>
              </Row>
            </Col>
            <NavLink>
              <Button
                className="my-4"
                style={{ marginLeft: "500px" }}
                variant="dark"
                type="submit"
                size="lg"
              >
                Submit
              </Button>
            </NavLink>
          </Form>
        </div>
      </div>
    </div>
  );
}

export default RentDetail;
