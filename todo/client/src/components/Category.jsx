import TodoCard from './TodoCard'
import todoService from '../services/todoService'

export default function Category({ category, todos, getTodos }) {
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
      <section className='ring ring-white p-6 rounded-3xl gap-6 flex flex-col w-96'>
        <h2 className='text-center border-b'>{category.name}</h2>
        <div className='flex flex-col m-auto gap-6'>
          {todos.map(todo => <TodoCard key={todo.id} todo={todo} deleteTodo={deleteTodo} />)}
        </div>
        <button onClick={createTodo} className='ring ring-white h-16 text-3xl rounded-3xl'>+</button>
      </section>
    </>
  )
}
