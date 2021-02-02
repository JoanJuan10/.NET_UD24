using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_EX3.Models
{
    public class Asignado
    {
        [Key]
        public int Proyecto { get; set; }
        public int Cientifico { get; set; }
    }
}
