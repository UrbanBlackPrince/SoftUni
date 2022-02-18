function solve() {
  let input = document.getElementById("text").value;
  let currentCase = document.getElementById("naming-convention").value;

  let final = '';
  
  if(currentCase === 'Camel Case'){
    final = input.toLowerCase().replace(/[^a-zA-Z0-9]+(.)/g, function(match, chr)
  {
    return chr.toUpperCase();
  });
  }else if(currentCase === 'Pascal Case'){
    final =   (" " + input).toLowerCase().replace(/[^a-zA-Z0-9]+(.)/g, function(match, chr)
    {
        return chr.toUpperCase();
    });
   
   }else{
     final += 'Error!';
   }
   
  let result = document.getElementById('result');
  result.textContent = final;
}