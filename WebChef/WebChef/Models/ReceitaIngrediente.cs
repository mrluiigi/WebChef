using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class ReceitaIngrediente
    {
        [Display(Name = "Receita")]
        public int id_receita { get; set; }
        [Display(Name = "Ingrediente")]
        public int id_ingrediente { get; set; }

        [Display(Name = "Quantidade")]
        [StringLength(50)]
        public string quantidade { get; set; }
    }

    public class ReceitaIngredienteContext : DbContext
    {
        public ReceitaIngredienteContext(DbContextOptions<ReceitaIngredienteContext> options)
            : base(options)
        {

        }

        public DbSet<ReceitaIngrediente> receitaIngrediente { get; set; }

        // Fluent API - indica que a chave primaria é composta
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceitaIngrediente>()
                .HasKey(ru => new { ru.id_receita, ru.id_ingrediente });
        }
    }
}
