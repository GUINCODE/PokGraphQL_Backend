using Ge2Co.Models;

namespace Ge2Co.GraphQL
{
    public class Query
    {
        // [Serial]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Commande> GetCommandes([Service] DataAppContext context)
        {
            return context.Commandes;
        }

        // [Serial]
        // [UseDbContext(typeof(MyAppContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<FicheIntervention> GetFiches([Service] DataAppContext context)
        {
            return context.FicheInterventions;
        }
    }
}