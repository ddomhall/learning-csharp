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
        var todo = TodoService.Get(id);

        if (todo == null)
            return NotFound();

        return todo;
    }

    [HttpPost]
    public IActionResult Post(TodoItem todo)
    {
        TodoService.Add(todo);
        return CreatedAtAction(nameof(Get), new { id = todo.Id }, todo);
    }

    [HttpPut]
    public IActionResult Put(int id, TodoItem todo)
    {
        if (id != todo.Id)
        {
            return BadRequest();
        }

        var oldTodo = TodoService.Get(id);
        if (oldTodo == null)
        {
            return NotFound();
        }

        TodoService.Update(todo);
        return NoContent();
    }
}

