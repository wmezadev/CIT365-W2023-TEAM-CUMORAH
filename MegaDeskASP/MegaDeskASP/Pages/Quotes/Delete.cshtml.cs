using System;
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
    public class DeleteModel : PageModel
    {
        private readonly MegaDeskASP.Data.MegaDeskASPContext _context;

        public DeleteModel(MegaDeskASP.Data.MegaDeskASPContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Quote == null)
            {
                return NotFound();
            }
            var quote = await _context.Quote.FindAsync(id);

            if (quote != null)
            {
                Quote = quote;
                _context.Quote.Remove(Quote);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
