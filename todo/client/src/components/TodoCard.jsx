import todoService from '../services/todoService';
import { useState } from 'react'
import { FaPencil, FaXmark, FaCheck, FaTrash, FaCheckToSlot } from "react-icons/fa6";

export default function TodoCard({ todo, refreshData, deleteTodo }) {
  const [edit, setEdit] = useState(false)

  function cancelEdit(e) {
    e.preventDefault()
    setEdit(false)
  }

  async function updateTodo(e) {
    e.preventDefault()
    await todoService.update({ ...todo, name: e.target.todoName.value })
    refreshData()
    setEdit(false)
  }

  async function toggleDone() {
    await todoService.update({ ...todo, done: !todo.done })
    refreshData()
  }

  return (
    <>
      {edit ?
        <form onSubmit={updateTodo} className="flex p-3 w-80 rounded-3xl ring ring-white justify-between">
          <input name='todoName' defaultValue={todo.name} autoFocus className='ring ring-white rounded-xl w-48 h-10' />
          <div className="flex gap-3">
            <button onClick={cancelEdit} className="ring ring-white rounded-xl p-3"> <FaXmark /> </button>
            <button type='submit' className="ring ring-white rounded-xl p-3"> <FaCheck /> </button>
          </div>
        </form>
        :
        <div className="flex p-3 w-80 rounded-3xl ring ring-white justify-between">
          <h3 className="leading-10">{todo.name}</h3>
          <div className="flex gap-3">
            <button onClick={() => deleteTodo(todo.id)} className="ring ring-white rounded-xl p-3"> <FaTrash /> </button>
            <button onClick={() => setEdit(true)} className="ring ring-white rounded-xl p-3"> <FaPencil /> </button>
            <button onClick={toggleDone} className="ring ring-white rounded-xl p-3">{todo.done ? <FaCheckToSlot /> : <FaCheck />}</button>
          </div>
        </div>
      }
    </>
  )
}
