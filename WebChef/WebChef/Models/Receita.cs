using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class Receita
    {
        [Key]
        public int id_receita { set; get; }

        [Display(Name = "Nome")]
        [StringLength(75)]
        public string nome { set; get; }
        
        [StringLength(300)]
        [Display(Name = "Descrição")]
        public string descricao { set; get; }

        [Display(Name = "Informação Nutricional")]
        public string informacao_nutricional { set; get; }

        [Display(Name = "Duração Prevista")]
        public int duracao_prevista { set; get; }

        public string link_ajuda { set; get; }
        public string imagem { set; get; }

        [Display(Name = "Número de Pessoas")]
        public int nr_pessoas { set; get; }

        [Display(Name = "Dificuldade")]
        public string dificuldade { set; get; }

        [Display(Name = "Categoria")]
        public string categoria { set; get; }
        

        [NotMapped]
        public Ingrediente[] ingredientes { set; get; }
        [NotMapped]
        public int horas { set; get; }
        [NotMapped]
        public int minutos { set; get; }
        [NotMapped]
        public int segundos { set; get; }
        [NotMapped]
        public string duracao_prevista_display { get { return Math.Round((float)duracao_prevista / 3600) + ":" + Math.Round((float)(duracao_prevista / 60) % 60) + ":" + Math.Round((float)duracao_prevista % 60); } }

    }

    public class ReceitaContext : DbContext
    {
        public ReceitaContext(DbContextOptions<ReceitaContext> options)
            : base(options)
        {

        }

        public DbSet<Receita> receita { get; set; }
    }
}
