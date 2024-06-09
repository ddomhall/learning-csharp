import { useState } from 'react'
import TodoCard from './TodoCard'
import todoService from '../services/todoService'
import { FaTrash, FaPencil, FaXmark, FaCheck } from "react-icons/fa6";
import categoryService from '../services/categoryService';

export default function Category({ category, todos, refreshData, deleteCategory }) {
  const [edit, setEdit] = useState(false)
  const [expanded, setExpanded] = useState(false)

  function cancelEdit(e) {
    e.preventDefault()
    setEdit(false)
  }

  async function createTodo() {
    const name = window.prompt('name')
    await todoService.create({ name, categoryId: category.id })
    refreshData()
  }

  async function deleteTodo(id) {
    await todoService.remove(id)
    refreshData()
  }

  async function updateCategory(e) {
    e.preventDefault()
    await categoryService.update({ ...category, name: e.target.categoryName.value })
    refreshData()
    setEdit(false)
  }

  return (
    <>
      <section
        onMouseEnter={() => setExpanded(true)}
        onMouseLeave={() => setExpanded(false)}
        className={'ring ring-white rounded-3xl gap-8 flex flex-col overflow-x-clip overflow-y-auto' + (expanded ? ' w-96 p-8 ' : ' w-16')}
        style={{ transition: 'width 0.7s', scrollbarWidth: 'none' }}
      >
        {expanded ?
          <>
            {edit ?
              <form onSubmit={updateCategory} className="flex p-3 w-80 rounded-3xl justify-between">
                <input name='categoryName' defaultValue={category.name} autoFocus className='ring ring-white rounded-xl w-48 h-10' />
                <div className="flex gap-3">
                  <button onClick={cancelEdit} className="ring ring-white rounded-xl p-3"> <FaXmark /> </button>
                  <button type='submit' className="ring ring-white rounded-xl p-3"> <FaCheck /> </button>
                </div>
              </form>
              :
              <div className="flex p-3 w-80 rounded-3xl justify-between items-center" style={{ transition: 'width 1s' }}>
                <h2 className='text-center'>{category.name}</h2>
                <div className='flex gap-3'>
                  <button onClick={() => deleteCategory(category.id)} className="ring ring-white rounded-xl p-3 w-10 h-10"> <FaTrash /> </button>
                  <button onClick={() => setEdit(true)} className="ring ring-white rounded-xl p-3 w-10 h-10"> <FaPencil /> </button>
                  <button onClick={createTodo} className='ring ring-white rounded-xl w-10 h-10 text-3xl'>+</button>
                </div>
              </div>
            }
            <div className='flex flex-col gap-8'>
              {todos.map(todo => <TodoCard key={todo.id} todo={todo} refreshData={refreshData} deleteTodo={deleteTodo} />)}
            </div>
          </> :
          <div className='flex flex-col items-center justify-between pb-3 pt-6 gap-6 h-full'>
            <div className='[writing-mode:vertical-rl]'>{category.name}</div>
            <div className='flex flex-col items-center gap-3'>
              <div className='ring ring-white w-10 h-10 rounded-xl text-center leading-10'>{todos.length}</div>
              <div className='ring ring-white w-10 h-10 rounded-xl text-center leading-10'>x</div>
            </div>
          </div>
        }
      </section>
    </>
  )
}
