function extractText() {
    let textAreaElement = document.getElementById('items');
    //console.log(textAreaElement.textContent);

     let texContentArea = document.getElementById('result');
     texContentArea.textContent = textAreaElement.textContent;
}