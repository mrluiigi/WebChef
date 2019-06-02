using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    [Table("Passo")]
    public class Passo
    {
        [Key]
        [Display(Name = "Passo")]
        public int id_passo { set; get; }

        [Display(Name = "Descrição")]
        [Required]
        [StringLength(300)]
        public string descricao { set; get; }

        [Display(Name = "Timestamp")]
        [StringLength(4)]
        public string timestamp { set; get; }

        [Display(Name = "Ação")]
        [Required]
        public int id_acao { set; get; }

        public Acao Acao { set; get; }

        [Display(Name = "Duração")]
        public int? duracao { set; get; }
        public ICollection<Ingrediente> ingredientes { set; get; }
        [NotMapped]
        public PassoIngrediente[] passosIngrediente { set; get; }
    }

    public class PassoContext : DbContext
    {
        public PassoContext(DbContextOptions<PassoContext> options)
            : base(options)
        {

        }

        public DbSet<Passo> passo { get; set; }
    }
}
