namespace Proiect_Medii_2.Models
{
    public class Categorie
    {
        public int ID { get; set; }
 public string TipMasina { get; set; }
 public ICollection<CategorieMasina>? CategoriiMasina { get; set; } 
    }
}
