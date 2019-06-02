using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class Ingrediente
    {
        [Key]
        public int id_ingrediente { set; get; }

        [Display(Name = "Designação")]
        [StringLength(50)]
        public string designacao { set; get; }

        [Display(Name = "Imagem")]
        [StringLength(100)]
        public string imagem { set; get; }

        [NotMapped]
        public string quantidade { set; get; }
        [NotMapped]
        public Localizacao[] localizacoes { set; get; }

        [NotMapped]
        [Required]
        public IFormFile imagemFicheiro { set; get; }

        [NotMapped]
        public string favorito { set; get; }

    }

    public class IngredienteContext : DbContext
    {
        public IngredienteContext(DbContextOptions<IngredienteContext> options)
            : base(options)
        {

        }

        public DbSet<Ingrediente> ingrediente { get; set; }
    }
}
