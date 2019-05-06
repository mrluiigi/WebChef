using System;
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
        private readonly ReceitaUtilizadorContext _contextReceitaUtilizador;


        public ReceitaHandling(ReceitaContext context, ReceitaUtilizadorContext contextRU)
        {
            _context = context;
            _contextReceitaUtilizador = contextRU;
        }

        public Receita[] getReceitas()
        {
            return _context.receita.ToArray();
        }
        
        public Receita getReceita(int id)
        {
            return _context.receita.Where(r => r.id_receita == id).FirstOrDefault();
        }

        public void AdicionarReceitaFavorita(ReceitaUtilizador ru)
        {
            _contextReceitaUtilizador.receitaUtilizador.Add(ru);
            _contextReceitaUtilizador.SaveChanges();
        }


    }
}
