function create(words) {
   let toAdd = document.querySelector('#content');

   words.forEach(word => {
       let newElement = document.createElement('div');

       let paragraph = document.createElement('p');
       paragraph.textContent = word;
       paragraph.style.display = 'none';

       newElement.appendChild(paragraph);
       newElement.addEventListener('click', (e) => {
           e.target.querySelector('p').style.display = 'block';
       });

       toAdd.appendChild(newElement);
   });
}

// function create(words) {
//    let parentElement = document.getElementById('content');
//    let elements = words;

//    for(let i = 0; i < elements.length; i++){
//       let div = document.createElement('div');
//       let p = document.createElement('p');

//       let text = document.createTextNode(elements[i]);

//       p.appendChild(text);
//       p.style.display = 'none';
//       div.appendChild(p);
//       div.addEventListener('click',showParagraphs);
//       parentElement.appendChild(div);
//    }
//    function showParagraphs(event){
//       event.target.childred[0].style.display = 'inline';
//    }
// }