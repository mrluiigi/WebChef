using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class EmentaSemanal
    {
        public int id_receita { set; get; }
        public int id_utilizador { set; get; }

        [Display(Name = "Dia da Semana")]
        [StringLength(4)]
        public string dia_da_semana { set; get; }

        [NotMapped]
        public Receita receita { set; get; }

    }


    public class EmentaSemanalContext : DbContext
    {
        public EmentaSemanalContext(DbContextOptions<EmentaSemanalContext> options)
            : base(options)
        {

        }

        public DbSet<EmentaSemanal> ementaSemanal { get; set; }

        // Fluent API - indica que a chave primaria é composta
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmentaSemanal>()
                .HasKey(ru => new { ru.id_receita, ru.id_utilizador, ru.dia_da_semana });
        }
    }
}
