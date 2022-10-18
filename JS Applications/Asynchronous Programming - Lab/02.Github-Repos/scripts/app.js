function loadRepos() {
	let usernameElement = document.getElementById('username');
	let reposElement = document.getElementById('repos');
	let username = usernameElement.value;

	fetch(`https://api.github.com/users/${username}/repos`)
		.then(res => res.json())
		.then(data => {
			reposElement.innerHTML = '';
			Object.values(data).forEach(repo => {
				let { full_name, html_url } = repo;

				let liElement = document.createElement('li');
				let aElement = document.createElement('a');
				aElement.textContent = full_name;
				aElement.href = html_url;
				liElement.appendChild(aElement);
				reposElement.appendChild(liElement);

			})
		})
		.catch(err => console.log(`${err.status} (Username ${username} not found)`));

}