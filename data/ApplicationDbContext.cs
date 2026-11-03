using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TP2BACKEND_DEFINITIVO.models;

namespace TP2BACKEND_DEFINITIVO.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Articulo> Articulos { get; set; }
    }
}