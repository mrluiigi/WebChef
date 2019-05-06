using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebChef.Models;
using WebChef.shared;

namespace WebChef.Controllers
{

    [Route("[controller]/[action]")]
    public class ReceitaViewController : Controller
    {

        private ReceitaHandling receitaHandling;

        public ReceitaViewController(ReceitaContext context, ReceitaUtilizadorContext contextRU)
        {
            //_context = context;
            receitaHandling = new ReceitaHandling(context, contextRU);
        }

        public IActionResult getReceitas()
        {
            Receita[] receitas = receitaHandling.getReceitas();
            return View(receitas);
        }

        [Route("{id=int}")]
        public IActionResult getReceita(int id)
        {
            Receita receita = receitaHandling.getReceita(id);
            return View(receita);
        }

        public void AdicionarReceitaFavorita(int idReceita)
        {
            // CORRIGIR NESTA PARTE
            // É PRECISO TER O idReceita E idUtilizador
            receitaHandling.AdicionarReceitaFavorita(new ReceitaUtilizador(1, 1, new TimeSpan(), "S", "c", "o", 5, new DateTime(), "note"));

        }

    }
}