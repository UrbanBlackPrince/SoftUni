function solve(array, step){
  let arrayToPrint = [];
  arrayToPrint.push(array[0]);

  for(let counter = 1; counter < array.length; counter++){
      if(counter %  step === 0){
          var element = array[counter];
          arrayToPrint.push(element);
      }
  }

  return arrayToPrint;
}

solve(['5', 
'20', 
'31', 
'4', 
'20'], 
2
);