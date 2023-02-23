using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDeskASP.Data;
using MegaDeskASP.Models;

namespace MegaDeskASP.Pages.Quotes
{
    public class EditModel : PageModel
    {
        private readonly MegaDeskASP.Data.MegaDeskASPContext _context;

        public EditModel(MegaDeskASP.Data.MegaDeskASPContext context)
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
            Quote = quote;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Quote.Price = DeskQuote.CalculateTotalPrice(Quote.Width, Quote.Height, Quote.Drawer, Quote.ProductionTime, Quote.SurfaceMaterial);
            Quote.DateCreated = DateTime.Now;
            _context.Quote.Add(Quote);

            _context.Attach(Quote).State = EntityState.Modified;

            try
            {

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuoteExists(Quote.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }


            return RedirectToPage("./Index");
        }

        private bool QuoteExists(int id)
        {
            return (_context.Quote?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
