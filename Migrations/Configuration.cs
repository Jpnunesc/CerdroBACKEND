namespace Projeto.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Projeto.Models.RestauranteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Projeto.Models.RestauranteContext context)
        {
           var Restaurantes = new List<Restaurante> {
               new Restaurante {RestauranteID= 1, NomeRestaurante="ComidaMineira" }
           };
            Restaurantes.ForEach(s => context.Restaurantes.AddOrUpdate(p => p.NomeRestaurante, s));
           context.SaveChanges();

           var Pratos = new List<Prato> {
               new Prato {PratoID= 1, NomePrato="Galinhada", PrecoPrato= 20, RestauranteID= 1 }
          };
        
           Pratos.ForEach(s => context.Pratos.AddOrUpdate(p => p.NomePrato, s));
            context.SaveChanges();
        }
    }
}
