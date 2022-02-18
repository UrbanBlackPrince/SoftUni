function colorize() {
    let elementsToColor = Array
        .from(document.querySelectorAll('tr'))
        .slice(1)
        .filter((x, i) => i % 2 == 0);

    for (const element of elementsToColor) {
        element.style.background = 'Teal';
    }
}

// function colorize() {
//     let rowsElements = document.querySelectorAll('tr:nth-of-type(2n) td');
//     rowsElements.forEach(x =>{
//         x.style.backgroundColor = 'teal';
//     });
    
// }