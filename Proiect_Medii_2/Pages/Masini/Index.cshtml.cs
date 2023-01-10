using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Medii_2.Data;
using Proiect_Medii_2.Models;

namespace Proiect_Medii_2.Pages.Masini
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Medii_2.Data.Proiect_Medii_2Context _context;

        public IndexModel(Proiect_Medii_2.Data.Proiect_Medii_2Context context)
        {
            _context = context;
        }

        public IList<Masina> Masina { get; set; } = default!;
        public DateMasina MasinaD { get; set; }
        public int MasinaID { get; set; }
        public int CategorieID { get; set; }

        public async Task OnGetAsync(int? id, int? categorieID)
        {
            MasinaD = new DateMasina();

            MasinaD.Masini = await _context.Masina
            .Include(b => b.Reprezentanta)
            .Include(b => b.AgentInchirieri)
            .Include(b => b.CategoriiMasina)
            .ThenInclude(b => b.Categorie)
            .AsNoTracking()
            .OrderBy(b => b.Model)
            .ToListAsync();
            if (id != null)
            {
                MasinaID = id.Value;
                Masina masina = MasinaD.Masini
                .Where(i => i.ID == id.Value).Single();
                MasinaD.Categorii = masina.CategoriiMasina.Select(s => s.Categorie);
            }
        }

    }
}