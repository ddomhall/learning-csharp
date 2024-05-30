using Microsoft.AspNetCore.Mvc;

namespace todo.Controllers;

[ApiController]
[Route("Todos")]
public class TodoController : ControllerBase
{
    List<Todo> todos = [];

    [HttpGet(Name = "GetTodo")]
    public IEnumerable<Todo> Get()
    {
        return todos;
    }
}

