import React from "react";
import Form from "react-bootstrap/Form";


function Register() {
  return (
    <>
      <div className="container">
        <div className="row d-flex align-items-center justify-content-center ">
          <div className="col-12">
            <div
              className="bg-dark text-white my-5 mx-auto"
              style={{ borderRadius: "1rem", maxWidth: "600px" }}
            >
              <div className="p-5 d-flex flex-column align-items-center mx-auto w-100">
                <h2 className="text-uppercase text-center mb-5">
                  Hesab yaradın
                </h2>
                <Form.Group
                  className="mb-3 col-sm-12"
                  controlId="name"
                >
                  <Form.Label>Ad</Form.Label>
                  <Form.Control type="text" />
                </Form.Group>
                <Form.Group
                  className="mb-3 col-sm-12"
                  controlId="surname"
                >
                  <Form.Label>Soyad</Form.Label>
                  <Form.Control type="text" />
                </Form.Group>
                <Form.Group
                  className="mb-3 col-sm-12"
                  controlId="username"
                >
                  <Form.Label>İstifadəçi Adı</Form.Label>
                  <Form.Control type="text" />
                </Form.Group>
                <Form.Group
                  className="mb-3 col-sm-12"
                  controlId="email"
                >
                  <Form.Label>Elektron poçt ünvanı</Form.Label>
                  <Form.Control type="email" />
                </Form.Group>
                <Form.Group
                  className="mb-3 col-sm-12"
                  controlId="rentCarName"
                >
                  <Form.Label>Telefon Nömrəsi</Form.Label>
                  <Form.Control type="text" />
                </Form.Group>
                <Form.Group
                  className="mb-3 col-sm-12"
                  controlId="password"
                >
                  <Form.Label>Şifrə</Form.Label>
                  <Form.Control type="text" />
                </Form.Group>
                <Form.Group
                  className="mb-3 col-sm-12"
                  controlId="repeatPass"
                >
                  <Form.Label>Təkrar Şifrə</Form.Label>
                  <Form.Control type="text" />
                </Form.Group>
                {/* <div className="d-flex flex-row justify-content-center mb-4">
                  <input
                    type="checkbox"
                    name="flexCheck"
                    id="flexCheckDefault"
                    label="I agree all statements in Terms of service"
                  />
                </div> */}
                <button
                outline
                className="mt-4 px-5 btn btn-dark"
                color="white"
                size="lg"
              >
                Hesab Yarat
              </button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
}

export default Register;
