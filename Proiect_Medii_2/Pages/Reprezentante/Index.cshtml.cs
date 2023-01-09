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
    public class IndexModel : PageModel
    {
        private readonly Proiect_Medii_2.Data.Proiect_Medii_2Context _context;

        public IndexModel(Proiect_Medii_2.Data.Proiect_Medii_2Context context)
        {
            _context = context;
        }

        public IList<Reprezentanta> Reprezentanta { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Reprezentanta != null)
            {
                Reprezentanta = await _context.Reprezentanta.ToListAsync();
            }
        }
    }
}
