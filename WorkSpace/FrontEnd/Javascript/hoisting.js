console.log("Hello!!");
console.log(login())
console.log(firstName) //var is not defined
console.log(LoginExpression()); //function expression => is not hoisted



var firstName="Brunda";

//function declaration
function login(){
    console.log("logging...")
}
function login(){
    console.log("logging logging")
}

//function expression => is not hoisted
var LoginExpression=function login(){
    console.log("logging...")
}

