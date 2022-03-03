using Ge2Co.Models;
using HotChocolate;

namespace Ge2Co.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(DataAppContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Commande> GetCommandes([ScopedService] DataAppContext context)
        {
            return context.Commandes;
        }
        [UseDbContext(typeof(DataAppContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<FicheIntervention> GetFiches([ScopedService] DataAppContext context)
        {
            return context.FicheInterventions;
        }
        [UseDbContext(typeof(DataAppContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Personnel> GetPersonnels([ScopedService] DataAppContext context)
        {
            return context.Personnels;
        }
        [UseDbContext(typeof(DataAppContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Entreprise> GetEntreprises([ScopedService] DataAppContext context)
        {
            return context.Entreprises;
        }
    }
}