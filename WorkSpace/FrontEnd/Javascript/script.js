function getData() {
    const fullname = document.getElementById("fullname").value;
    const dob = document.getElementById("dob").value;
    const radiogroup = document.getElementById("radiogroup").value;
    let isValid = true;
  

    if (fullname.trim() === "") {
      alert("Please enter fullname");
      isValid = false;
    }
  
    if (dob.trim() === "") {
      alert("Please select date of birth");
      isValid = false;
    }
  
    if (radiogroup.trim() === "") {
      alert("Please select gender");
      isValid = false;
    }
  
    if (isValid) {
        const fullName = `${fullname}`; 
        const successMessageDiv = document.getElementById("fullname");
        
        successMessageDiv.innerText = `${fullName} is successfully registered.`;
        successMessageDiv.style.display = "block";
      
        document.getElementById("customerForm").reset();
    }
  }
  