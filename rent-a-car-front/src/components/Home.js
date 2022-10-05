import React from "react";
import { useState, useEffect } from "react";
import JsonData from "../data/data.json";
import Header from "./homePageComponents/Header"
import Introduction from "./homePageComponents/Introduction";
import WhyUs from "./homePageComponents/WhyUs";
import ElectricCar from "./homePageComponents/ElectricCar";
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
