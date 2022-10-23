using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using INMN3_1._2_RazorPages.Data;
using INMN3_1._2_RazorPages.Models;

namespace INMN3_1._2_RazorPages.Pages.Miasto
{
    public class IndexModel : PageModel
    {
        private readonly INMN3_1._2_RazorPages.Data.NaszaBaza _context;

        public IndexModel(INMN3_1._2_RazorPages.Data.NaszaBaza context)
        {
            _context = context;
        }

        public IList<Models.Miasto> Miasta { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Miasta != null)
            {
                Miasta = await _context.Miasta.ToListAsync();
            }
        }
    }
}
