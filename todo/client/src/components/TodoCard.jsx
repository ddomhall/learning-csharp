import { FaPencil } from "react-icons/fa6";
import { FaXmark } from "react-icons/fa6";
import { FaCheck } from "react-icons/fa6";

export default function TodoCard({ todo }) {
  return (
    <div className="flex p-3 w-80 rounded-3xl ring ring-white justify-between">
      <h3 className="leading-10">{todo.name}</h3>
      <div className="flex gap-3">
        <button className="ring ring-white rounded-xl p-3">
          <FaPencil size={"12px"} />
        </button>
        <button className="ring ring-white rounded-xl p-3">
          <FaXmark />
        </button>
        <button className="ring ring-white rounded-xl p-3">
          <FaCheck />
        </button>
      </div>
    </div>
  )
}
