import React from "react";
import { useState, useEffect } from "react";
import { Routes, Route } from "react-router-dom";
import Navbar from "./components/Navbar";
import Home from "./components/Home";
import JsonData from "./data/data.json";
import Subscribe from "./components/Subscribe";
import Footer from "./components/Footer";
import About from "./components/About";
import Contact from "./components/Contact";
import Blog from "./components/Blog";
import Rent from "./components/Rent";

function App() {
  const [pageData, setPageData] = useState({});
  useEffect(() => {
    setPageData(JsonData);
  }, []);
  return (
      <div className="App">
        <Navbar />
        <Routes>
          <Route path="/" exact element={<Home />} />
          <Route path="/rent" element={<Rent />} />
          <Route path="/blog" element={<Blog />} />
          <Route path="/about" element={<About />} />
          <Route path="/contact" element={<Contact />} />
        </Routes>
        <Subscribe data={pageData.Subscribe} />
        <Footer />
      </div>
  );
}

export default App;
