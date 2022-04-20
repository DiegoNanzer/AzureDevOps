using AzureDevOps.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDevOps.Infra
{
    public class AzureDevOpsConext : DbContext
    {
        public DbSet<Smurf> Smurfs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringconexao = "server=localhost;" +
                                   "DataBase=AzureDevOps;Uid=root;Pwd=password";

            optionsBuilder.UseMySql(stringconexao,
                                    ServerVersion.AutoDetect(stringconexao));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Smurf>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Idade);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
