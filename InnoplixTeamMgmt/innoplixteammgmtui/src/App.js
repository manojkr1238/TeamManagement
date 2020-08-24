import React from 'react';
import './App.css';
import {BrowserRouter, Route, Switch}from 'react-router-dom';
import {NavigationMenu} from "./components/NavigationMenu";

function App() {
  return (
    <BrowserRouter>
    <NavigationMenu />
      <div className="container">
        
      </div>
    </BrowserRouter>
  );
}

export default App;
