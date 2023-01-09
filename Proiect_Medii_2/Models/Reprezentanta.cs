namespace Proiect_Medii_2.Models
{
    public class Reprezentanta
    {
        public int ID { get; set; }
        public string NumeReprezentanta { get; set; }
        public ICollection<Masina>? Masini { get; set; }
    }
}
