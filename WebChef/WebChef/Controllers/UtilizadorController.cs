using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChef.Models;
using WebChef.shared;

namespace WebChef.Controllers
{
    [Route("api/[controller]")]
    public class UtilizadorController : Controller
    {
        private UtilizadorHandling utilizadorHandling;


        public UtilizadorController(UtilizadorContext context, ReceitaUtilizadorContext contextRU)
        {
            //_context = context;
            utilizadorHandling = new UtilizadorHandling(context, contextRU);
        }

        [HttpGet]
        [Authorize]
        public Utilizador[] Get()
        {
            return utilizadorHandling.getUtilizadores();
        }
        

    }
}
