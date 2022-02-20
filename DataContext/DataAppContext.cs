using Ge2Co.Models;
using Ge2Co.Models.ManyToMany;
using Microsoft.EntityFrameworkCore;

namespace Ge2Co.DataAppContext {
    public class DataAppContext : DbContext {
   
        public DataAppContext(DbContextOptions<DataAppContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommandePersonnel>().HasKey(sc => new { sc.CommandeId, sc.PersonnelId });   //Obligatoire pour les Deux méthodes

            //Méthode_2
            modelBuilder.Entity<Commande>()
                              .HasMany(t => t.CommandePersonnels)
                              .WithOne(t => t.Commande)
                              .HasForeignKey(t => t.CommandeId);

            modelBuilder.Entity<Personnel>()
                                .HasMany(t => t.CommandePersonnels)
                                .WithOne(t => t.Personnel)
                                .HasForeignKey(t => t.PersonnelId);
        }
        public DbSet<CommandePersonnel> CommandePersonnels { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Entreprise> Entreprises { get; set; }
        public DbSet<FicheIntervention> FicheInterventions { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<StatusFicheIntervention> StatusFicheInterventions { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
    }
}