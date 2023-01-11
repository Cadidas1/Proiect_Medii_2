namespace Proiect_Medii_2.Models
{
    public class DateMasina
    {
        public IEnumerable<Masina> Masini { get; set; }
        public IEnumerable<Categorie> Categorii { get; set; }
        public IEnumerable<CategorieMasina> CategoriiMasina { get; set; }
    }
}