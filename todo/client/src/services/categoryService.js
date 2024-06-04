const baseUrl = 'http://localhost:5014/'

async function getAll() {
  return fetch(baseUrl + 'categories').then(res => res.json())
}

export default {
  getAll
}

