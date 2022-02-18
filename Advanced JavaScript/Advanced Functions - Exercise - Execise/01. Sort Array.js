function solve (array, command){
  if(command === 'asc'){
    return array.sort((a,b) => a - b);
  }else if(command === 'desc'){
      return array.sort((a,b) => b - a);
  }
}

solve([14, 7, 17, 6, 8], 'asc');
solve([14, 7, 17, 6, 8], 'desc');