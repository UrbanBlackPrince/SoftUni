function getInfo() {
    const inputField = document.getElementById('stopId');
    const stopNameElement = document.getElementById('stopName');
    const ulElement = document.getElementById('buses');
    const busId = inputField.value;
    ulElement.replaceChildren();

    let url = `http://localhost:3030/jsonstore/bus/businfo/${busId}`

    fetch(url)
        .then(function validateResponse(response) {
            if (response.status !== 200) {
                throw new Error();
            }
            else {
                return response.json();
            }
        })
        .then(function visualizeData(data) {
            stopNameElement.textContent = data.name;
            Object.keys(data.buses)
                .forEach(x => {
                    const liElement = document.createElement('li');
                    liElement.textContent = `Bus ${x} arrives in ${data.buses[x]} minutes`;

                    ulElement.appendChild(liElement);
                });

            inputField.value = '';
        })
        .catch(err => stopNameElement.textContent = `Error`);
}
