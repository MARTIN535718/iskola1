function toggleColor() {
    const body = document.body;
    const themeCheckbox = document.querySelector('.theme-checkbox');
  
    // Toggle the background color
    if (themeCheckbox.checked) {
      body.style.backgroundColor = 'black';
    } else {
      body.style.backgroundColor = 'white';
    }
  }
  