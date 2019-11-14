var appNode = document.createElement('div');
document.body.appendChild(appNode);

axios.post('https://localhost:5001/api/Sample/list', ["123", "456"])
    .then(res => appNode.innerText = res.data)
    .catch(err => appNode.innerText = err);
