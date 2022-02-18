function solve(inputDictionary){
   let outputDictionary = {};
   let engine = {};
   let carrige = {};

   outputDictionary.model = inputDictionary.model;

   if(inputDictionary.power <= 90){
       engine.power = 90;
       engine.volume = 1800;
   }else if(inputDictionary.power <= 120){
    engine.power = 120;
    engine.volume = 2400;
   }else if(inputDictionary.power <= 200){
    engine.power = 200;
    engine.volume = 3500;
   }

   carrige.type = inputDictionary.carriage;
   carrige.color = inputDictionary.color;

   if(inputDictionary.wheelsize % 2 === 0){
       inputDictionary.wheelsize--;
   }

   outputDictionary.engine = engine;
   outputDictionary.carriage = carrige;
   outputDictionary.wheels = [inputDictionary.wheelsize,inputDictionary.wheelsize,inputDictionary.wheelsize,inputDictionary.wheelsize,]

   return outputDictionary;
   //console.log(outputDictionary);
}

solve({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 }
)