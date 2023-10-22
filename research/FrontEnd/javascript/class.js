// CLASS DECLARATION
//Declaring class  
class Person 
  {  
  
    constructor(id,name)  
    {  
      this.id=id;  
      this.name=name;  
    }  

    //Declaring method  
    details()  
    {  
        console.log(this.id+" "+this.name)  
    }  
}  

var personOne=new Person(101,"Akshay");  
personOne.details(); //calling method  






//CLASS EXPRESSION
var person= class{
    constructor(id,name)  
    {  
      this.id=id;  
      this.name=name;  
    }  

    //Declaring method  
    details()  
    {  
        console.log(this.id+" "+this.name)  
    }  
}  

var personOne=new Person(501,"Yaksha");  
var personTwo=new Person(502,"Vineeth");  
personOne.details(); //calling method  
personTwo.details(); 
