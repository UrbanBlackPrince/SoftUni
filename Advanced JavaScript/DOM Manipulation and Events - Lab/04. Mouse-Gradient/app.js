function attachGradientEvents() {
    let gradienElement = document.getElementById('gradient');
    let resultElement = document.getElementById('result');

    const gradientMouseoverHandler = (e) => {
        let percent = Math.floor((e.offsetX / e.target.offsetWidth) * 100);
        resultElement.textContent = percent;
    }

    gradienElement.addEventListener('mousemove',gradientMouseoverHandler);
}