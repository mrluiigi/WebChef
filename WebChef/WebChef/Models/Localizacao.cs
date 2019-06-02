using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class Localizacao
    {
        [Key]
        [Display(Name = "Localização")]
        public int id_localizacao { set; get; }

        [Display(Name = "Nome")]
        [StringLength(50)]
        public string nome { set; get; }

        [Display(Name = "Coordenadas")]
        [StringLength(50)]
        public string coordenadas { set; get; }
    }

    public class LocalizacaoContext : DbContext
    {
        public LocalizacaoContext(DbContextOptions<LocalizacaoContext> options)
            : base(options)
        {

        }

        public DbSet<Localizacao> localizacao { get; set; }
    }
}
