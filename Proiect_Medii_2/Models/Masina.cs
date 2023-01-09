using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Xml.Linq;

namespace Proiect_Medii_2.Models
{
    public class Masina
    {
        public int ID { get; set; }

        [Display(Name = "Modelul Masinii")]
        public string Model { get; set; }
        public int? AgentInchirieriID { get; set; }
        public AgentInchirieri? AgentInchirieri { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }

        [DataType(DataType.Date)]
        public DateTime AnulFabricarii { get; set; }

        public int? ReprezentantaID { get; set; }
        public Reprezentanta? Reprezentanta { get; set; }

        public ICollection<CategorieMasina>? CategoriiMasina { get; set; }
    }
}
