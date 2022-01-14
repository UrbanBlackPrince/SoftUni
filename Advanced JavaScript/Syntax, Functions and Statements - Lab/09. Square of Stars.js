function solve(size = 5){
    let symbol = '* ';

    for (let row = 0; row < size; row++) {
        console.log(symbol.repeat(size));            
    }
}

solve();
solve(1);
solve(2);
solve(3);
