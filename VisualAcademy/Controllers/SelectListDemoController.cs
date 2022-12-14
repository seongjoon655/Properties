using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using VisualAcademy.Data;

namespace VisualAcademy.Controllers
{
    public class SelectListDemoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SelectListDemoController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            ViewData["PropertyId"] = new SelectList(_context.Properties.OrderBy(it => it.Name), "Id", "Name");
            ViewData["LocationId"] = new SelectList(_context.Locations.OrderBy(it => it.Name), "Id", "Name");
            ViewData["SublocationId"] = new SelectList(_context.Sublocations.OrderBy(it => it.SublocationName), "Id", "SublocationName");

            return View();
        }
    }
}
