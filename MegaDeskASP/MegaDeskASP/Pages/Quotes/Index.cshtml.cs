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
    public class IndexModel : PageModel
    {
        private readonly MegaDeskASP.Data.MegaDeskASPContext _context;

        public IndexModel(MegaDeskASP.Data.MegaDeskASPContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public IList<Quote> Quotes { get;set; } = default!;

        public async Task OnGetAsync()
        {

           var quotes = from quote in _context.Quote select quote; 
            if (_context.Quote != null)
            {
                Quotes = await _context.Quote.ToListAsync();
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where( quote=> quote.CustomerName.Contains(SearchString) ); 
            }

            Quotes = await quotes.ToListAsync();    
        }
    }
}
