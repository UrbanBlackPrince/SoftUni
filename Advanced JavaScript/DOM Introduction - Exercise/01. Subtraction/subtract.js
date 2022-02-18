function subtract() {
    let firstElement = document.getElementById('firstNumber');
    let secondElement = document.getElementById('secondNumber');

    let num1 = Number(firstElement.value);
    let num2 = Number(secondElement.value);

    let result = document.getElementById('result');
    let sum = num1 - num2;
    result.textContent = sum;
}