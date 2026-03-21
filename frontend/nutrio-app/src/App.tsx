import React from 'react';
import Sidebar from './components/Sidebar';
import './App.css';
import KcalRing from './components/KcalRing';

function App() {
  return (
    <div className="layout">
      <Sidebar />
      <main className="main-content">
        <div style={{ maxWidth: `300px`}} >
          <KcalRing />
        </div>
        
      </main>
    </div>
    
  );
  
}

export default App;