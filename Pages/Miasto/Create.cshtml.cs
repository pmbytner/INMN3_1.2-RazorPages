using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using INMN3_1._2_RazorPages.Data;
using INMN3_1._2_RazorPages.Models;

namespace INMN3_1._2_RazorPages.Pages.Miasto
{
    public class CreateModel : PageModel
    {
        private readonly NaszaBaza _context;

        public CreateModel(NaszaBaza context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Miasto Miasto { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Miasta.Add(Miasto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
