using System.ComponentModel.DataAnnotations;

namespace Proiect_Medii_2.Models
{
    public class Inchiriere
    {
        public int ID { get; set; }
        public int? ClientID { get; set; }
        public Client? Client { get; set; }
        public int? MasinaID { get; set; }
        public Masina? Masina { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataReturnarii { get; set; }

    }
}
