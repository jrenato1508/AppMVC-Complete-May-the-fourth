using MayTheFourth.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Data.Context
{
    public class MayTheFourthContext : DbContext
    {
        public MayTheFourthContext(DbContextOptions<MayTheFourthContext> options) : base(options){}

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<NaveEstrelar> NavesEstrelares { get; set; }
        public DbSet<Planeta> Planetas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
            .SelectMany(e => e.GetProperties()
            .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("Varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MayTheFourthContext).Assembly);


            base.OnModelCreating(modelBuilder);
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
