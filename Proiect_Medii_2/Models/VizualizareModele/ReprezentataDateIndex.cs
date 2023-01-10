using Proiect_Medii_2.Models;
using System.Security.Policy;

namespace Proiect_Medii_2.Models.VizualizareModele
{
    public class ReprezentataDateIndex
    {
        public IEnumerable<Reprezentanta> Reprezentante { get; set; }
        public IEnumerable<Masina> Masini { get; set; }
    }
}
