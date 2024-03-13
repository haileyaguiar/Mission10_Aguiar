import React from 'react';
import './App.css';
import Header from './Header';
import BowlingList from './bowling/BowlingList';

function App() {
  return (
    <div className="App">
      <Header />
      <BowlingList />
    </div>
  );
}

export default App;
