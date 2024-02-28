using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Data
{
    public class StoreAppContext : DbContext
    {
        public StoreAppContext (DbContextOptions<StoreAppContext> options)
            : base(options)
        {
        }

        public DbSet<StoreApp.Models.Article> Article { get; set; } = default!;
        public DbSet<StoreApp.Models.Category> Category { get; set; } = default!;
        public DbSet<StoreApp.Models.Manufacturer> Manufacturer { get; set; } = default!;
    }
}
