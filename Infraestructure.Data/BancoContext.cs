using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Text;
using Domain.Entities;
using Infraestructure.Data.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure.Data
{
    public class BancoContext : DbContextBase
    {
      
        //"Name=BancoContext"
       
        public BancoContext()
        {
           
        }
        protected BancoContext(DbConnection connection):base(connection)
        {

        }
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BancoExampleDDD;Trusted_Connection=True;");
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Country> Countries { get; set; }

    }
}
