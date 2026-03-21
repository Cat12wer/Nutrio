import React from 'react';
import './Sidebar.css';

const Sidebar: React.FC = () => {
  return (
    <aside className="sidebar">
      <div className="logo">
        <div className="logo-dot"></div>
        Nutrio
      </div>
      
      <nav className="nav-section">
        <div className="nav-item active">
          {/* Тут можна вставити SVG іконку з макета */}
          Головна
        </div>
        <div className="nav-item">Журнал</div>
        <div className="nav-item">Аналітика</div>
        <div className="nav-item">Метрики тіла</div>
        <div className="nav-item">Профіль</div>
      </nav>

      <div className="sidebar-footer">
        <div className="user-card">
          <div className="avatar">АК</div>
          <div>
            <div className="user-name">Андрій К.</div>
            <div className="user-goal">Схуднення · −500 ккал</div>
          </div>
        </div>
      </div>
    </aside>
  );
};

export default Sidebar;