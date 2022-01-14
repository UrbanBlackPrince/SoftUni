function solve(numOne,numTwo,operator){
    let result;
    if(operator === '+'){
      result = numOne + numTwo;
    }else if(operator === '-'){
        result = numOne - numTwo
    }else if(operator === '*'){
        result = numOne * numTwo
    }else if(operator == '/'){
        result = numOne / numTwo;
    }else if(operator == '%'){
        result = numOne % numTwo
    }else if(operator == '**'){
        result = numOne ** numTwo;
    }

    console.log(result);
}

solve(3,4,'+');