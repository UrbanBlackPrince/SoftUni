function getPieceOfPie(inputArray, firstPie, secondPie){
    let firstIndex = inputArray.indexOf(firstPie);
    let secondIndex = inputArray.indexOf(secondPie);

    let result = inputArray.slice(firstIndex, secondIndex + 1);
    return result;
}

console.log(getPieceOfPie(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie')
);
