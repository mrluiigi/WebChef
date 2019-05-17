﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChef.Models;
using WebChef.shared;

namespace WebChef.shared
{
    public class ReceitaHandling
    {
        private readonly ReceitaContext _context;
        private readonly ReceitaUtilizadorContext _contextRU;


        public ReceitaHandling(ReceitaContext context, ReceitaUtilizadorContext contextRU)
        {
            _context = context;
            _contextRU = contextRU;
        }

        public Receita[] getReceitas()
        {
            return _context.receita.ToArray();
        }
        
        public Receita getReceita(int id)
        {
            return _context.receita.Where(r => r.id_receita == id).FirstOrDefault();
        }

        // A função serve para verificar se o utilizador tem a receita como favorita
        public bool TemReceitaFavorita(int idReceita, int idUtilizador)
        {
            return _contextRU.receitaUtilizador.Any(ru => ru.id_receita == idReceita && ru.id_utilizador == idUtilizador && ru.favorita == "S");
        }

        // A função serve para verificar se o utilizador tem a receita na ementa semanal
        public bool TemReceitaNaEmenta(int idReceita, int idUtilizador)
        {
            return _contextRU.receitaUtilizador.Any(ru => ru.id_receita == idReceita && ru.id_utilizador == idUtilizador && ru.dia_da_semana != null && ru.refeicao != null);
        }

        public void addReceitaEmenta(int idReceita, int idUtilizador, string text)
        {
            string diaSemana = text.Substring(0,3);
            string refeicao = text[3].ToString();
            ReceitaUtilizador r = _contextRU.receitaUtilizador.Where(ru => ru.id_receita == idReceita && ru.id_utilizador == idUtilizador).FirstOrDefault();
            if (r != null)
            {
                r.dia_da_semana = diaSemana;
                r.refeicao = refeicao;
                _contextRU.SaveChanges();
            }
            else
            {
                ReceitaUtilizador ru = new ReceitaUtilizador(idReceita, idUtilizador, null, null, null, diaSemana, refeicao, null, null, null);
                _contextRU.receitaUtilizador.Add(ru);
                _contextRU.SaveChanges();
            }
        }

    }
}
