export default function TodoCard({ todo }) {
  return (
    <section className="flex flex-col w-48 p-6 gap-6 rounded-xl ring ring-white">
      <h3 className="text-center border-b">{todo.name}</h3>
      <button className="ring ring-white rounded">edit</button>
      <button className="ring ring-white rounded">delete</button>
    </section>
  )
}
