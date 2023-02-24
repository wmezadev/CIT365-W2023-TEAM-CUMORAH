using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskASP.Data;
using MegaDeskASP.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Policy;

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

        public SelectList SortOptions { get; set; } = new SelectList(
            new List<string>
            {
                "date asc",
                "date des"
            }
            .ToList()
        );

        [BindProperty(SupportsGet = true)]
        public string optionSelected { get; set; }

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

            switch (optionSelected)
            {
                case "date des":
                    quotes = quotes.OrderByDescending(s => s.DateCreated);
                    break;

                case "date asc":
                    quotes = quotes.OrderBy(s => s.DateCreated);
                    break;
                default:

                    break;
            }

            Quotes = await quotes.ToListAsync();    
        }
    }
}
