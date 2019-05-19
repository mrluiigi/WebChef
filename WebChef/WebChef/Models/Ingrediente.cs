using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class Ingrediente
    {
        [Key]
        public int id_ingrediente { set; get; }
        public string designacao { set; get; }
        public string imagem { set; get; }
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
