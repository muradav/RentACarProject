import {React, useEffect} from "react";
import { ImArrowUp } from "react-icons/im";
import "./ScrollToTopButton.css";

function ScrollToTopButton () {
    const mybutton = document.getElementById("myBtn");

    window.onscroll = function() {scrollFunction()};
    
    function scrollFunction() {
      if (document.body.scrollTop > 10 || document.documentElement.scrollTop > 10) {
        mybutton.style.display = "block";
      } else {
        mybutton.style.display = "none";
      }
    }
    
    useEffect(() => {
        // 👇️ scroll to top on page load
        window.scrollTo({top: 0, left: 0, behavior: 'smooth'});
      }, []);


  return (
<div>
    <button onClick={() => {
          window.scrollTo({top: 0, left: 0, behavior: 'smooth'});
        }} id="myBtn" className="pt-2"><ImArrowUp /></button>
</div>
  );
};

export default ScrollToTopButton;