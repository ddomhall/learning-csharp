const baseUrl = 'http://localhost:5014/todos'

async function getAll() {
  return fetch(baseUrl).then(res => res.json())
}

export default {
  getAll
}
