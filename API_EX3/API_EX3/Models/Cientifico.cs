﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_EX3.Models
{
    public class Cientifico
    {
        [Key]
        public string DNI { get; set; }
        public string NomApels { get; set; }
    }
}
