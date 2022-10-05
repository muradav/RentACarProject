import React from "react";
import { MdOutlineAttachMoney } from "react-icons/md";
import { FiSettings } from "react-icons/fi";
import { AiOutlineLike } from "react-icons/ai";
import { TbDiscount2 } from "react-icons/tb";
import { BsSmartwatch } from "react-icons/bs";
import { VscAccount } from "react-icons/vsc";

function WhyUs() {
  return (
    <div
      className="container mt-3 mb-3 pt-3 pb-3 text-center"
      id="introCont"
      style={{ backgroundColor: "transparent" }}
    >
      <div className="mb-3">
        <hr className="text-light" />
      </div>
      <h2 className="container text-light bg-dark pt-2 pb-2">
        BİZİM ƏSAS ÜSTÜNLÜKLƏRİMİZ
      </h2>
      <div className="row pt-3">
        <div className="col-4">
          <div style={{ fontSize: "80px", color: "white" }}>
            <MdOutlineAttachMoney
              style={{ border: "solid white 3px", borderRadius: "50%" }}
            />
          </div>
          <div>
            <h4 style={{ color: "white" }}>VƏSAİTLƏRƏ QƏNAƏT</h4>
            <hr style={{ color: "white" }} />
            <p style={{ fontSize: "20px", color: "white" }}>
              bizim şirkətimizdə siz icarənin ən əlverişli şərtləri üzrə böyük
              miqdarda məşhur avtomobil tapacaqsınız
            </p>
          </div>
        </div>
        <div className="col-4 justify-content-between">
          <div style={{ fontSize: "80px", color: "white" }}>
            <FiSettings />
          </div>
          <div>
            <h4 style={{ color: "white" }}>GENİŞ SEÇİM</h4>
            <hr style={{ color: "white" }} />
            <p style={{ fontSize: "20px", color: "white" }}>
              biz ekonom, biznes və premium sinfindən olan Sedan xetçbek,
              yolsuzluq maşınları, həmçinin avtobus və mikroavtobusların böyük
              seçimini təklif edirik
            </p>
          </div>
        </div>
        <div className="col-4">
          <div style={{ fontSize: "80px", color: "white" }}>
            <AiOutlineLike />
          </div>
          <div>
            <h4 style={{ color: "white" }}>KEYFİYYƏTLİ XİDMƏT</h4>
            <hr style={{ color: "white" }} />
            <p style={{ fontSize: "20px", color: "white" }}>
              ofisimizdəki yüksək səviyyəli xidmətlər və ya İnternet vasitəsilə
              avtomobil sifarişinin həyata keçirilməsi Sizi müsbət şəkildə
              təəccübləndirəcək
            </p>
          </div>
        </div>
      </div>
      <div className="row pt-3">
        <div className="col-4">
          <div style={{ fontSize: "80px", color: "white" }}>
            <TbDiscount2 />
          </div>
          <div>
            <h4 style={{ color: "white" }}>ENDİRİM VƏ XÜSUSİ TƏKLİFLƏR</h4>
            <hr style={{ color: "white" }} />
            <p style={{ fontSize: "20px", color: "white" }}>
              biz şirkətimizin müştəriləri üçün böyük miqdarda aksiyalar və
              xüsusi təkliflər təklif edirik
            </p>
          </div>
        </div>
        <div className="col-4 justify-content-between">
          <div style={{ fontSize: "80px", color: "white" }}>
            <BsSmartwatch />
          </div>
          <div>
            <h4 style={{ color: "white" }}>VAXTA QƏNAƏT</h4>
            <hr style={{ color: "white" }} />
            <p style={{ fontSize: "20px", color: "white" }}>
              bizim şirkətimiz vasitəsilə Bakıda avtomobil kirayəsinin sifarişi
              və xidmətin rəsmiləşdirilməsi proseduru Sizdən uzağı 10-15 dəqiqə
              vaxt tələb edəcək
            </p>
          </div>
        </div>
        <div className="col-4">
          <div style={{ fontSize: "80px", color: "white" }}>
            <VscAccount />
          </div>
          <div>
            <h4 style={{ color: "white" }}>FƏRDİ YANAŞMA</h4>
            <hr style={{ color: "white" }} />
            <p style={{ fontSize: "20px", color: "white" }}>
              biz sizin tələb və arzularınıza bilavasitə uyğun olan xüsusi
              şərtləri və nəqliyyat vasitələrini təqdim edirik
            </p>
          </div>
        </div>
      </div>
    </div>
  );
}

export default WhyUs;
