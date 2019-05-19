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
        public int id_passo { set; get; }
        public string descricao { set; get; }
        public string timestamp { set; get; }
        public int id_acao { set; get; }
        public Acao Acao { set; get; }
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
