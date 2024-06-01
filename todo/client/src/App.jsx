import { useState, useEffect } from 'react'

function App() {
  const [todos, setTodos] = useState([])

  useEffect(() => {
    fetch('http://localhost:5014/todos').then(res => res.json()).then(res => setTodos(res))
  })

  return (
    <>
      <ul>
        {todos.map(todo => <li key={todo.id}>{todo.name}</li>)}
      </ul>
    </>
  )
}

export default App
