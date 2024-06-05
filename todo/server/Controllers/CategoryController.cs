using Microsoft.AspNetCore.Mvc;
using todo.Services;

namespace todo.Controllers;

[ApiController]
[Route("Categories")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Category>> GetAll() =>
        CategoryService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Category> Get(int id)
    {
        var category = CategoryService.Get(id);

        if (category is null)
            return NotFound();

        return category;
    }

    [HttpPost]
    public IActionResult Post(Category category)
    {
        CategoryService.Add(category);
        return CreatedAtAction(nameof(Get), new { id = category.Id }, category);
    }

    [HttpPut]
    public IActionResult Put(int id, Category category)
    {
        if (id != category.Id)
        {
            return BadRequest();
        }

        var oldCategory = CategoryService.Get(id);
        if (oldCategory is null)
        {
            return NotFound();
        }

        CategoryService.Update(category);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var category = CategoryService.Get(id);
        if (category is null)
        {
            return NotFound();
        }

        TodoService.DeleteInCategory(id);
        CategoryService.Delete(id);
        return NoContent();
    }
}


