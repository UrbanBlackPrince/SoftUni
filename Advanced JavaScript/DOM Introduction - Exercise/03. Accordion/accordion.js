function toggle() {

let showMoreElement = document.querySelector('.button');

  if(showMoreElement.textContent === 'More'){
        showMoreElement.textContent = 'Less';
  }else{
       showMoreElement.textContent = 'More';
  }

  let text = document.querySelector('#extra');

  if(text.style.display === 'none'){
    text.style.display = 'block';
  }else{
    text.style.display = 'none';
  }
}