using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdministrareMagazin
{
    public class Produs
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Denumire { get; set; }

        [MaxLength(500)]
        public string Descriere { get; set; }

        public DateTime DataIntrare { get; set; }

        [Required]
        public DateTime DataValabilitate { get; set; }

        [Required]
        public int Cantitate { get; set; }
    }

    public class Utilizator
    {
        [Required]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Nume { get; set; }
        [MaxLength(30)]
        public string Prenume { get; set; }
        [MaxLength(30)]
        public string Username { get; set; }
        [MaxLength(30)]
        public string Parola { get; set; }
    }

    public class IstoricVanzari
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdUser { get; set; }
        [Required]
        public string DenumireProdus { get; set; }
        [Required]
        public int Cantitate { get; set; }
    }

    public class MagazinDbContext : DbContext
    {
        // migrarea datelor noi in bd
        //public MagazinDbContext() : base()
        //{
        //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<MagazinDbContext, AdministrareMagazin.Migrations.Configuration>());
        //}
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Utilizator> Utilizatori { get; set; }
        public DbSet<IstoricVanzari> istoricVanzari { get; set; }


        //  migrarea datelor noi in bd
        //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //    {
        //        base.OnModelCreating(modelBuilder);
        //    }
        //}
    }
}