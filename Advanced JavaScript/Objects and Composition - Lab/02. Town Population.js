function solve(arr){
    const dictionary = {};

   for(const townata of arr){

    let newArray = townata.split(' <-> ');
    let city = newArray[0];
    let population = Number(newArray[1]);

    if(dictionary.hasOwnProperty(city)){
    population += dictionary[city];
    }
      dictionary[city] = population;
   }

   for(const town in dictionary){
    console.log(`${town} : ${dictionary[town]}`);
}
}

solve(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']
);