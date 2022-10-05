import React from "react";
import { useState, useEffect } from "react";
import { Routes, Route } from "react-router-dom";
import ScrollToTop from "./components/ScrollToTop";
import Navbar from "./components/Navbar";
import Home from "./components/Home";
import JsonData from "./data/data.json";
import Subscribe from "./components/Subscribe";
import Footer from "./components/Footer";
import About from "./components/About";
import Contact from "./components/Contact";
import Blog from "./components/Blog";
import Rent from "./components/Rent";
import RentDetail from "./components/RentDetail";
import ElectricCarRent from "./components/ElectricCarRent";

function App() {
  const [pageData, setPageData] = useState({});
  useEffect(() => {
    setPageData(JsonData);
  }, []);
  return (
    <div className="App">
      <Navbar />
      <ScrollToTop>
        <Routes>
          <Route path="/" exact element={<Home />} />
          <Route path="/rent" element={<Rent />} />
          <Route path="/electicCarRent" element={<ElectricCarRent />} />
          <Route path="/rentDetails" element={<RentDetail />} />
          <Route path="/blog" element={<Blog />} />
          <Route path="/about" element={<About />} />
          <Route path="/contact" element={<Contact />} />
        </Routes>
      </ScrollToTop>
      <Subscribe data={pageData.Subscribe} />
      <Footer />
    </div>
  );
}

export default App;
