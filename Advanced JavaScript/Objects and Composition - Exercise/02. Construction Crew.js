function solve(inputDictionary){
    if(inputDictionary.dizziness === true){
        inputDictionary.levelOfHydrated += inputDictionary.experience * inputDictionary.weight * 0.1;
        inputDictionary.dizziness = false;
    }

    return inputDictionary;
}

solve({ weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true }
  );