using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class Acao
    {
        [Key]
        public int id_acao { set; get; }
        [Display(Name = "Nome")]
        public string nome { set; get; }
        [Display(Name = "Designação")]
        public string descricao { set; get; }

        public ICollection<Passo> Passos { get; set; }
    }

    public class AcaoContext : DbContext
    {
        public AcaoContext(DbContextOptions<AcaoContext> options)
            : base(options)
        {

        }

        public DbSet<Acao> acao { get; set; }
    }
}
