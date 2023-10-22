function register(){
    const fullname = document.getElementById("fullname").value;
    const email = document.getElementById("email").value;
    const dob = document.getElementById("dob").value;
    const country = document.getElementById("country").value;

    const gender = document.querySelectorAll('input[type="radio"]:checked');
    const selecedGender =Array.from(gender).map(x=>x.value);

    const meal = document.querySelectorAll('input[name="Rice"]:checked');
    const selectedMeal=Array.from(meal).map(x=>x.value);

    const preferences = document.querySelectorAll('input[name="Bread"]:checked');
    const selectedPreferences=Array.from(preferences).map(x=>x.value);
    

    let isValid=true;
    if (fullname=="") {
        alert("Please enter fullname");
       // document.getElementById("error").textContent = "please enter fullname";
        isValid = false;
      }
    
     else if (dob=="") {
        alert("Please select date of birth");
        isValid = false;
      }
    
     else  if (selecedGender== "") {
        alert("Please select gender");
        isValid = false;
      }
    
     else {  
        //alert(`${fullname} is successfully registered.`);
        document.getElementById("display").textContent = fullname + " is successfully registered";

        const formData = {
          fullname: fullname,
          email:email,
          dob: dob,
          country: country,
          selecedGender: selecedGender,
          selectedMeal: selectedMeal,
          selectedPreferences: selectedPreferences
          
      };
      console.log(formData); 
      document.getElementById("customerForm").reset();
      } 
    
}

document.getElementById("fullname").addEventListener("change",function(){
  var message=" ";
  document.getElementById("error").textContent=message;
})