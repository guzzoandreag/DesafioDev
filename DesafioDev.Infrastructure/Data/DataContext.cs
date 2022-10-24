using DesafioDev.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace DesafioDev.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        private const string ConnectionString = @"Server=.\DEVELOP;Database=dbDesafioDev;User Id=sa;Password=5038;";

        public DataContext()
        {
            //
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString, options => options.MigrationsAssembly("DesafioDev.Infrastructure"));

                base.OnConfiguring(optionsBuilder);
            }            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Fornecedor>().ToTable("Fornecedor").HasKey(x => x.for_codigo);
            //builder.Entity<Produto>().ToTable("Produto").HasKey(x => x.pro_codigo);
            //base.OnModelCreating(builder);
        }

        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Produto> Produto { get; set; }

        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
        //    {
        //        if (entry.State == EntityState.Added)
        //        {
        //            entry.Property("DataCadastro").CurrentValue = DateTime.Now;
        //        }
        //        if (entry.State == EntityState.Modified)
        //        {
        //            entry.Property("DataCadastro").IsModified = false;
        //        }
        //    }
        //    return base.SaveChanges();
        //}
    }
}