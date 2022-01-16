function solve(input){
  let result ='';

  for(let counter = 0; counter < input.length; counter++){
      if(counter % 2 === 0){
        result += input[counter];
        result += ' ';
      }
  }
  console.log(result);
}

// function evenPositionElements(inputArray){
//     let result = inputArray
//         .filter((x, i) => i % 2 == 0)
//         .join(' ');
   
//     console.log(result);
// }

solve(['20', '30', '40', '50', '60']);