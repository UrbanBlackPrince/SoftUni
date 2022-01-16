function solve (input){
   let last = input.pop();
   let first = input.shift();

   let result = Number(first) + Number(last);
   //return result
   console.log(result);
}

solve(['20', '30', '40']);