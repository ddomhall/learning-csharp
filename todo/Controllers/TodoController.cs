using Microsoft.AspNetCore.Mvc;
using todo.Services;

namespace todo.Controllers;

[ApiController]
[Route("Todos")]
public class TodoController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<TodoItem>> GetAll() =>
        TodoService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<TodoItem> Get(int id)
    {
        var foundTodo = TodoService.Get(id);

        if (foundTodo == null)
            return NotFound();

        return foundTodo;
    }

    [HttpPost]
    public IActionResult Post(TodoItem todo)
    {
        TodoService.Add(todo);
        return CreatedAtAction(nameof(Get), new { id = todo.Id }, todo);
    }
}

