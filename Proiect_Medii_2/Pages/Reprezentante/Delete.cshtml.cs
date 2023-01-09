using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Medii_2.Data;
using Proiect_Medii_2.Models;

namespace Proiect_Medii_2.Pages.Reprezentante
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect_Medii_2.Data.Proiect_Medii_2Context _context;

        public DeleteModel(Proiect_Medii_2.Data.Proiect_Medii_2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Reprezentanta Reprezentanta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Reprezentanta == null)
            {
                return NotFound();
            }

            var reprezentanta = await _context.Reprezentanta.FirstOrDefaultAsync(m => m.ID == id);

            if (reprezentanta == null)
            {
                return NotFound();
            }
            else 
            {
                Reprezentanta = reprezentanta;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Reprezentanta == null)
            {
                return NotFound();
            }
            var reprezentanta = await _context.Reprezentanta.FindAsync(id);

            if (reprezentanta != null)
            {
                Reprezentanta = reprezentanta;
                _context.Reprezentanta.Remove(Reprezentanta);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
