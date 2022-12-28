using AjaxExp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxExp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        List<Box> boxes = BoxStatic.Boxes;

        return View(boxes);
    }

    [HttpGet("api/Home/{boxName}")]
    public ActionResult<Box> GetDetails(string boxName)
    {
        Box? b =

            BoxStatic.Boxes
               .Where(b => b.BoxName == boxName)
               .FirstOrDefault();

        if (b is null)
        {
            return new Box();
        }
        else
        {
            return b;
        }
    }
}