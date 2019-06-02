using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class Utilizador
    {
        [Key]
        public int id_utilizador { set; get; }

        [Display(Name = "Nome")]
        [StringLength(50)]
        public string nome { set; get; }

        [Required]
        [Display(Name = "Email")]
        [StringLength(75)]
        [DataType(DataType.EmailAddress)]
        public string email { set; get; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string password { set; get; }

        
    }

    public class UtilizadorContext : DbContext
    {
        public UtilizadorContext(DbContextOptions<UtilizadorContext> options)
            : base(options)
        {

        }

        public DbSet<Utilizador> utilizador { get; set; }

    }
}
