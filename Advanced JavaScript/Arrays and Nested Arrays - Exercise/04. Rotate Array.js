function solve(array,times){
   for(let counter = 0; counter < times; counter++){
       let lastNum = array[array.length - 1];
      
           array.pop(lastNum);
           array.unshift(lastNum);
       
   }
   console.log(array.join(' '));
}

solve(['1', 
'2', 
'3', 
'4'], 
2
)

solve(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15)