function perform() {
    var firstnumber = parseInt(document.getElementById("firstnumber").value);
    var secondnumber = parseInt(document.getElementById("secondnumber").value);
    var operation = document.getElementById("operation").value;

    var result;

    switch (operation) {
        case "add":
            result = firstnumber + secondnumber;
            break;
        case "subtract":
            result = firstnumber - secondnumber;
            break;
        case "multiply":
            result = firstnumber * secondnumber;
            break;
        case "divide":
            if (secondnumber === 0) {
                console.log("Cannot divide by zero.");
                document.getElementById("error").innerText="Cannot divide by zero!";
                return;
            }
            result = firstnumber / secondnumber;
            break;
        default:
            console.log("Please select an operation!");
            document.getElementById("error").innerText="please select an operation!";

            break;
    }

    console.log(`User selected ${operation} and the result is ${result}`);
    document.getElementById("resultOne").value=result;
    document.getElementById("result").textContent="User selected " +operation + " and the result is " +result;
}

document.getElementById("operation").addEventListener("change",function(){
    var message=" ";
    document.getElementById("error").textContent=message;
})