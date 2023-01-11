using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Proiect_Medii_2.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string? Nume { get; set; }
        public string? Prenume { get; set; }
        public string? Adresa { get; set; }
        public string Email { get; set; }
        public string? NumarDeTelefon { get; set; }
        [Display(Name = "Full Name")]
        public string? FullName
        {
            get
            {
                return Nume + " " + Prenume;
            }
        }
        public ICollection<Inchiriere>? Inchirieri { get; set; }

    }
}
