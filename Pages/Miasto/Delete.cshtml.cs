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
    public class DeleteModel : PageModel
    {
        private readonly INMN3_1._2_RazorPages.Data.NaszaBaza _context;

        public DeleteModel(INMN3_1._2_RazorPages.Data.NaszaBaza context)
        {
            _context = context;
        }

        [BindProperty]
      public Models.Miasto Miasto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Miasta == null)
            {
                return NotFound();
            }

            var miasto = await _context.Miasta.FirstOrDefaultAsync(m => m.Id == id);

            if (miasto == null)
            {
                return NotFound();
            }
            else 
            {
                Miasto = miasto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Miasta == null)
            {
                return NotFound();
            }
            var miasto = await _context.Miasta.FindAsync(id);

            if (miasto != null)
            {
                Miasto = miasto;
                _context.Miasta.Remove(Miasto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
