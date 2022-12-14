using Microsoft.EntityFrameworkCore;
using FULL_TECNO_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FULL_TECNO_1.Data
{
    public class FULL_TECNO_1Context : DbContext
    {
        public FULL_TECNO_1Context(DbContextOptions<FULL_TECNO_1Context> options) : base(options)
        {

        }

        public DbSet<Audifonos> Audifonos { get; set; }
        public DbSet<Monitores> Monitores { get; set; }
        public DbSet<Mouses> Mouses { get; set; }
        public DbSet<Procesadores> Procesadores { get; set; }
        public DbSet<TarjetasGraficas> TarjetasGraficas { get; set; }

    }

    
}
