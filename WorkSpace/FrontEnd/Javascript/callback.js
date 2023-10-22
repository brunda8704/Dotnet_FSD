function demo(name,callbackfunction){
    console.log("Hii" + " " + name)   
}

function callbackfunction(){
console.log("I'm a callback function!!")
}

demo('Sam',callbackfunction());