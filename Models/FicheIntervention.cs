using System.Data.SqlTypes;

namespace Ge2Co.Models
{
    public class FicheIntervention
    {
        public int Id { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? DateCloture { get; set; }
        public string Description { get; set; }
        public double Montant { get; set; }
        public int CommandeId { get; set; }
        public Commande? Commande { get; set; }
        public int StatusFicheInterventionId { get; set; }
        public StatusFicheIntervention? StatusFicheIntervention { get; set; }
    }

}