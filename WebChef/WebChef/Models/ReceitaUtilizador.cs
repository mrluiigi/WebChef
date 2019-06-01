using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class ReceitaUtilizador
    {
        public int id_receita { get; set; }
        public int id_utilizador { get; set; }
        [Display(Name = "Duração")]
        public TimeSpan? duracao { get; set; }
        public string favorita { get; set; }
        public string avaliacao_dificuldade { get; set; }
        public int? classificacao { get; set; }
        public DateTime? data_realizacao { get; set; }
        public string anotacao { get; set; }
        public TimeSpan? timeInicio { get; set; }

        [NotMapped]
        public Utilizador utilizador { get; set; }
        [NotMapped]
        public Receita receita { get; set; }

        
    }

    public class ReceitaUtilizadorContext : DbContext
    {
        public ReceitaUtilizadorContext(DbContextOptions<ReceitaUtilizadorContext> options)
            : base(options)
        {

        }

        public DbSet<ReceitaUtilizador> receitaUtilizador { get; set; }

        // Fluent API - indica que a chave primaria é composta
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceitaUtilizador>()
                .HasKey(ru => new { ru.id_receita, ru.id_utilizador });
        }
    }
}