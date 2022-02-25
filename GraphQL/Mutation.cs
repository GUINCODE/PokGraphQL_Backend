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

        public async Task<String> DeleteCommandeAsync([Service] DataAppContext context, int id)
        {
            var cmd = await context.Commandes.FindAsync(id);
            if (cmd == null)
            {
                return "not found";
            }
            context.Commandes.Remove(cmd);
            await context.SaveChangesAsync();
            return "deleted";
        }
    }
}