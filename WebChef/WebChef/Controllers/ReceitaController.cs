using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChef.Models;
using WebChef.shared;
using Microsoft.AspNetCore.Mvc;

namespace WebChef.Controllers
{
    [Route("api/[controller]")]
    public class ReceitaController : Controller
    {
        private ReceitaHandling receitaHandling;
        public ReceitaController(ReceitaContext context, ReceitaUtilizadorContext contextRU, ReceitaPassoContext contextRP, PassoContext contextPasso, AcaoContext contextAcao)
        {
            //_context = context;
            receitaHandling = new ReceitaHandling(context, contextRU, contextRP, contextPasso, contextAcao);
        }

        [HttpGet]
        public Receita[] Get()
        {
            return receitaHandling.getReceitas();
        }

    }
}
