import { useState, useEffect } from 'react'
import todoService from './services/todoService'
import categoryService from './services/categoryService'
import Category from './components/Category'

function App() {
  const [todos, setTodos] = useState([])
  const [categories, setCategories] = useState([])

  useEffect(() => {
    getCategories()
    getTodos()
  }, [])

  function getCategories() {
    categoryService.getAll().then(res => setCategories(res))
  }

  function getTodos() {
    todoService.getAll().then(res => setTodos(res))
  }

  async function createCategory() {
    const name = window.prompt('name')
    await categoryService.create({ name })
    getCategories()
  }

  async function deleteCategory(id) {
    if (window.confirm('are you sure?')) {
      await categoryService.remove(id)
      getCategories()
      getTodos()
    }
  }

  return (
    <div className='h-screen'>
      <h1 className='text-center'>todo list</h1>
      <ul className='flex gap-8 p-8 justify-center min-h-[calc(100vh-24px)]'>
        {
          categories.map(category => <Category
            key={category.id}
            category={category}
            todos={todos.filter(todo => todo.categoryId == category.id)}
            getTodos={getTodos}
            deleteCategory={deleteCategory} />)
        }
        <div className='flex items-center'>
          <button onClick={createCategory} className='ring ring-white h-16 w-16 text-3xl rounded-3xl'>+</button>
        </div>
      </ul>
    </div>
  )
}

export default App
