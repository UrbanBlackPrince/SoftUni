function attachEventsListeners() {

    let dayElement = document.getElementById('days');
    let dayButtonElement = document.getElementById('daysBtn');

    dayButtonElement = addEventListener('click',function(){
      let dayNumber = Number(dayElement.textContent);
       dayElement.textContent = dayElement / 24;
    });
}