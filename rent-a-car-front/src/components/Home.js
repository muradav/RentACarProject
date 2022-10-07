import React from "react";
import { useState, useEffect } from "react";
import JsonData from "../data/data.json";
import Header from "./homePage/Header"
import Introduction from "./homePage/Introduction";
import WhyUs from "./homePage/WhyUs";
import ElectricCar from "./homePage/ElectricCar";
import ScrollToTopButton from "./ScrollTopButton";

function Home() {
    const [pageData, setPageData] = useState({});
  useEffect(() => {
    setPageData(JsonData);
  }, []);
  return (
    <div>
      <Header data={pageData.Header} />
      <Introduction />
      <ElectricCar />
      <WhyUs />
      <ScrollToTopButton />
    </div>
  );
}

export default Home;
