const baseUrl = 'http://localhost:5014/todos'

async function getAll() {
  return fetch(baseUrl).then(res => res.json())
}

async function create(todo) {
  return fetch(baseUrl, {
    method: 'POST',
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(todo)
  })
}

async function remove(id) {
  return fetch(baseUrl + '/' + id, {
    method: 'DELETE',
  })
}

export default {
  getAll,
  create,
  remove
}
