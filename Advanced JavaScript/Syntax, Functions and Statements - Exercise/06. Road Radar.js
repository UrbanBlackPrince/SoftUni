function roadRadar(speed, area){
    let speedLimits = {
        'motorway': 130,
        'interstate': 90,
        'city': 50,
        'residential': 20
    };

    let speedLimit = speedLimits[area];
    let result;

    if (speed <= speedLimit) {
        result = `Driving ${speed} km/h in a ${speedLimit} zone`;

    }else{
        let difference = speed - speedLimit;
        let drivingStatus = '';

        switch (true) {
            case difference <= 20: drivingStatus = 'speeding'; break;
            case difference <= 40: drivingStatus = 'excessive speeding'; break;        
            default: drivingStatus = 'reckless driving'; break;
        }

        result = `The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - ${drivingStatus}`;
    }   
    
    console.log(result);
}

roadRadar(40, 'city');
roadRadar(21, 'residential');
roadRadar(120, 'interstate');
roadRadar(200, 'motorway');

// function solve(speed, pleaceType){
//     let motorlayLimit = 130;
//     let interstateLimit = 90;
//     let cityLimit = 50;
//     let residentialLimit = 20;

//     if(speed <= motorlayLimit && pleaceType === 'motorway'){
//        console.log(`Driving ${speed}km/h in a 130 zone`);
//        break;
//     }else if(speed <= interstateLimit && pleaceType === 'interstate'){
//         console.log(`Driving ${speed}km/h in a 90 zone`);
//         break;
//     }else if(speed <= cityLimit && pleaceType === 'city'){
//         console.log(`Driving ${speed}km/h in a 50 zone`);
//         break;
//     }else if(speed <= residentialLimit && pleaceType === 'residential'){
//         console.log(`Driving ${speed}km/h in a 20 zone`);
//         break
//     }

//     let speedOver = 0;
//     let status = '';
//     if(speed > motorlayLimit && pleaceType === 'motorway'){
//         speedOver = speed - motorlayLimit;
//         if(speedOver === 20){
//             status = 'speeding';
//         }else if(speedOver === 40){
//             status = 'excessive speeding';
//         }else{
//             status = 'reckless driving';
//         }
//         console.log(`The speed is ${speedOver} km/h faster than the allowed speed of 130 - ${status} speeding`);
//     }else if(speed > interstateLimit && pleaceType === 'interstate'){
//         speedOver = speed - interstateLimit;
//         if(speedOver === 20){
//             status = 'speeding';
//         }else if(speedOver === 40){
//             status = 'excessive speeding';
//         }else{
//             status = 'reckless driving';
//         }
//         console.log(`The speed is ${speedOver} km/h faster than the allowed speed of 90 - ${status} speeding`);
//     }else if(speed > cityLimit && pleaceType === 'city'){
//         speedOver = speed - interstateLimit;
//         if(speedOver === 20){
//             status = 'speeding';
//         }else if(speedOver === 40){
//             status = 'excessive speeding';
//         }else{
//             status = 'reckless driving';
//         }
//         console.log(`The speed is ${speedOver} km/h faster than the allowed speed of 50 - ${status} speeding`);

//     }else if(speed > residentialLimit && pleaceType === 'residential'){
//         speedOver = speed - interstateLimit;
//         if(speedOver === 20){
//             status = 'speeding';
//         }else if(speedOver === 40){
//             status = 'excessive speeding';
//         }else{
//             status = 'reckless driving';
//         }
//         console.log(`The speed is ${speedOver} km/h faster than the allowed speed of 20 - ${status} speeding`);  
//     }  
// }

// solve(40, 'motorway');
// solve(21, 'residential');