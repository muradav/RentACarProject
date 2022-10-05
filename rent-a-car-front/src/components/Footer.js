import React from 'react';
import { NavLink } from 'react-router-dom';
import logo from "../img/logo.png";
import telIcon from "../img/tel_icon.png";
import instagramIcon from "../img/instagram_icon.png";
import facebookIcon from "../img/fb_icon.png";
import "./Footer.css";

function Footer() {
  // const myStyle = {
  //   height: "100px",
  //   top: "10px",
  // };
  return (
    <div>
      <div className="row footer pb-3 ">
      <div className="col-6 fw-bold pt-5 text-center">
        <span id="footerCall">
          <img src={telIcon} alt={"telIcon"} id="imgCall" />
          <a
            className="text-decoration-none text-light"
            href="tel:+994 55 347 08 80"
          >
            +994 55 347 08 80
          </a>
        </span>
        <h4 className="text-light pt-4">İş saatları: 10:00 - 19:00</h4>
        <h5 className="text-light">
          Ünvan: Telnov küçəsi, 10/149. Xətai, Bakı.{" "}
        </h5>
      </div>
      <div className='col-1'></div>
      <div className="col-5 text-center" id="socialMedia">
        <a className="text-decoration-none" href={"https://www.facebook.com/"}>
          <img src={facebookIcon} alt={"facebookIcon"} />
        </a>
        <a className="text-decoration-none" href={"https://www.instagram.com/"}>
          <img src={instagramIcon} alt={"instagramIcon"} />
        </a>
      </div>
      <div className='text-center'>
        <hr className='text-light'/>
        <NavLink className="text-decoration-none text-light" to="/">Maşınların icarəsi xidmətləri</NavLink>
        <p className='text-light'>"HOT WHEEL CAR RENTAL" MMC © 2022 . Bütün hüquqlar qorunur. Məlumatlardan istifadə zamanı istinad vacibdir</p>
        <img style={{height:"45px"}} src={logo} alt={"logo"} />
      </div>
    </div>
    </div>
  );
}

export default Footer;
