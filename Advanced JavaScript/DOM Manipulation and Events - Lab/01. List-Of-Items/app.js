function addItem() {
    let existingElement = document.getElementById('items'); //референция на съществуващ елемент
    let nextElement = document.createElement('li'); // създаваме място в паметта за новият елемент
    let elementTOAdd = document.getElementById('newItemText').value; //взимаме стойността на новият елемент
    nextElement.textContent = elementTOAdd; //правиме записването на новият елемен
    existingElement.appendChild(nextElement); // правим закачане към DOM дървото


}