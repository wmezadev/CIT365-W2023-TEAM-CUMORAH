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

        public IList<Quote> Quote { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Quote != null)
            {
                Quote = await _context.Quote.ToListAsync();
            }
        }
    }
}
