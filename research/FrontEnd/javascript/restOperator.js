 
  // function with rest parameter
function addition(...myArgs) {
    let sum = 0;
    for (let i of myArgs) {
      sum += i;
    }
    return sum;
  }
  console.log(addition(5, 6));
  console.log(addition(5, 6, 7));
  console.log(addition(5, 6, 7, 8, 9));       
  