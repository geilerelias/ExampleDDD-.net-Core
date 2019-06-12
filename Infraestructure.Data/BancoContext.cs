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
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("database=BancoDB;server=localhost;port=3306;user id=root;password=");
            }
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BancoExampleDDD;Trusted_Connection=True;");
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Country> Countries { get; set; }

    }
}
