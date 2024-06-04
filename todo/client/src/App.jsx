import { useState, useEffect } from 'react'
import todoService from './services/todoService'
import categoryService from './services/categoryService'
import Category from './components/Category'

function App() {
  const [todos, setTodos] = useState([])
  const [categories, setCategories] = useState([])

  useEffect(() => {
    todoService.getAll().then(res => setTodos(res))
    categoryService.getAll().then(res => setCategories(res))
  }, [])

  return (
    <>
      <h1 className='text-center border-b mb-6'>todo list</h1>
      <ul className='flex gap-6 m-6 justify-center items-center'>
        {
          categories.map(category => <Category key={category.id} name={category.name} todos={todos.filter(todo => todo.categoryId == category.id)} />)
        }
        <button className='ring ring-white h-16 w-16 text-3xl rounded-3xl'>+</button>
      </ul>
    </>
  )
}

export default App
