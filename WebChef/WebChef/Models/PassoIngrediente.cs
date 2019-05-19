using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class PassoIngrediente
    {
        public int id_passo { set; get; }
        public int id_ingrediente { set; get; }
        public double? quantidade { set; get; }
    }

    public class PassoIngredienteContext : DbContext
    {
        public PassoIngredienteContext(DbContextOptions<PassoIngredienteContext> options)
            : base(options)
        {

        }

        public DbSet<PassoIngrediente> passoIngrediente { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PassoIngrediente>()
                .HasKey(pi => new { pi.id_passo, pi.id_ingrediente });
        }
    }
}
