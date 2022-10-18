function loadRepos() {
   let url = "https://api.github.com/users/testnakov/repos";
   let divElement = document.getElementById('res');
  
   let httpRequest = new XMLHttpRequest();
   httpRequest.addEventListener('readystatechange', () => {
      if (httpRequest.readyState === 4) {
         divElement.textContent = httpRequest.responseText;
      }
   });

   httpRequest.open("Get", url);
   httpRequest.send();

}