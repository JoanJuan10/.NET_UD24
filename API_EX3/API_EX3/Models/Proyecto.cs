using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_EX3.Models
{
    public class Proyecto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Horas { get; set; }

    }
}
