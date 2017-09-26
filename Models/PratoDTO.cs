using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    public class PratoDTO
    {

        public int PratoID { get; set; }
        public string NomePrato { get; set; }
        public decimal PrecoPrato { get; set; }

        public int RestauranteID { get; set; }
        public string NomeRestaurante { get; set; }

      


    }
}