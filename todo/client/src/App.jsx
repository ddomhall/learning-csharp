import { useState, useEffect } from 'react'
import todoService from './services/todoService'
import Category from './components/Category'

function App() {
  const [todos, setTodos] = useState([])

  useEffect(() => {
    todoService.getAll().then(res => setTodos(Object.groupBy(res, ({ category }) => category)))
  })

  return (
    <>
      <h1 className='text-center border-b mb-6'>todo list</h1>
      <ul className='flex w-48 gap-6 m-6'>
        {todos && Object.entries(todos).map(([name, todos], i) => <Category key={i} {...{ name, todos }} />)}
      </ul>
    </>
  )
}

export default App
