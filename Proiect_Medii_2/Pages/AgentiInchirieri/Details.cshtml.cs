﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Medii_2.Data;
using Proiect_Medii_2.Models;

namespace Proiect_Medii_2.Pages.AgentiInchirieri
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Medii_2.Data.Proiect_Medii_2Context _context;

        public DetailsModel(Proiect_Medii_2.Data.Proiect_Medii_2Context context)
        {
            _context = context;
        }

      public AgentInchirieri AgentInchirieri { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AgentInchirieri == null)
            {
                return NotFound();
            }

            var agentinchirieri = await _context.AgentInchirieri.FirstOrDefaultAsync(m => m.ID == id);
            if (agentinchirieri == null)
            {
                return NotFound();
            }
            else 
            {
                AgentInchirieri = agentinchirieri;
            }
            return Page();
        }
    }
}
