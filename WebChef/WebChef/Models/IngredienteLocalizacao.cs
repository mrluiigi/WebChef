using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class IngredienteLocalizacao
    {
        public int id_localizacao { set; get; }
        public int id_ingrediente { set; get; }
    }

    public class IngredienteLocalizacaoContext : DbContext
    {
        public IngredienteLocalizacaoContext(DbContextOptions<IngredienteLocalizacaoContext> options)
            : base(options)
        {

        }

        public DbSet<IngredienteLocalizacao> ingredienteLocalizacao { get; set; }

        // Fluent API - indica que a chave primaria é composta
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngredienteLocalizacao>()
                .HasKey(ru => new { ru.id_localizacao, ru.id_ingrediente });
        }
    }
}
