using Microsoft.AspNetCore.Mvc;
using todo.Services;

namespace todo.Controllers;

[ApiController]
[Route("Todos")]
public class TodoController : ControllerBase
{
    [HttpGet]
    public IEnumerable<TodoItem> Get()
    {
        return TodoService.GetAll();
    }

    [HttpPost]
    public IActionResult Post(TodoItem newTodo)
    {
        TodoService.Add(newTodo);
        return CreatedAtAction(nameof(Get), newTodo);
    }
}

