function getData() {
    const checkBoxes = document.querySelectorAll('input[type="checkbox"]');
    const selectedValues = Array.from(checkBoxes)
      .filter(item => item.checked)
      .map(item => item.value);
  
    //const resultString = "Selected: " + JSON.stringify(selectedValues); // Displays Selected: ["Java","Python"]
    const resultString = "Selected: " + selectedValues.join(", "); // Selected: Java, Python
  
    console.log(resultString); // Prints in the console
    document.querySelector('.result').textContent = resultString; // Displays in the browser

    //document.getElementById("item").addEventListener('submit',(event)=>{event.preventDefault();})
    
  }
  
  