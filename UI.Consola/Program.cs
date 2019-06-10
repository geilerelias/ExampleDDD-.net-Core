using System;
using System.Collections.Generic;
using System.Linq;
using Applications.Implements;
using Domain.Entities;
using Infraestructure.Data;
using Infraestructure.Data.Base;
using Infraestructure.Data.Repositories;
namespace UI.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            BancoContext context = new BancoContext();
            #region  Crear Country
            CountryService service = new CountryService(new UnitOfWork(context), new CountryRepository(context));

            Country country = new Country() { Name = "Colombia" };

            service.Create(country);

            List<Country> countries = service.GetAll().ToList();

            foreach (var item in countries)
            {
                System.Console.WriteLine(item.Name);
            }
            #endregion
            System.Console.ReadKey();
        }
    }
}
