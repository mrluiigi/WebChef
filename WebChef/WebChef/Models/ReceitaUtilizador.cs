using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{

    // NÃO SEI AINDA SE ISTO É PRECISO
    public class ReceitaUtilizador
    {
        [Key]
        public int id_receita { get; set; }
        [Key]
        public int id_utilizador { get; set; }
        public TimeSpan duracao { get; set; }
        public char favorita { get; set; }
        public string avaliacao_dificuldade { get; set; }
        public string dia_da_semana { get; set; }
        public int classificacao { get; set; }
        public DateTime data_realizacao { get; set; }
        public string anotacao { get; set; }


        public ReceitaUtilizador(int id_receita, int id_utilizador, char favorita)
        {
            this.id_receita = id_receita;
            this.id_utilizador = id_utilizador;
            this.favorita = this.favorita;
        }
    }
}