function solve(inputArray){
    let dictionary = {};
    for(let counter = 0; counter < inputArray.length; counter+=2){
        let product = inputArray[counter];
        let grams = Number(inputArray[counter + 1]);

        dictionary[product] = grams;
    }

    console.log(dictionary)
}

solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);