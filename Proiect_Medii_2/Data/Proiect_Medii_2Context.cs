using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Medii_2.Models;

namespace Proiect_Medii_2.Data
{
    public class Proiect_Medii_2Context : DbContext
    {
        public Proiect_Medii_2Context (DbContextOptions<Proiect_Medii_2Context> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Medii_2.Models.Masina> Masina { get; set; } = default!;

        public DbSet<Proiect_Medii_2.Models.Reprezentanta> Reprezentanta { get; set; }

        public DbSet<Proiect_Medii_2.Models.AgentInchirieri> AgentInchirieri { get; set; }
    }
}
