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
            CountryService service = new CountryService(new UnitOfWork(context), new CountryRepository(context));

            ConsoleKeyInfo op;

            do
            {

                Console.Clear(); //Limpiar la pantalla
                //Console. = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("    Main    ");
                Console.WriteLine("____________");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[A] Add");
                Console.WriteLine("[F] Find");
                Console.WriteLine("[D] Delete");
                Console.WriteLine("[U] Update");
                Console.WriteLine("[G] Get All");
                Console.WriteLine("[Esc] Exit");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Select option...");
                op = Console.ReadKey(true);//Que no muestre la tecla señalada
                Console.WriteLine("");

                //métodos son acciones, las propiedades son valores
                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have selected the option Add");
                        AddCountry(context, service);
                        break;

                    case ConsoleKey.D:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have selected the option Delete");
                        DeleteCountry(context, service);
                        break;

                    case ConsoleKey.F:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have selected the option Find");
                        FindCountry(context, service);
                        break;

                    case ConsoleKey.U:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have selected the option Update");
                        UpdateCountry(context, service);
                        break;

                    case ConsoleKey.G:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have selected the option Get All");
                        GetAllCountry(context, service);
                        break;

                    case ConsoleKey.Escape:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bye...");
                        break;
                }
            } while (op.Key != ConsoleKey.Escape);
        }



        private static void AddCountry(BancoContext context, CountryService service)
        {
            string name = "";
            Console.Write("Write the name: ");
            name = Console.ReadLine();
            Country country = new Country() { Name = name };
            service.Create(country);
            Paused();
        }

        private static Country FindCountry(BancoContext context, CountryService service)
        {
            Console.Write("Write the Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Country country = service.Find(id);
            Console.WriteLine($"Id: {country.Id} Name: {country.Name}");
            Paused();
            return country;
        }
        private static void DeleteCountry(BancoContext context, CountryService service)
        {
            Country country = FindCountry(context,service);
            service.Delete(country);
            Paused();
        }
        private static void UpdateCountry(BancoContext context, CountryService service)
        {
            Country country = FindCountry(context, service);
            Console.WriteLine($"Id: {country.Id} Name: {country.Name}");
            Console.WriteLine("");
            Console.Write("Write the new name: ");
            string name = Console.ReadLine();
            country.Name = name;
            service.Update(country);

            Paused();
        }
        private static void GetAllCountry(BancoContext context, CountryService service)
        {
            List<Country> countries = service.GetAll().ToList();

            foreach (var country in countries)
            {
                Console.WriteLine($"Id: {country.Id} Name: {country.Name}");
            }
            Paused();
        }


        private static void Paused()
        {
            Console.Write("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
