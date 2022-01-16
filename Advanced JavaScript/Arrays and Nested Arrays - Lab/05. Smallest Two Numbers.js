function getSmallestElements(inputArray){
    let result = inputArray
        .map(x => x)
        .sort((x, y) => x - y)
        .slice(0, 2)
        .join(' ');
   
    console.log(result);   
}

getSmallestElements([30, 15, 50, 5]);
getSmallestElements([3, 0, 10, 4, 7, 3]);

// function solve(arr){
//     let smalest = arr[0];
//     let seconsSmallest = arr[0];
    

//     for(let i = 1; i < arr.length; i++){
//         if(arr[i] < smalest){
//             smalest = arr[i];
//         }
//     }

//     for(let i = 1; i < arr.length; i++){
//         if(arr[i] < seconsSmallest && arr[i] !== smalest){
//             seconsSmallest = arr[i];
//         }
//     }

//     let finalArray = [smalest, seconsSmallest];
//     console.log(finalArray.join(' '));
// }

// solve([30, 15, 50, 5]);