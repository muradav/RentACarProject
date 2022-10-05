import React from "react";
import { useState, useEffect } from "react";
import JsonData from "../data/data.json";
import Header from "./Header"
import Introduction from "./Introduction";
import WhyUs from "./WhyUs";
import ElectricCar from "./ElectricCar";

function Home() {
    const [pageData, setPageData] = useState({});
  useEffect(() => {
    setPageData(JsonData);
  }, []);
  return (
    <div>
      {/* <Header data={pageData.Header} /> */}
      <Header data={pageData.Header} />
      <Introduction />
      <ElectricCar />
      <WhyUs />
    </div>
  );
}

export default Home;
