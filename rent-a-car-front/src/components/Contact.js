import React from "react";
import { NavLink } from "react-router-dom";
import ScrollToTopButton from "./ScrollTopButton";
// import { MDBNavbar,MDBContainer,MDBBreadcrumb,MDBBreadcrumbItem,} from "mdb-react-ui-kit";
import 'bootstrap/dist/css/bootstrap.css';
import Breadcrumb from 'react-bootstrap/Breadcrumb';
import Iframe from "react-iframe";
import { GoLocation } from "react-icons/go";
import { FiPhoneCall } from "react-icons/fi";
import { MdAlternateEmail } from "react-icons/md";
import { BsWhatsapp } from "react-icons/bs";
import "./Contact.css";

function Contact() {
  return (
    <div>
      {/* <MDBNavbar light bgColor="transparent" style={{ marginTop: "20px" }}>
        <MDBContainer fluid>
          <nav aria-label="breadcrumb">
            <MDBBreadcrumb>
              <MDBBreadcrumbItem>
                <NavLink to="/" color="inherit">Əsas Səhifə</NavLink>
              </MDBBreadcrumbItem>
              <MDBBreadcrumbItem active aria-current="page">
                <NavLink to="/contact" color="">Əlaqə</NavLink>
              </MDBBreadcrumbItem>
            </MDBBreadcrumb>
          </nav>
        </MDBContainer>
      </MDBNavbar> */}
      <div style={{ display: 'block', 
                  width: 700, padding: 30 }}>
      <Breadcrumb>
        <Breadcrumb.Item>
        <NavLink to="/">Əsas Səhifə</NavLink>
        </Breadcrumb.Item>
        <Breadcrumb.Item >
        <NavLink to="/contact" active>Əlaqə</NavLink>
        </Breadcrumb.Item>
      </Breadcrumb>
    </div>
      <div className="container mt-3 mb-5 pt-3 pb-3">
        <div className="row">
          <h2 className="text-light bg-dark text-center mb-5 pt-2 pb-2">
            Bizimlə Əlaqə
          </h2>
          <div className="col-6">
            <Iframe
              url={"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3039.4284901456376!2d49.85175681489334!3d40.377194965967796!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d079efb5163%3A0xc20aa51a5f0b5e01!2sCode%20Academy!5e0!3m2!1sen!2s!4v1664827538952!5m2!1sen!2s"}
              width="600px"
              height="300px"
              id=""
              className=""
              display="block"
              position="relative"
              allowfullscreen="true"
            />
          </div>
          <div className="col-1"></div>
          <div className="col-5 fw-bold">
            <ul className="text-light">
              <li>
                <GoLocation />
                <span> Telnov küçəsi, 10/149. Xətai, Bakı</span>
              </li>
              <li className="mt-3">
                <BsWhatsapp />
                <span> +994 55 347 08 80</span>
              </li>
              <li className="mt-3">
                <FiPhoneCall />
                <span> +994 55 347 08 80</span>
              </li>
              <li className="mt-3">
                <FiPhoneCall />
                <span> +994 12 347 08 80</span>
              </li>
              <li className="mt-3">
                <MdAlternateEmail />
                <span> office@hotwheel.az</span>
              </li>
            </ul>
          </div>
        </div>
      </div>
      <ScrollToTopButton />
    </div>
  );
}

export default Contact;
