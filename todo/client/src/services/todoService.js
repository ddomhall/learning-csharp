const baseUrl = 'http://localhost:5014/'

async function getAll() {
  return fetch(baseUrl + 'todos').then(res => res.json())
}

export default {
  getAll
}
