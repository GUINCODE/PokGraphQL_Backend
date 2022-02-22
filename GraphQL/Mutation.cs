using System;
using Ge2Co.Models;

namespace Ge2Co.GraphQL
{
    public class Mutation
    {
        public async Task<String> SaveCommandeAsync([Service] DataAppContext context, Commande newCommande)
        {
            context.Commandes.Add(newCommande);
            await context.SaveChangesAsync();
            return "saved";
        }
    }
}