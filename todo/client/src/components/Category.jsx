import TodoCard from './TodoCard'

export default function Category({ name, todos }) {
  return (
    <>
      <section className='ring ring-white p-6 rounded-3xl gap-6 flex flex-col w-96'>
        <h2 className='text-center border-b'>{name}</h2>
        <div className='flex flex-col m-auto gap-6'>
          {todos.map(todo => <TodoCard key={todo.id} todo={todo} />)}
        </div>
        <button className='ring ring-white h-16 text-3xl rounded-3xl'>+</button>
      </section>
    </>
  )
}
