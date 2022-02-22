﻿// <auto-generated />
using System;
using Ge2Co.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ge2Co.Migrations
{
    [DbContext(typeof(DataAppContext))]
    [Migration("20220222205554_ThreeMigrations")]
    partial class ThreeMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ge2Co.Models.Commande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EntrepriseId")
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MontantTotal")
                        .HasColumnType("float");

                    b.Property<string>("NumCommande")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EntrepriseId");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("Ge2Co.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Ge2Co.Models.Entreprise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Entreprises");
                });

            modelBuilder.Entity("Ge2Co.Models.FicheIntervention", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCloture")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Montant")
                        .HasColumnType("float");

                    b.Property<int>("StatusFicheInterventionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommandeId");

                    b.HasIndex("StatusFicheInterventionId");

                    b.ToTable("FicheInterventions");
                });

            modelBuilder.Entity("Ge2Co.Models.ManyToMany.CommandePersonnel", b =>
                {
                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<int>("PersonnelId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("CommandeId", "PersonnelId");

                    b.HasIndex("PersonnelId");

                    b.HasIndex("RoleId");

                    b.ToTable("CommandePersonnels");
                });

            modelBuilder.Entity("Ge2Co.Models.Personnel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personnels");
                });

            modelBuilder.Entity("Ge2Co.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Labelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Ge2Co.Models.StatusFicheIntervention", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Labelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StatusFicheInterventions");
                });

            modelBuilder.Entity("Ge2Co.Models.Telephone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Telephones");
                });

            modelBuilder.Entity("Ge2Co.Models.Commande", b =>
                {
                    b.HasOne("Ge2Co.Models.Entreprise", "Entreprise")
                        .WithMany()
                        .HasForeignKey("EntrepriseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entreprise");
                });

            modelBuilder.Entity("Ge2Co.Models.Entreprise", b =>
                {
                    b.HasOne("Ge2Co.Models.Contact", "ContactName")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.Navigation("ContactName");
                });

            modelBuilder.Entity("Ge2Co.Models.FicheIntervention", b =>
                {
                    b.HasOne("Ge2Co.Models.Commande", "Commande")
                        .WithMany("FicheInterventions")
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ge2Co.Models.StatusFicheIntervention", "StatusFicheIntervention")
                        .WithMany()
                        .HasForeignKey("StatusFicheInterventionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commande");

                    b.Navigation("StatusFicheIntervention");
                });

            modelBuilder.Entity("Ge2Co.Models.ManyToMany.CommandePersonnel", b =>
                {
                    b.HasOne("Ge2Co.Models.Commande", "Commande")
                        .WithMany("CommandePersonnels")
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ge2Co.Models.Personnel", "Personnel")
                        .WithMany("CommandePersonnels")
                        .HasForeignKey("PersonnelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ge2Co.Models.Role", "Role")
                        .WithMany("CommandePersonnels")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commande");

                    b.Navigation("Personnel");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Ge2Co.Models.Telephone", b =>
                {
                    b.HasOne("Ge2Co.Models.Contact", "Contact")
                        .WithMany("Telephones")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("Ge2Co.Models.Commande", b =>
                {
                    b.Navigation("CommandePersonnels");

                    b.Navigation("FicheInterventions");
                });

            modelBuilder.Entity("Ge2Co.Models.Contact", b =>
                {
                    b.Navigation("Telephones");
                });

            modelBuilder.Entity("Ge2Co.Models.Personnel", b =>
                {
                    b.Navigation("CommandePersonnels");
                });

            modelBuilder.Entity("Ge2Co.Models.Role", b =>
                {
                    b.Navigation("CommandePersonnels");
                });
#pragma warning restore 612, 618
        }
    }
}
