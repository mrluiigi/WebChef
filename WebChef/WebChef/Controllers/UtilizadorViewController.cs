﻿using System;
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
    public class UtilizadorViewController : Controller
    {

        private UtilizadorHandling utilizadorHandling;
        public UtilizadorViewController(UtilizadorContext context, ReceitaUtilizadorContext contextRU)
        {
            //_context = context;
            utilizadorHandling = new UtilizadorHandling(context, contextRU);
        }


        [HttpGet]
        public IActionResult LoginUtilizador()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginUtilizador([Bind] Utilizador user)
        {
            ModelState.Remove("email");
            ModelState.Remove("password");

            if (ModelState.IsValid)
            {
                var LoginStatus = this.utilizadorHandling.validateUser(user);
                if (LoginStatus)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.email)
                    };
                    ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["UserLoginFailed"] = "Não foi possível iniciar sessão.";
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult RegistarUtilizador()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistarUtilizador([Bind] Utilizador user)
        {
            if (ModelState.IsValid)
            {
                bool RegistrationStatus = this.utilizadorHandling.registarUtilizador(user);
                if (RegistrationStatus)
                {
                    ModelState.Clear();
                    TempData["Success"] = "Registado com sucesso!\n";
                }
                else
                {
                    TempData["Fail"] = "Já existe um utilizador associado a este email.";
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Route("{id=int}")] //talvez seja necessário alterar o receitaUtilizador
        public IActionResult AddReceitaFavoritos(int id)
        {
            int idUtilizador = utilizadorHandling.getUtilizadorLoggedIn(User.Identity.Name);
            ReceitaUtilizador ru = new ReceitaUtilizador(id, idUtilizador, new TimeSpan(), "s", "", "", 3, new DateTime(), "");
            utilizadorHandling.AddReceitaFavorita(ru);
            return RedirectToAction("getReceitas", "ReceitaView");
        }

        [Route("{id=int}")]
        public IActionResult RmReceitaFavoritos(int id)
        {
            int idUtilizador = utilizadorHandling.getUtilizadorLoggedIn(User.Identity.Name);
            utilizadorHandling.RmReceitaFavorita(id, idUtilizador);
            return RedirectToAction("getReceitas", "ReceitaView");
        }

    }
}