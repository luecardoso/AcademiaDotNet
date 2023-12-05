using CA_Entity.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Entity
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Email> Emails { get; set; }

        public Contexto(){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //acessa as configurações do appconfig
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["aulaentity"];//com esse config name
            string retorno = settings.ConnectionString;
            if (settings != null)
            {
                retorno = settings.ConnectionString;//pega a string da conexão do database
            }

            optionsBuilder.UseSqlServer(retorno);
            //optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=aulaentity;User ID=aulaentity;password=senha1234;language=Portuguese;");
            
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.pessoa)//todo e qualquer email tem um vinculo com pessoa
                .WithMany(p => p.Emails)//para todo e qualquer email tem uma pessoa
                .OnDelete(DeleteBehavior.ClientCascade);
            
        }

    }
}
