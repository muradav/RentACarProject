import { useState, useEffect } from "react";
import Navbar from "./components/Navbar";
import  Header  from "./components/Header";
import JsonData from "./data/data.json";
import Subscribe from "./components/Subscribe";
import Footer from "./components/Footer";
import Introduction from "./components/Introduction"
import WhyUs from "./components/WhyUs";
import ElectricCar from "./components/ElectricCar";


function App() {
  const [pageData, setPageData] = useState({});
  useEffect(() => {
    setPageData(JsonData);
  }, []);
  return (
    <div className="App">
      <Navbar />
      <Header data={pageData.Header}/>
      <Introduction />
      <ElectricCar />
      <WhyUs />
      <Subscribe data={pageData.Subscribe}/>
      <Footer />
    </div>
  );
}

export default App;
