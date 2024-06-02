import { useState, useEffect } from 'react'
import todoService from './services/todoService'
import TodoCard from './components/TodoCard'

function App() {
  const [todos, setTodos] = useState([])

  useEffect(() => {
    todoService.getAll().then(res => setTodos(res))
  })

  return (
    <>
      <h1 className='text-center border-b mb-6'>todo list</h1>
      <ul className='flex flex-col m-auto w-48 gap-6'>
        {todos && todos.map(todo => <TodoCard key={todo.id} todo={todo} />)}
      </ul>
    </>
  )
}

export default App
