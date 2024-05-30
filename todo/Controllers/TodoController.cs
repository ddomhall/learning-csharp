using Microsoft.AspNetCore.Mvc;

namespace todo.Controllers;

[ApiController]
[Route("Todos")]
public class TodoController : ControllerBase
{
    List<Todo> todos = [];

    [HttpGet]
    public IEnumerable<Todo> Get()
    {
        return todos;
    }

    [HttpPost]
    public IActionResult Post(Todo newTodo)
    {
        todos.Add(newTodo);
        return CreatedAtAction(nameof(Get), newTodo);
    }
}

