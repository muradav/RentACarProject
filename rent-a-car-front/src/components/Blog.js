import React from "react";
import { NavLink } from "react-router-dom";
import Breadcrumb from 'react-bootstrap/Breadcrumb';


function Blog(){
return(
<div>
<div style={{ display: "block", width: 700, padding: 30 }}>
        <Breadcrumb>
          <Breadcrumb.Item>
            <NavLink to="/">Əsas Səhifə</NavLink>
          </Breadcrumb.Item>
          <Breadcrumb.Item>
            <NavLink to="/blog" active>
              Bloq
            </NavLink>
          </Breadcrumb.Item>
        </Breadcrumb>
      </div>
</div>
);
}

export default Blog;