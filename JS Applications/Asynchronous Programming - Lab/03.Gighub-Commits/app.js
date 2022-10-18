function loadCommits() {
    let usernameElement = document.getElementById('username');
    let repoElement = document.getElementById('repo');
    let ulElement = document.getElementById('commits');

    let username = usernameElement.value;
    let repo = repoElement.value;
    let url = `https://api.github.com/repos/${username}/${repo}/commits`

    fetch(url)
        .then(res => {
            if (res.ok === false) {
                throw new Error(response.status);
            }

            return res.json();

        })
        .then(data => {
            Object.values(data).forEach(commitData => {
                let { comit } = commitData;

                let author = comit.author.name;
                let message = comit.message;
                let li = document.createElement('li');
                li.textContent = `${author}: ${message}`
                ulElement.appendChild(li);

            })
        })
        .catch(err => {
            let li = document.createElement('li');
            li.textContent = `Error: ${err.status} (${err.statusText})`;
            ulElement.appendChild(li);
        })
}