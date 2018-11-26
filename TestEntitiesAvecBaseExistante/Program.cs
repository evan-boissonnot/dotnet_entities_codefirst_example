using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace TestEntitiesAvecBaseExistante
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");

            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultContextDatabase");

            DbContextOptionsBuilder<Contexts.DefaultContext> dbBuilder = new DbContextOptionsBuilder<Contexts.DefaultContext>();

            dbBuilder.UseSqlServer(connectionString);

            using (Contexts.DefaultContext context = new Contexts.DefaultContext(dbBuilder.Options))
            {
                var list = context.Paragraphes.ToList();

                foreach (var item in list)
                {
                    Console.WriteLine(item.Titre);
                }
            }
        }
    }
}
