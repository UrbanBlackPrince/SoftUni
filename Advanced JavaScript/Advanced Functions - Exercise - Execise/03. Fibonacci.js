function getFibonator() {
    let startNumber = 0;
    let step = 1;
    let currentNumber = 0;

    const fib = function () {
        startNumber = step;
        step = currentNumber;
        currentNumber = startNumber + step;

        return currentNumber;
    };

    return fib;
}

let fib = getFibonator();