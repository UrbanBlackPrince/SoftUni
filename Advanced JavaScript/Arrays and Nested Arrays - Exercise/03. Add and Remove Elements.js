function solve(array){
    let finalArray = [];
    let number = 1;
    for(let counter = 0; counter < array.length; counter++){
        if(array[counter] === 'add'){
            finalArray.push(number);
        }else{
            finalArray.pop(number);
        }
        number++;
    }
    
    if(finalArray.length !== 0){
        console.log(finalArray.join('\r\n'));
    }else{
        console.log('Empty');
    }
}

solve(['add', 
'add', 
'add', 
'add']
);

solve(['add', 
'add', 
'remove', 
'add', 
'add']
);