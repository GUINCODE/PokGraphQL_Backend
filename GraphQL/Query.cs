using Ge2Co.Models;

namespace Ge2Co.GraphQL
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Commande> GetCommandes([Service] DataAppContext context)
        {
            return context.Commandes;
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<FicheIntervention> GetFiches([Service] DataAppContext context)
        {
            return context.FicheInterventions;
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Personnel> GetPersonnels([Service] DataAppContext context)
        {
            return context.Personnels;
        }
    }
}