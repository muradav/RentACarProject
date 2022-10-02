import Button from 'react-bootstrap/Button';

function ElectricCar(){
    return(
<div className="row pt-4 justify-content-between">
        <div className="col-1"></div>
    <div className="col-3 text-light text-center">
    <h3 className="pt-5 pb-4">Elektrik avtomobillər ilə gələcək nəsillərə daha sağlam təbiət bəxş edək!</h3>
    <Button  variant="dark" size="lg">Indi Sifariş Et</Button>
    </div>
    <div className="col-1"></div>
    <div className="col-5 pl-4">
        <img src="https://blog.ipleaders.in/wp-content/uploads/2020/12/The_Rising_Trends-of-Electric-Vehicles-1-696x464.jpeg"/>
    </div>
    <div className='col-2'></div>
</div>
    );
}

export default ElectricCar;