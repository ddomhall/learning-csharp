namespace todo.Services;

public static class TodoService
{
    static List<TodoItem> Todos { get; }
    static int nextId = 3;
    static TodoService()
    {
        Todos = new List<TodoItem>
        {
            new TodoItem { Id = 1, Name = "t1", CategoryId = 1},
            new TodoItem { Id = 2, Name = "t2", CategoryId = 2 }
        };
    }

    public static List<TodoItem> GetAll() => Todos;

    public static TodoItem? Get(int id) => Todos.FirstOrDefault(p => p.Id == id);

    public static void Add(TodoItem todo)
    {
        todo.Id = nextId++;
        Todos.Add(todo);
    }

    public static void Delete(int id)
    {
        var todo = Get(id);
        if (todo is null)
            return;

        Todos.Remove(todo);
    }

    public static void DeleteInCategory(int id)
    {
        Todos.RemoveAll(todo => todo.CategoryId == id);
    }

    public static void Update(TodoItem todo)
    {
        var index = Todos.FindIndex(p => p.Id == todo.Id);
        if (index == -1)
            return;

        Todos[index] = todo;
    }
}
