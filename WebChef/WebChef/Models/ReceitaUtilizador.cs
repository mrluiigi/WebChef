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
        public TimeSpan? duracao { get; set; }
        public string favorita { get; set; }
        public string avaliacao_dificuldade { get; set; }
        public string dia_da_semana { get; set; }
        public string refeicao { get; set; }
        public int? classificacao { get; set; }
        public DateTime? data_realizacao { get; set; }
        public string anotacao { get; set; }

        [NotMapped]
        public Utilizador utilizador { get; set; }
        [NotMapped]
        public Receita receita { get; set; }
        


        public ReceitaUtilizador(int id_receita, int id_utilizador, TimeSpan? duracao, string favorita, string avaliacao_dificuldade, string dia_da_semana, string refeicao, int? classificacao, DateTime? data_realizacao, string anotacao)
        {
            this.id_receita = id_receita;
            this.id_utilizador = id_utilizador;
            this.duracao = duracao;
            this.favorita = favorita;
            this.avaliacao_dificuldade = avaliacao_dificuldade;
            this.dia_da_semana = dia_da_semana;
            this.refeicao = refeicao;
            this.classificacao = classificacao;
            this.data_realizacao = data_realizacao;
            this.anotacao = anotacao;
        }
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