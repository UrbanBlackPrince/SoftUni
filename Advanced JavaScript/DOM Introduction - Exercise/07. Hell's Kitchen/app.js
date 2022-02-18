function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick () {
      let textInput = document.querySelector('#inputs textarea').value;
      let newArray = Array.from(textInput);
      console.log(newArray);
      
   }
}