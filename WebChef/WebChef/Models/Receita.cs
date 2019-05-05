using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name = "Duração")]
        public TimeSpan duracao_prevista { set; get; }

        public string link_ajuda { set; get; }
        public string imagem { set; get; }

        [StringLength(50)]
        [Display(Name = "Número de Pessoas")]
        public int nr_pessoas { set; get; }

        [Display(Name = "Dificuldade")]
        public string dificuldade { set; get; }

        public string categoria { set; get; }
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
