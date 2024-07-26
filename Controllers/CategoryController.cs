using Microsoft.AspNetCore.Mvc;

namespace EffortCalculator.Controllers;

public class CategoryController : Controller
{
    readonly ApplicationDbContext _db;
    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }
    // GET: CategoryController
    public ActionResult Index()
    {
        List<Category> categories = _db.Categories.ToList();
        return View(categories);
    }
}
