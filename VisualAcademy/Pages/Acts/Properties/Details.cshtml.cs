﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VisualAcademy.Data;
using VisualAcademy.Models;

namespace VisualAcademy.Pages.Acts.Properties
{
    public class DetailsModel : PageModel
    {
        private readonly VisualAcademy.Data.ApplicationDbContext _context;

        public DetailsModel(VisualAcademy.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Property Property { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Properties == null)
            {
                return NotFound();
            }

            var property = await _context.Properties.FirstOrDefaultAsync(m => m.Id == id);
            if (property == null)
            {
                return NotFound();
            }
            else 
            {
                Property = property;
            }
            return Page();
        }
    }
}
