import { useState } from 'react'
import { FaPencil } from "react-icons/fa6";
import { FaXmark } from "react-icons/fa6";
import { FaCheck } from "react-icons/fa6";
import { FaTrash } from "react-icons/fa6";

export default function TodoCard({ todo, deleteTodo }) {
  const [edit, setEdit] = useState(false)

  function cancelEdit(e) {
    e.preventDefault()
    setEdit(false)
  }

  function updateTodo(e) {
    e.preventDefault()
    console.log(e)
    setEdit(false)
  }

  return (
    <>
      {edit ?
        <form onSubmit={updateTodo} className="flex p-3 w-80 rounded-3xl ring ring-white justify-between">
          <input defaultValue={todo.name} className='ring ring-white rounded-xl w-48 h-10' />
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
            <button className="ring ring-white rounded-xl p-3"> <FaCheck /> </button>
          </div>
        </div>
      }
    </>
  )
}
