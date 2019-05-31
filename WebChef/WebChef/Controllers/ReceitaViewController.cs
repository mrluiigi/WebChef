﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebChef.Models;
using WebChef.shared;

namespace WebChef.Controllers
{

    [Route("[controller]/[action]")]
    public class ReceitaViewController : Controller
    {

        private ReceitaHandling receitaHandling;

        public ReceitaViewController(ReceitaContext context, ReceitaUtilizadorContext contextRU, ReceitaPassoContext contextRP, PassoContext contextPasso, 
                                    AcaoContext contextAcao, IngredienteContext contextIngrediente, PassoIngredienteContext contextPassoIngrediente, 
                                    ReceitaIngredienteContext contextRI, LocalizacaoContext contextLocalizacao, IngredienteLocalizacaoContext contextIngredienteLocalizacao)
        {
            //_context = context;
            receitaHandling = new ReceitaHandling(context, contextRU, contextRP, contextPasso, contextAcao, contextIngrediente, contextPassoIngrediente, contextRI, contextLocalizacao, contextIngredienteLocalizacao);
        }

        public IActionResult getReceitas()
        {
            Receita[] receitas = receitaHandling.getReceitas();
            return View(receitas);
        }
        
        
        public IActionResult getFavoritos()
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            Receita[] receitas = receitaHandling.getReceitasFavoritas(int.Parse(userID.ToString()));

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

            string[] tokens = receita.informacao_nutricional.Split('|');
            receita.energia = float.Parse(tokens[0]);
            receita.lipidos = float.Parse(tokens[1]);
            receita.saturados = float.Parse(tokens[2]);
            receita.hidratosCarbono = float.Parse(tokens[3]);
            receita.acucares = float.Parse(tokens[4]);
            receita.fibras = float.Parse(tokens[5]);
            receita.proteinas = float.Parse(tokens[6]);
            receita.sal = float.Parse(tokens[7]);
            return View(receita);
        }

        [Route("{receita=int}/{id=int}")]
        public IActionResult GetIngrediente(int receita, int id)
        {
            Ingrediente i = receitaHandling.GetIngrediente(id);
            ViewBag.idReceita = receita;
            return View(i);
        }

        [Route("{id=int}")]
        public IActionResult VoltaAReceita(int id)
        {
            return RedirectToAction("getReceita", "ReceitaView");
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

        [Route("{id=int}")]  //Quando é clicado o botão vem para esta action
        public IActionResult RmReceitaSemana(int id)
        {
            ReceitaUtilizador[] ru = receitaHandling.getDiasEmenta(id);
            return View(ru);
        }

        [Route("{id=int}/{text=string}")]    //Quando clica no dia da semana para retirar da ementa
        public IActionResult rmReceitaEmenta(int id, string text)
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            receitaHandling.rmReceitaEmenta(id, int.Parse(userID.ToString()), text);
            return RedirectToAction("getReceita", "ReceitaView");
        }

        [Route("{id=int}/{passo=int}")]
        public IActionResult ConfecionaReceita(int id, int passo)
        {
            
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            receitaHandling.setTimeInicio(id, int.Parse(userID.ToString()));
            Passo[] p = receitaHandling.GetPassos(id);
            ViewBag.anterior = passo - 1;
            ViewBag.seguinte = passo + 1;
            ViewBag.tamanho = p.Length;
            ViewBag.id = id;
            ViewBag.passo = passo;
            string timestamp = p[passo-1].timestamp;
            ViewBag.link = receitaHandling.getReceita(id).link_ajuda + timestamp;
            if(p[passo - 1].duracao != null) {
                ViewBag.duracao = p[passo - 1].duracao;
            }
            

            return View(p);
        }

        [Route("{id=int}")]
        public IActionResult ConcluirReceita(int id)
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            receitaHandling.setDuracao(id, int.Parse(userID.ToString()));
            return RedirectToAction("AvaliarReceita", "ReceitaView");
        }

        [HttpGet]
        [Route("{id=int}")]
        public IActionResult AvaliarReceita(int id)
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            ReceitaUtilizador ru = receitaHandling.getReceitaUtilizador(id, int.Parse(userID.ToString()));

            TimeSpan duracao = (TimeSpan)ru.duracao; 
            ViewBag.duracao = duracao.Hours + ":" + duracao.Minutes + ":" + duracao.Seconds;

            return View();
        }

        [HttpPost]
        [Route("{id=int}")]
        public IActionResult AvaliarReceita([Bind] int id, int classificacao, string avaliacao_dificuldade, string anotacao)
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            receitaHandling.adicionarAvaliacao(id, int.Parse(userID.ToString()), classificacao, avaliacao_dificuldade, anotacao);
            return RedirectToAction("getReceitas", "ReceitaView");
        }


        [HttpGet]
        public IActionResult RegistarReceita()
        {
            var list = new List<SelectListItem>();
            for (var i = 1; i < 31; i++)
                list.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString()});
            ViewBag.list = list;
            return View();
        }

        [HttpPost]
        public IActionResult RegistarReceita([Bind] Receita receita)
        {
            if (ModelState.IsValid)
            {
                receita.imagem = "~/Images/" + receita.imagemFicheiro.FileName;
                using (var stream = new FileStream("wwwroot\\Images\\" + receita.imagemFicheiro.FileName, FileMode.Create))
                {
                    receita.imagemFicheiro.CopyTo(stream);
                }
                receita.duracao_prevista = receita.horas * 60 * 60 + receita.minutos * 60 + receita.segundos;
                receita.informacao_nutricional = receita.energia + "|" +
                                                 receita.lipidos + "|" +
                                                 receita.saturados + "|" +
                                                 receita.hidratosCarbono + "|" +
                                                 receita.acucares + "|" +
                                                 receita.fibras + "|" +
                                                 receita.proteinas + "|" +
                                                 receita.sal + "|";
                bool RegistrationStatus = this.receitaHandling.registarReceita(receita);
                if (RegistrationStatus)
                {
                    ModelState.Clear();
                    TempData["Success"] = "Registado com sucesso!\n";
                }
                else
                {
                    TempData["Fail"] = "Não foi possível registar.";
                }
            }
            return View();
        }


        [HttpGet]
        public IActionResult RegistarIngrediente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistarIngrediente([Bind] Ingrediente i)
        {
            if (ModelState.IsValid)
            {
                i.imagem = "~/Images/" + i.imagemFicheiro.FileName;
                using (var stream = new FileStream("wwwroot\\Images\\" + i.imagemFicheiro.FileName, FileMode.Create))
                {
                    i.imagemFicheiro.CopyTo(stream);
                }
                bool RegistrationStatus = this.receitaHandling.registarIngrediente(i);
                if (RegistrationStatus)
                {
                    ModelState.Clear();
                    TempData["Success"] = "Registado com sucesso!\n";
                }
                else
                {
                    TempData["Fail"] = "Não foi possível registar.";
                }
            }
            return View();
        }


        [HttpPost("UploadFiles")]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count, size, filePath });
        }


        [HttpGet]
        public IActionResult RegistarAcao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistarAcao([Bind] Acao a)
        {

            if (ModelState.IsValid)
            {
                bool RegistrationStatus = this.receitaHandling.registarAcao(a);
                if (RegistrationStatus)
                {
                    ModelState.Clear();
                    TempData["Success"] = "Registado com sucesso!\n";
                }
                else
                {
                    TempData["Fail"] = "Não foi possível registar.";
                }
            }
            return View();
        }





        public IActionResult Favoritos()
        {
            return View();
        }
    }
}