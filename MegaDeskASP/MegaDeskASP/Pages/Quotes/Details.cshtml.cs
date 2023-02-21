﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskASP.Data;
using MegaDeskASP.Models;

namespace MegaDeskASP.Pages.Quotes
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskASP.Data.MegaDeskASPContext _context;

        public DetailsModel(MegaDeskASP.Data.MegaDeskASPContext context)
        {
            _context = context;
        }

      public Quote Quote { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Quote == null)
            {
                return NotFound();
            }

            var quote = await _context.Quote.FirstOrDefaultAsync(m => m.Id == id);
            if (quote == null)
            {
                return NotFound();
            }
            else 
            {
                Quote = quote;
            }
            return Page();
        }
    }
}
