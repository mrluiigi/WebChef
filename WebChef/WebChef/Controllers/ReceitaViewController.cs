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

        public ReceitaViewController(ReceitaContext context, ReceitaUtilizadorContext contextRU, ReceitaPassoContext contextRP, PassoContext contextPasso)
        {
            //_context = context;
            receitaHandling = new ReceitaHandling(context, contextRU, contextRP, contextPasso);
        }

        public IActionResult getReceitas()
        {
            Receita[] receitas = receitaHandling.getReceitas();
            return View(receitas);
        }


        [Route("{id=int}")]
        [Authorize]
        public IActionResult getReceita(int id)
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            ViewBag.isFavorita = receitaHandling.TemReceitaFavorita(id, int.Parse(userID.ToString()));  //User.Identity.Name é o id do utilizador logged in
            ViewBag.isSemanal = receitaHandling.TemReceitaNaEmenta(id, int.Parse(userID.ToString()));
            Receita receita = receitaHandling.getReceita(id);
            return View(receita);
        }

        [Route("{id=int}")]
        public IActionResult AddReceitaSemana(int id)
        {
            Receita r = receitaHandling.getReceita(id);
            return View(r);
        }


        [Route("{id=int}/{text=string}")]
        public IActionResult ReceitaNaEmenta(int id, string text)
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            receitaHandling.addReceitaEmenta(id, int.Parse(userID.ToString()), text);
            return RedirectToAction("getReceita", "ReceitaView");
        }

        [Route("{id=int}/{passo=int}")]
        public IActionResult ConfecionaReceita(int id, int passo)
        {
            Passo p = receitaHandling.GetPasso(id, passo);
            ViewBag.ordem = passo;
            return View(p);
        }
    }
}