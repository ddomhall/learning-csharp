import TodoCard from './TodoCard'
import todoService from '../services/todoService'
import { FaTrash } from "react-icons/fa6";
import { FaPencil } from "react-icons/fa6";

export default function Category({ category, todos, getTodos, deleteCategory }) {
  async function createTodo() {
    const name = window.prompt('name')
    await todoService.create({ name, categoryId: category.id })
    getTodos()
  }

  async function deleteTodo(id) {
    await todoService.remove(id)
    getTodos()
  }

  return (
    <>
      <section className='ring ring-white p-8 rounded-3xl gap-8 flex flex-col w-96'>
        <div className="flex p-3 w-80 rounded-3xl justify-between items-center">
          <h2 className='text-center'>{category.name}</h2>
          <div className='flex gap-3'>
            <button onClick={() => deleteCategory(category.id)} className="ring ring-white rounded-xl p-3 w-10 h-10"> <FaTrash /> </button>
            <button className="ring ring-white rounded-xl p-3 w-10 h-10"> <FaPencil /> </button>
            <button onClick={createTodo} className='ring ring-white rounded-xl w-10 h-10 text-3xl'>+</button>
          </div>
        </div>
        <div className='flex flex-col gap-8'>
          {todos.map(todo => <TodoCard key={todo.id} todo={todo} deleteTodo={deleteTodo} />)}
        </div>
      </section>
    </>
  )
}
