namespace todo.Services;

public static class CategoryService
{
    static List<Category> Categories { get; }
    static int nextId = 3;
    static CategoryService()
    {
        Categories = new List<Category>
        {
            new Category { Id = 1, Name = "category1" },
            new Category { Id = 2, Name = "category2" }
        };
    }

    public static List<Category> GetAll() => Categories;

    public static Category? Get(int id) => Categories.FirstOrDefault(p => p.Id == id);

    public static void Add(Category category)
    {
        category.Id = nextId++;
        Categories.Add(category);
    }

    public static void Delete(int id)
    {
        var category = Get(id);
        if (category is null)
            return;

        Categories.Remove(category);
    }

    public static void Update(Category category)
    {
        var index = Categories.FindIndex(p => p.Id == category.Id);
        if (index == -1)
            return;

        Categories[index] = category;
    }
}

