// function exampleFunction() {
//     let x = 10;
//     if (true) {
//       let x = 20; // The variable x declared inside the if block is separate from the outer x.
//       console.log(x); // Output: 20
//     }
//     console.log(x); // Output: 10
//   }
  
//   exampleFunction();

// const array=['x','y']
// array.push()
  
  

const jsonString = '{"name": "John", "age": 30, "city": "New York"}';


const person = JSON.parse(jsonString);

console.log(person.name); 
console.log(person.age);  
console.log(person.city); 
  