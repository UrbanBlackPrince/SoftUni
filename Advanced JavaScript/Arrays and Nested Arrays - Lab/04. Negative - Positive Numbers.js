function solve(arr){
    let finalArray = [];

    for(let num of arr){
        if(num < 0){
            finalArray.unshift(num);
        }else{
            finalArray.push(num);
        }
    }
    
    for(let result of finalArray){
        console.log(result);
    }
}

solve([7, -2, 8, 9]);