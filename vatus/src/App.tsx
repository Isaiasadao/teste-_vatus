
import { useEffect, useState } from 'react'
import './App.css'
import IMGes from './Barber_shop_img/barber-man.jpg'

function App() {
  const [data, setData]= useState([])
 useEffect(() =>{
  fetch('https://localhost:7273/api/Vatus/2').
  then(Response =>Response.json()).then(json =>{
    setData(json)
    console.log("jsonn",json)
  }).catch(e =>{
    console.log('e',e)
  })

 },[])

const postPutEvent = () =>{
const data ={
  name:'Adao',
  Home: 'about'
}
  fetch('https://localhost:7273/api/Vatus/2',{
    method:'POST',
    headers:{
      'Content-Type':'application/json',
      'Acess-control-Allow-Origin':'*'
    },
    body:JSON.stringify(data)
  }).
  then(Response =>{
    console.log("response", Response)
  }).catch(e =>{
    console.log('e',e)
  })

}


  return (
    <>
       <section id="banner">
       
        <div className='banner-text'>
            <h1>hair studio </h1>
            {
            data.map(user =>(<i>{user.name}</i>))}
            <p>style your hair is style your life</p>
            <div className='banner-btn'>
                <a href="#"><span></span> find out</a>
                <a href="#"><span></span>read more</a>
            </div>
        </div>


        <section id="feature">
        <div className="title-text">
            <p>FEATURE</p>
            <h1>Wy choose Us</h1>
        </div>
        <div className="feature-box">
            <div className="features">
                <h1>experienced staff</h1>
                <div className="feature-desc">
                    <div className="feature-icon">
                        <i className="fa-solid fa-shield-halved"></i>
                    </div>
                    <div className="feature-text">
                        <p>Donec eget ultricies sapi. Sed portitor, mauris
                            ate lob facilsis, elit sapie eleifend ligula,
                        </p>
                    </div>
                </div>
                <h1>pre book online</h1>
                <div className="feature-desc">
                    <div className="feature-icon">
                        <i className="fa-solid fa-check-square"></i>
                    </div>
                    <div className="feature-text">
                        <p>Donec eget ultricies sapi. Sed portitor, mauris
                            ate lob facilsis, elit sapie eleifend ligula,
                        </p>
                    </div>
                </div>
                <h1>alfordoble cost</h1>
                <div className="feature-desc">
                    <div className="feature-icon">
                        <i className="fa-solid fa-inr"></i>
                    </div>
                    <div className="feature-text">
                        <p>Donec eget ultricies sapi. Sed portitor, mauris
                            ate lob facilsis, elit sapie eleifend ligula,
                        </p>
                    </div>
                </div>
            </div>
            <div className="features-img">
                <img src={IMGes}  />
            </div>
        </div>
    </section>
    </section>
    </>
  )
}

export default App
