// creating an array
var employee=["John","Vinuth","Ravi"];  
for (i=0;i<employee.length;i++)
{  
    console.log(employee[i]);  
}

// array foreach() method => calls a function for each element in an array
var sum=0;
const values=[1,2,3,4,5];
values.forEach(sumFunc);

function sumFunc(item){
    sum+=item;
}
console.log(sum);


// array map() method => calls the specified function for every array element and returns the new array

const numbersArray=[1,2,3];  
const newNumbersArray=numbersArray.map(multiply);  

function multiply(number){
    return number * 10;
}
console.log(newNumbersArray);


// array filter() method => It returns the new array containing the elements that pass the provided function conditions.
let numbers=[1,2,3,4,5,6,7,8,9,10]
let evenNumbers=numbers.filter(function(element){
    return element%2==0;
})
console.log(evenNumbers);