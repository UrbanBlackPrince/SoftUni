function calc() {
    let firstElement = document.getElementById('num1');
    let secondElement = document.getElementById('num2');

    let num1 = Number(firstElement.value);
    let num2 = Number(secondElement.value);

    let sum = num1 + num2;
    let result = document.getElementById('sum');
   
    result.value = sum;
}
