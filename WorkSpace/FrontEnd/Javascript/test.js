function finalPrice(orderArray){

    // let total=0

    // for(let i=0;i<orderArray.length;i++){

    //     let obj=orderArray[i]

    //     let subtotal=obj.unitCost*obj.quantity;

    //     total=total+subtotal;

    // }

    // return total
    let totalPrice = 0;
    orderArray.forEach((element) => {
        let obj=JSON.parse(element)
        let sum = obj.unitCost * obj.quantity;
        totalPrice += sum;
    });
    return totalPrice;

}

 
let orderArray=[
    '{"pid":"2312","unitCost":"30","quantity":"3"}',
    '{"pid":"3312","unitCost":"10","quantity":"2"}'
]

 

const result=finalPrice(orderArray)

console.log(result)