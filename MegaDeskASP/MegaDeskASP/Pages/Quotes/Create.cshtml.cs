using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskASP.Data;
using MegaDeskASP.Models;

namespace MegaDeskASP.Pages.Quotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskASP.Data.MegaDeskASPContext _context;

        public CreateModel(MegaDeskASP.Data.MegaDeskASPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Quote Quote { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Quote == null || Quote == null)
            {
                return Page();
            }

            Quote.Price = DeskQuote.CalculateTotalPrice(Quote.Width, Quote.Height, Quote.Drawer, Quote.ProductionTime, Quote.SurfaceMaterial);
            Quote.DateCreated = DateTime.Now;
            _context.Quote.Add(Quote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
