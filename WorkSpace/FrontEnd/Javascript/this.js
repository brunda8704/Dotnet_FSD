const employee={
    firstName: "Ajay" ,
    lastName: "kumar" ,
    fullName: function(){
        console.log(this.firstName,this.lastName)
    }

}
employee.fullName()
console.log(employee)


// giving method access to object
const obj={
    name: "Anu",
    call:function(){
        return "Calling" + " " + this.name
    },

    callAgain:function(){
        return this.call() +  "....."
    }
}
console.log(obj.callAgain());



// execute the same code
function person(){
    console.log(this.name + "!!!");
}
person();


const firstObject={
    name: "Ajay",
    person:person
}
firstObject.person();


const secondObject={
    name: "Anuuu",
    person:person
}
secondObject.person();
