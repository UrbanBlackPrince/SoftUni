function solve(arr){
  let finalArray = [];

  for(let counter = 0; counter < arr.length; counter++){
      if(counter % 2 !== 0){
          let num = arr[counter];
          let numToPush = num * 2;
          finalArray.unshift(numToPush);
      }
  }

  //let arrayToLog = finalArray.reverse();
  console.log(finalArray.join(' '));
}

//solve([10, 15, 20, 25]);
solve([3, 0, 10, 4, 7, 3]);