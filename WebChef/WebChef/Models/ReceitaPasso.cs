using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class ReceitaPasso
    {
        [Display(Name = "Passp")]
        public int id_passo { set; get; }
        [Display(Name = "Receita")]
        public int id_receita { set; get; }

        [Display(Name = "Número")]
        public int numero { set; get; }
    }


    public class ReceitaPassoContext : DbContext
    {
        public ReceitaPassoContext(DbContextOptions<ReceitaPassoContext> options)
            : base(options)
        {

        }

        public DbSet<ReceitaPasso> receitaPasso { get; set; }

        // Fluent API - indica que a chave primaria é composta
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceitaPasso>()
                .HasKey(ru => new { ru.id_passo, ru.id_receita });
        }
    }
}
