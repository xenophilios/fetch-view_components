using AjaxExp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxExp;

public class DetailsViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(Box? dto)
    {
        if (dto is null)
        {
            return View();
        }
        else
        {
            return View(dto);
        }
    }
}