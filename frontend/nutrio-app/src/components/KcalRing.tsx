import React from 'react';
import './KcalRing.css';

const KcalRing: React.FC = () => {
  const consumed = 1424;
  const goal = 1900;
  const remaining = goal - consumed;
  
  const radius = 56;
  const circumference = 2 * Math.PI * radius;
  const offset = circumference - (consumed / goal) * circumference;

  return (
    <div className="ring-card">
      <div className="ring-wrap">
        <svg width="140" height="140" viewBox="0 0 140 140">
          <circle cx="70" cy="70" r={radius} className="ring-bg" />
          <circle 
            cx="70" cy="70" r={radius} 
            className="ring-progress"
            strokeDasharray={circumference} 
            strokeDashoffset={offset}
            transform="rotate(-90 70 70)"
          />
        </svg>
        <div className="ring-center">
          <div className="ring-kcal">{consumed}</div>
          <div className="ring-label">з {goal} ккал</div>
          <div className="ring-remaining">−{remaining} залишок</div>
        </div>
      </div>

      <div className="macro-row">
        <div className="macro-item">
          <div className="macro-bar-wrap"><div className="macro-bar protein"></div></div>
          <div className="macro-val">86</div><div className="macro-name">Білки</div>
        </div>
        <div className="macro-item">
          <div className="macro-bar-wrap"><div className="macro-bar fats"></div></div>
          <div className="macro-val">52</div><div className="macro-name">Жири</div>
        </div>
        <div className="macro-item">
          <div className="macro-bar-wrap"><div className="macro-bar carbs"></div></div>
          <div className="macro-val">164</div><div className="macro-name">Вуглев.</div>
        </div>
        <div className="macro-item">
          <div className="macro-bar-wrap"><div className="macro-bar fiber"></div></div>
          <div className="macro-val">14</div><div className="macro-name">Клітк.</div>
        </div>
      </div>
    </div>
  );
};

export default KcalRing;