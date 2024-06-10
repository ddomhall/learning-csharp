namespace todo;

public class TodoItem
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool Done { get; set; } = false;
}

