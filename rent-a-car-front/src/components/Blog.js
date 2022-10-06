import React, { useEffect, useState } from "react";
import { NavLink } from "react-router-dom";
import Breadcrumb from "react-bootstrap/Breadcrumb";

function Blog() {

// const [cars, setCars] = useState("")

//   const getCars = () => {
//     Axios.get("https://localhost:44352/api/cars")
//     .then((res) => {
//       console.log(res);
//       setCars(res.data)
//     })
//   };

const [cars, setCars] = useState(false)

useEffect(() => {

fetch("https://localhost:44352/api/cars")
.then(res => {
  if(res.ok && res.status === 200){
    return res.json()
  }
})
//  .then(data => setCars(data.items))
 .then(data => setCars(data.items))
.catch(err => console.log(err))

},[]);


  return (
    <div>
      <div style={{ display: "block", width: 700, padding: 30 }}>
        <Breadcrumb>
          <Breadcrumb.Item>
            <NavLink to="/">Əsas Səhifə</NavLink>
          </Breadcrumb.Item>
          <Breadcrumb.Item>
            <NavLink to="/blog" className="text-muted">
              Bloq
            </NavLink>
          </Breadcrumb.Item>
        </Breadcrumb>
      </div>
      <div className="row">
      <div className="col-4">
        {/* <button onClick={getCars}>Get datas</button> */}
        <ul className="text-light">
          {cars && cars.map(car => (
            <li>
              {car.brand.name}
            </li>
          ))}
        </ul>
      </div>
      <div className="col-4">
        {/* <button onClick={getCars}>Get datas</button> */}
        <ul className="text-light">
          {cars && cars.map(car => (
            <li>
              {car.modelYear}
            </li>
          ))}
        </ul>
      </div>
      </div>
    </div>
  );
}

export default Blog;
