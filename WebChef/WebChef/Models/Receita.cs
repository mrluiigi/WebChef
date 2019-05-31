﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class Receita
    {
        [Key]
        public int id_receita { set; get; }

        [Display(Name = "Nome")]
        [StringLength(75)]
        public string nome { set; get; }
        
        [StringLength(300)]
        [Display(Name = "Descrição")]
        public string descricao { set; get; }

        [Display(Name = "Informação Nutricional")]
        public string informacao_nutricional { set; get; }

        [Display(Name = "Duração Prevista")]
        public int duracao_prevista { set; get; }
        [Display(Name = "Link de Ajuda")]
        public string link_ajuda { set; get; }
        [Display(Name = "Imagem")]
        public string imagem { set; get; }

        [NotMapped]
        public IFormFile imagemFicheiro { set; get; }

        [Display(Name = "Número de Pessoas")]
        public int nr_pessoas { set; get; }

        [Display(Name = "Dificuldade")]
        public string dificuldade { set; get; }

        [Display(Name = "Categoria")]
        public string categoria { set; get; }
        

        [NotMapped]
        public Ingrediente[] ingredientes { set; get; }
        [NotMapped]
        [Display(Name = "Horas")]
        public int horas { set; get; }
        [NotMapped]
        [Display(Name = "Minutos")]
        public int minutos { set; get; }
        [NotMapped]
        [Display(Name = "Segundos")]
        public int segundos { set; get; }
        [NotMapped]
        public string duracao_prevista_display { get { return Math.Round((float)duracao_prevista / 3600) + ":" + Math.Round((float)(duracao_prevista / 60) % 60) + ":" + Math.Round((float)duracao_prevista % 60); } }

        [NotMapped]
        [Display(Name = "Energia(Kcal)")]
        public float energia { get; set; }
        [NotMapped]
        [Display(Name = "Lípidos(g)")]
        public float lipidos { get; set; }
        [NotMapped]
        [Display(Name = "Saturados(g)")]
        public float saturados { get; set; }
        [NotMapped]
        [Display(Name = "Hidratos de Carbono(g)")]
        public float hidratosCarbono { get; set; }
        [NotMapped]
        [Display(Name = "Açúcares(g)")]
        public float acucares { get; set; }
        [NotMapped]
        [Display(Name = "Fibras(g)")]
        public float fibras { get; set; }
        [NotMapped]
        [Display(Name = "Proteínas(g)")]
        public float proteinas { get; set; }
        [NotMapped]
        [Display(Name = "Sal(g)")]
        public float sal { get; set; }

    }


    public class ReceitaContext : DbContext
    {
        public ReceitaContext(DbContextOptions<ReceitaContext> options)
            : base(options)
        {

        }

        public DbSet<Receita> receita { get; set; }
    }
}
