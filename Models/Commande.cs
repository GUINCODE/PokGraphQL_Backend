using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using Ge2Co.Models.ManyToMany;

namespace Ge2Co.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public double MontantTotal { get; set; }
        public string NumCommande { get; set; }
        public int EntrepriseId { get; set; }
        public Entreprise Entreprise { get; set; }
        public ICollection<FicheIntervention>? FicheInterventions { get; set; }
        public ICollection<CommandePersonnel>? CommandePersonnels { get; set; }
    }
}