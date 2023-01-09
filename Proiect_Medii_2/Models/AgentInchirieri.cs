namespace Proiect_Medii_2.Models
{
    public class AgentInchirieri
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public ICollection<Masina>? Masini { get; set; }
    }
}
