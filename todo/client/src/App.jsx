import { useState, useEffect } from 'react'
import todoService from './services/todoService'

function App() {
  const [todos, setTodos] = useState([])

  useEffect(() => {
    todoService.getAll().then(res => setTodos(res))
  })

  return (
    <>
      <ul>
        {todos && todos.map(todo => <li key={todo.id}>{todo.name}</li>)}
      </ul>
    </>
  )
}

export default App
