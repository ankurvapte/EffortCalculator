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

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Category category)
    {
        if (category.Name != null &&
            (category.Name.ToLower() == "admin" ||
             category.Name.ToLower().StartsWith("test")))
        {
            ModelState.AddModelError("Name", "Please do not start any of the categories with the name test. And yes, admin is reserved too.");
        }

        if (ModelState.IsValid)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
    }

    public ActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        var category = _db.Categories.Where(t => t.Id == id).FirstOrDefault();
        return View(category);
    }

    [HttpPost]
    public ActionResult Edit(Category category)
    {
        if (category.Name != null &&
            (category.Name.ToLower() == "admin" ||
             category.Name.ToLower().StartsWith("test")))
        {
            ModelState.AddModelError("Name", "Please do not start any of the categories with the name test. And yes, admin is reserved too.");
        }

        if (ModelState.IsValid)
        {
            _db.Categories.Update(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
    }
}
