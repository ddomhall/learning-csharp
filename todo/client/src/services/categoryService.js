const baseUrl = 'http://localhost:5014/categories'

async function getAll() {
  return fetch(baseUrl).then(res => res.json())
}

async function create(category) {
  return fetch(baseUrl, {
    method: 'POST',
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(category)
  })
}

export default {
  getAll,
  create
}

