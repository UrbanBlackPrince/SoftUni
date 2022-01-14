function solve(numberOne,numberTwo,numberThree){
    if(numberOne > numberTwo && numberOne > numberThree)
    {
        console.log(`The largest number is ${numberOne}.`);
    }
    else if(numberTwo > numberOne && numberTwo > numberThree)
    {
        console.log(`The largest number is ${numberTwo}.`);
    }
    else if(numberThree > numberOne && numberThree > numberTwo)
    {
        console.log(`The largest number is ${numberThree}.`);
    }
}

solve(5, -3, 16);
solve(-3,-5,-20);

