using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class IngredientePreferidoUtilizador
    {
        [Display(Name = "Ingrediente")]
        public int id_ingrediente { set; get; }
        [Display(Name = "Utilizador")]
        public int id_utilizador { set; get; }

        [StringLength(1)]
        [Display(Name = "Favorito")]
        public string favorito { set; get; }
    }

    public class IngredientePreferidoUtilizadorContext : DbContext
    {
        public IngredientePreferidoUtilizadorContext(DbContextOptions<IngredientePreferidoUtilizadorContext> options)
            : base(options)
        {

        }

        public DbSet<IngredientePreferidoUtilizador> ingredientePreferidoUtilizador { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngredientePreferidoUtilizador>()
                .HasKey(pi => new { pi.id_ingrediente, pi.id_utilizador });
        }

    }

}
