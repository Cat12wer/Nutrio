export const Button = ({ children, variant = 'primary', ...props }) => {
  // Використовуємо твої класи: btn-primary, btn-sm-green тощо.
  const className = variant === 'primary' ? 'btn-primary' : 'btn-sm-green';
  
  return (
    <button className={className} {...props}>
      {children}
    </button>
  );
};