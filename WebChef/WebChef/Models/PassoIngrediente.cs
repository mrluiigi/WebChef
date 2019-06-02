using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class PassoIngrediente
    {
        [Display(Name = "Passo")]
        public int id_passo { set; get; }
        [Display(Name = "Ingrediente")]
        public int id_ingrediente { set; get; }

        [Display(Name = "Quantidade")]
        [StringLength(50)]
        public string quantidade { set; get; }
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
