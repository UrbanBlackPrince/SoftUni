function solve(fruit,grams,pricePerKilo){
    let kilogrames = grams / 1000;
    let moneyNeed = 0;
    moneyNeed = kilogrames * pricePerKilo;

    console.log(`I need ${'$' + moneyNeed.toFixed(2)} to buy ${kilogrames.toFixed(2)} kilograms ${fruit}.`);
}

solve('orange', 2500, 1.80);