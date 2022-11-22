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
    public class IndexModel : PageModel
    {
        private readonly VisualAcademy.Data.ApplicationDbContext _context;

        public IndexModel(VisualAcademy.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Property> Property { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Properties != null)
            {
                Property = await _context.Properties.ToListAsync();
            }
        }
    }
}
