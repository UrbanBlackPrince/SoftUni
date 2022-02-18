function listOfNames(inputArray){
    inputArray
        .sort((a,b) => a.localeCompare(b))
        .forEach((x, i) => console.log(`${i + 1}.${x}`));
}

// function solve(array){
//     let printArrey = array.sort();
//     let counter = 1;

//     for(let i = 0; i < printArrey.length; i++){
//         console.log(`${counter}.${printArrey[i]}`);
//         counter++;
//     }
   
// }

solve(["John", "Bob", "Christina", "Ema"])