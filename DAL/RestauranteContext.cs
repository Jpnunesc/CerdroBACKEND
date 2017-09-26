using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    public class RestauranteContext : DbContext
    {
        public RestauranteContext() : base("RestauranteContexto")
        { }

        public IDbSet<Restaurante> Restaurantes { get; set; }
        public IDbSet<Prato> Pratos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
    }
