﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Proiect_Medii_2.Models
{
    public class AgentInchirieri
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return Nume + " " + Prenume;
            }
        }
        public ICollection<Masina>? Masini { get; set; }
    }
}
