using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Medii_2.Data;
using Proiect_Medii_2.Models;
using Proiect_Medii_2.Models.VizualizareModele;

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

        public ReprezentataDateIndex ReprezentantaData { get; set; }
        public int ReprezentantaID { get; set; }
        public int MasinaID { get; set; }
        public async Task OnGetAsync(int? id, int? masinaID)
        {
            ReprezentantaData = new ReprezentataDateIndex();
            ReprezentantaData.Reprezentante = await _context.Reprezentanta
            .Include(i => i.Masini)
            .ThenInclude(c => c.AgentInchirieri)
            .OrderBy(i => i.NumeReprezentanta)
            .ToListAsync();
            if (id != null)
            {
                ReprezentantaID = id.Value;
                Reprezentanta reprezentanta = ReprezentantaData.Reprezentante
                .Where(i => i.ID == id.Value).Single();
                ReprezentantaData.Masini = reprezentanta.Masini;
            }


        }
    }
}