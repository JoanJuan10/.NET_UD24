﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API_EX2.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base (options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
