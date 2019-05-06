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
        public string nome { set; get; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string email { set; get; }

        [Display(Name = "Password")]
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
