using Microsoft.AspNetCore.Mvc;

namespace EffortCalculator.Controllers;

public class CategoryController : Controller
{
    // GET: CategoryController
    public ActionResult Index()
    {
        return View();
    }
}
