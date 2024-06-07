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

        if (todo is null)
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
    public IActionResult Put(TodoItem todo)
    {
        var oldTodo = TodoService.Get(todo.Id);
        if (oldTodo is null)
        {
            return NotFound();
        }

        TodoService.Update(todo);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var todo = TodoService.Get(id);
        if (todo is null)
        {
            return NotFound();
        }

        TodoService.Delete(id);
        return NoContent();
    }
}

