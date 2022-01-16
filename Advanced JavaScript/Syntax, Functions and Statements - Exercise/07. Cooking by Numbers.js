function solve(num, operation1,operation2,operation3,operation4,operation5){
   let number = Number(num);
   let commands = [operation1,operation2,operation3,operation4,operation5];

   for(let counter = 0; counter < commands.length; counter++){
       if(commands[counter] === 'chop'){
           number = number / 2;
       }else if(commands[counter] === 'dice'){
           number = Math.sqrt(number);
       }else if(commands[counter] === 'spice'){
           number++;
       }else if(commands[counter] === 'bake'){
           number *= 3;
       }else if(commands[counter] === 'fillet'){
           Math.round(number *= 0.80);

       }

       console.log(number);
   }
}

//solve('32', 'chop', 'chop', 'chop', 'chop', 'chop');
solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet');