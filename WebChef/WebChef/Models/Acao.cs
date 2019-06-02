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
        [Display(Name = "Ação")]
        public int id_acao { set; get; }

        [Display(Name = "Nome")]
        [StringLength(50)]
        public string nome { set; get; }
        [Display(Name = "Designação")]
        [StringLength(150)]
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
