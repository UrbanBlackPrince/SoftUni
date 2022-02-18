function getIncreasingSubsequence(inputArray){
    let result = [];    
    
    inputArray.reduce((result, x) => {
        if (result.length === 0 || result[result.length - 1] <= x) {
            result.push(x);
        }   
        
        return result;

    }, result);
    
    return result;
}

// function solve(array){
//     let biggest = array[0];
//     let printArray = [];
//     printArray.unshift(biggest);

//     for(let counter = 0; counter < array.length; counter++){
//         if(array[counter] > biggest){
//             biggest = array[counter]
//             printArray.push(biggest);
//         }
//     }

//    // return console.log(printArray.join('\r\n'));
//    return printArray;
// }

solve([1, 
    2, 
    3,
    4]
    )