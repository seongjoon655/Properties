using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VisualAcademy.Data;
using VisualAcademy.Models;

namespace VisualAcademy.Pages.Acts.Sublocations
{
    public class DeleteModel : PageModel
    {
        private readonly VisualAcademy.Data.ApplicationDbContext _context;

        public DeleteModel(VisualAcademy.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Sublocation Sublocation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Sublocations == null)
            {
                return NotFound();
            }

            var sublocation = await _context.Sublocations.FirstOrDefaultAsync(m => m.Id == id);

            if (sublocation == null)
            {
                return NotFound();
            }
            else 
            {
                Sublocation = sublocation;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Sublocations == null)
            {
                return NotFound();
            }
            var sublocation = await _context.Sublocations.FindAsync(id);

            if (sublocation != null)
            {
                Sublocation = sublocation;
                _context.Sublocations.Remove(Sublocation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
