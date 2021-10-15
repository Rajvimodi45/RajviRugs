using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace RajviRugs.Models
{
    public class Rugs
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Color { get; set; }

        public string Type { get; set; }

        public decimal Price { get; set; }

        public decimal Rating { get; set; }
    }
}
