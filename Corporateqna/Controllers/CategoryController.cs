using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corporateqna.ClientApp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CategoryController : Controller
    {
    private readonly ICategoryService Category;
    public CategoryController(ICategoryService category)
    {
      this.Category = category;
    }
    [HttpGet]
    public IEnumerable<Category> GetCategories()
    {
      return Category.GetCategories();

    }
  }
}
