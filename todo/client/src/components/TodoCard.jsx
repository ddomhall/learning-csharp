export default function TodoCard({ todo }) {
  return (
    <section className="flex flex-col w-48 p-6 gap-6 rounded-3xl ring ring-white">
      <h3 className="text-center border-b">{todo.name}</h3>
      <button className="ring ring-white rounded-xl">edit</button>
      <button className="ring ring-white rounded-xl">delete</button>
    </section>
  )
}
