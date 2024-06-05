import TodoCard from './TodoCard'
import todoService from '../services/todoService'
import { FaXmark } from "react-icons/fa6";

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
        <div className='flex justify-between items-center'>
          <button onClick={createTodo} className='ring ring-white h-16 w-16 text-3xl rounded-3xl'>+</button>
          <h2 className='text-center'>{category.name}</h2>
          <button onClick={() => deleteCategory(category.id)} className="ring ring-white rounded-3xl h-16 w-16 flex items-center justify-center"> <FaXmark /> </button>
        </div>
        <div className='flex flex-col m-auto gap-8'>
          {todos.map(todo => <TodoCard key={todo.id} todo={todo} deleteTodo={deleteTodo} />)}
        </div>
      </section>
    </>
  )
}
