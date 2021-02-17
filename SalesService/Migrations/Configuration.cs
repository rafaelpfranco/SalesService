using SalesService.Models;

namespace SalesService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesService.Models.SalesServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SalesService.Models.SalesServiceContext context)
        {
            context.Revendedors.AddOrUpdate(x => x.Id,
             new Revendedor() { Id = 1, Name = "Rafael Franco" },
             new Revendedor() { Id = 2, Name = "Ananda Gouveia" },
             new Revendedor() { Id = 3, Name = "C�cero Nascimento" }
         );

            context.Produtoes.AddOrUpdate(x => x.Id,
                new Produto()
                {
                    Id = 1,
                    Name = "Redmi Note 10",
                    Category = "Celular",
                    RevendedorId = 1,
                    Price = 1979.99M,
                    Description = "Celular da Marca Xioami super potente."
                },
                new Produto()
                {
                    Id = 2,
                    Name = "Mouse G502 Logitech",
                    Category = "Perif�rico",
                    RevendedorId = 2,
                    Price = 499.85M,
                    Description = "Mouse de alta precis�o da marca Logitech"
                },
                new Produto()
                {
                    Id = 3,
                    Name = "Notebook Accer - Aspire 3",
                    Category = "Computador",
                    RevendedorId = 3,
                    Price = 5690.00M,
                    Description = "Notebook Accer - Aspire 3 - Processador intel i7 10700k"
                },
                new Produto()
                {
                    Id = 4,
                    Name = "Mem�ria DDR4 8 GB - 3000MHz ",
                    Category = "Pe�as e Acess�rios",
                    RevendedorId = 2,
                    Price = 289.90M,
                    Description = "Mem�ria Adata XPG Spectrix D41, excelente performance"
                }
            );
        }
    }
}
