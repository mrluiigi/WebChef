using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class ReceitaIngrediente
    {
        public int id_receita { get; set; }
        public int id_ingrediente { get; set; }
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
