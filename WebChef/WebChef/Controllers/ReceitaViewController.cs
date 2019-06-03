using System;
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
                                    ReceitaIngredienteContext contextRI, LocalizacaoContext contextLocalizacao, 
                                    IngredienteLocalizacaoContext contextIngredienteLocalizacao, IngredientePreferidoUtilizadorContext contextIPU,
                                    EmentaSemanalContext contextES)
        {
            //_context = context;
            receitaHandling = new ReceitaHandling(context, contextRU, contextRP, contextPasso, contextAcao, contextIngrediente, 
                                                    contextPassoIngrediente, contextRI, contextLocalizacao, contextIngredienteLocalizacao, contextIPU, contextES);
        }

        public IActionResult getReceitas()
        {
            ViewBag.ingredientes = receitaHandling.getIngredientes();
            Receita[] receitas = receitaHandling.getReceitas();
            return View(receitas);
        }

        [Route("{filtro=string}")]
        public IActionResult getReceitas(string opcao)
        {
            ViewBag.ingredientes = receitaHandling.getIngredientes();
            Receita[] receitas = receitaHandling.getReceitas();
            Receita[] res = new Receita[receitas.Length];
            if (opcao.Equals("1") == true)
            {
                res = receitas.OrderBy(r => r.duracao_prevista).ToArray();
            }
            else if (opcao.Equals("2") == true)
            {
                res = receitas.OrderBy(r => float.Parse(r.informacao_nutricional.Split('|')[0].Split(".")[0].Split(",")[0])).ToArray();
            }
            else if (opcao.Equals("3") == true)
            {
                res = receitas.OrderBy(r => r.nr_pessoas).ToArray();
            }

            return View(res);
        }
        

        public IActionResult getReceitasComIngrediente(int ing)
        {
            ViewBag.ingredientes = receitaHandling.getIngredientes();
            Receita[] receitas = receitaHandling.getReceitasComIngrediente(ing);
            
            return View(receitas);
        }

        public IActionResult getEmentaSemanal()
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            EmentaSemanal[] ementa = receitaHandling.getReceitasEmenta(int.Parse(userID.ToString()));
            ementa.OrderBy(x => x.dia_da_semana);
            return View(ementa);
        }

        public IActionResult getReceitasPorCategoria(string categoria)
        {
            ViewBag.ingredientes = receitaHandling.getIngredientes();
            Receita[] receitas = receitaHandling.getReceitasPorCategoria(categoria);

            return View(receitas);
        }

        public IActionResult SugerirReceitas()
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            Receita[] receitas = receitaHandling.getReceitasSugeridas(int.Parse(userID.ToString()));

            return View(receitas);
        }

        public IActionResult getIngredientes()
        {
            Ingrediente[] ingredientes = receitaHandling.getIngredientes();
            return View(ingredientes);
        }


        public IActionResult getFavoritos()
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            Receita[] receitas = receitaHandling.getReceitasFavoritas(int.Parse(userID.ToString()));

            return View(receitas);
        }

        public IActionResult getHistorico()
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            Receita[] receitas = receitaHandling.getHistorico(int.Parse(userID.ToString()));

            return View(receitas);
        }

        public IActionResult getPreferencias()
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            Ingrediente[] ingredientes = receitaHandling.getPreferencias(int.Parse(userID.ToString()));
            return View(ingredientes);
        }


        [Route("{id=int}")]
        [Authorize]
        public IActionResult getReceita(int id)
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            int user_id = int.Parse(userID.ToString());
            ViewBag.isFavorita = receitaHandling.TemReceitaFavorita(id, user_id);  //User.Identity.Name é o id do utilizador logged in
            ViewBag.isSemanal = receitaHandling.TemReceitaNaEmenta(id, user_id);
            Receita receita = receitaHandling.getReceita(id);
            receita.receitaUtilizador = receitaHandling.getReceitaUtilizador(id, user_id);
            string[] tokens = receita.informacao_nutricional.Split('|');
            receita.energia = tokens[0];
            receita.lipidos = tokens[1];
            receita.saturados = tokens[2];
            receita.hidratosCarbono = tokens[3];
            receita.acucares = tokens[4];
            receita.fibras = tokens[5];
            receita.proteinas = tokens[6];
            receita.sal = tokens[7];
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
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            EmentaSemanal[] es = receitaHandling.getDiasEmenta(id, int.Parse(userID.ToString()));
            return View(es);
        }


        [Route("{id=int}/{text=string}")]    //Quando clica no dia da semana para retirar da ementa
        public IActionResult rmReceitaEmenta(int id, string text)
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            receitaHandling.rmReceitaEmenta(id, int.Parse(userID.ToString()), text);
            return RedirectToAction("getReceita", "ReceitaView");
        }

        [Route("{id=int}/{dia=string}")]    //Quando clica no dia da semana para retirar da ementa
        public IActionResult removeReceitaEmenta(int id, string dia)
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            receitaHandling.rmReceitaEmenta(id, int.Parse(userID.ToString()), dia);
            return RedirectToAction("getEmentaSemanal", "ReceitaView");
        }


        public IActionResult ListaCompras()
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            IngredienteListaCompras[] lista = receitaHandling.calculaListaCompras(int.Parse(userID.ToString()));
            return View(lista);
        }



        [Route("{id=int}/{passo=int}")]
        public IActionResult ConfecionaReceita(int id, int passo)
        {
            
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            receitaHandling.setTimeInicio(id, int.Parse(userID.ToString()));
            Passo[] p = receitaHandling.GetPassos(id);
            if(p.Length == 0)
            {
                return RedirectToAction("ConcluirReceita");
            }
            ViewBag.anterior = passo - 1;
            ViewBag.seguinte = passo + 1;
            ViewBag.tamanho = p.Length;
            ViewBag.id = id;
            ViewBag.passo = passo;
            string timestamp = p[passo - 1].timestamp;
            string link = receitaHandling.getReceita(id).link_ajuda;

            if (link != null && timestamp != null)
            {
                ViewBag.link = link + timestamp;
            }
            else
            {
                ViewBag.link = null;
            }
            
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
            return View();
        }

        [HttpPost]
        public IActionResult RegistarReceita([Bind] Receita receita)
        {
            int idReceita = -1;
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
                idReceita = this.receitaHandling.registarReceita(receita);
                if (idReceita > 0)
                {
                    ModelState.Clear();
                    TempData["Success"] = "Registado com sucesso!\n";
                }
                else
                {
                    TempData["Fail"] = "Não foi possível registar.";
                }
            }
            return RedirectToAction("AdicionarIngredientesReceita", "ReceitaView", new { id = idReceita});
        }


        [HttpGet]
        [Route("{id=int}")]
        public IActionResult AdicionarIngredientesReceita(int id)
        {
            ViewBag.ingredientes = receitaHandling.getIngredientes();
            ModelState.Remove("quantidade");
            return View();
        }


        [HttpPost]
        [Route("{id=int}")]
        public IActionResult AdicionarIngredientesReceita(string submit, int id, [Bind] ReceitaIngrediente ri)
        {
            ri.id_receita = id;
            receitaHandling.addReceitaIngrediente(ri);
            if (submit.Equals("Adicionar Ingrediente"))
            {
                ViewBag.ingredientes = receitaHandling.getIngredientes();
                ModelState.Remove("quantidade");
                return View();
            }
            else
            {
                return RedirectToAction("RegistarPassos", "ReceitaView", new { id = id, passo = 1 });
            }
        }


        [HttpGet]
        [Route("{id=int}/{passo=int}")]
        public IActionResult RegistarPassos(int id, int passo)
        {
            ViewBag.passo = passo;
            ViewBag.acoes = receitaHandling.getAcoes();
            ModelState.Remove("descricao");
            ModelState.Remove("timestamp");
            ModelState.Remove("duracao");
            return View();
        }

        [HttpPost]
        [Route("{id=int}/{passo=int}")]          //passo é o número do passo
        public IActionResult RegistarPassos(string submit, int id, int passo, [Bind] Passo p)
        {
            if (submit.Equals("Adicionar Passo"))
            {
                ViewBag.passo = passo + 1;
                ViewBag.acoes = receitaHandling.getAcoes();
                int idPasso = receitaHandling.registarPasso(p, id, passo);
                ModelState.Remove("descricao");
                ModelState.Remove("timestamp");
                ModelState.Remove("duracao");
                return View();
            }
            else if (submit.Equals("Adicionar Ingredientes ao Passo"))
            {
                ViewBag.acoes = receitaHandling.getAcoes();
                int idPasso = receitaHandling.registarPasso(p, id, passo);
                return RedirectToAction("AdicionarIngredientes", "ReceitaView", new { idPasso = idPasso });
            }
            else
            {
                return RedirectToAction("RegistarReceita", "ReceitaView");
            }
        }


        [HttpGet]
        [Route("{id=int}/{passo=int}/{idPasso=int}")]
        public IActionResult AdicionarIngredientes(int idPasso)
        {
            ViewBag.idPasso = idPasso;
            ViewBag.ingredientes = receitaHandling.getIngredientes();
            ModelState.Remove("quantidade");
            return View();
        }


        [HttpPost]
        [Route("{id=int}/{passo=int}/{idPasso=int}")]
        public IActionResult AdicionarIngredientes(string submit, int passo, int idPasso, [Bind] PassoIngrediente pi)
        {
            if (submit.Equals("Adicionar Ingrediente"))
            {
                pi.id_passo = idPasso;
                receitaHandling.addPassoIngrediente(pi);
                ViewBag.idPasso = idPasso;
                ViewBag.passo = passo + 1;   //quando clica em concluir mete a inserir para o proximo passo
                ViewBag.ingredientes = receitaHandling.getIngredientes();
                ModelState.Remove("quantidade");
                return View();
            }
            else
            {
                return RedirectToAction("RegistarPassos", "ReceitaView", new { passo = passo + 1 });
            }
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

        [Route("{id=int}")]
        public IActionResult IngredienteAPreferido(int id)
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            receitaHandling.IngredienteAPreferido(id, int.Parse(userID.ToString()));
            return RedirectToAction("getIngredientes", "ReceitaView");
        }

        [Route("{id=int}")]
        public IActionResult IngredienteAEvitar(int id)
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            receitaHandling.IngredienteAEvitar(id, int.Parse(userID.ToString()));
            return RedirectToAction("getIngredientes", "ReceitaView");
        }

        [Route("{id=int}")]
        public IActionResult Remover(int id)
        {
            object userID = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            receitaHandling.Remover(id, int.Parse(userID.ToString()));
            return RedirectToAction("getPreferencias", "ReceitaView");
        }


    }
}