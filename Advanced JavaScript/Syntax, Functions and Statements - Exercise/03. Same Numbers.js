function solve(digit){

   let numbersArray = digit.toString().split('');
   let currNum = 0;
    let result = true;
    let sum = 0;
    currNum = numbersArray[0];
    
    for(let i = numbersArray[0]; i < numbersArray.length; i++){
        let numToComapre = numbersArray[i]
       if(currNum !== numToComapre){
          result = false;
          break; 
        }else{
         result = true;
        }
        currNum = numbersArray[i];
    }

    for(let j = 0; j < numbersArray.length; j++){
        sum += Number(numbersArray[j]);
    }

    console.log(result);
    console.log(sum);
}

solve(1234);
solve(2222222);
