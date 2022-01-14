function solve(numOne,numTwo){
    let firstNum = Number(numOne);
    let secondNum = Number(numTwo);
    let result = 0;

    for(let i = firstNum; i <= secondNum; i++){
        result += i;
    }
    return result;
}

console.log(solve('1','5'));

