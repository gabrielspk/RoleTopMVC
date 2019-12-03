using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class ClienteController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();

        [HttpGet]
        public IActionResult Login()
        {
            return View(new BaseViewModel(){
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

            [HttpPost]
            public IActionResult Login (IFormCollection form)
            {
                ViewData["Action"] = "Login";
                try
                {
                    System.Console.WriteLine("==========================================");
                    System.Console.WriteLine(form["email"]);
                    System.Console.WriteLine(form["senha"]);
                    System.Console.WriteLine("==========================================");

                    var usuario = form["email"];
                    var senha = form["senha"];
                    
                    var c = clienteRepository.ObterPor(usuario);

                    if(c != null)
                    {
                        if(c.Senha.Equals(senha))
                        {
                            switch(c.TiposUsuario){
                            case (uint) TiposUsuario.CLIENTE:
                        HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                        HttpContext.Session.SetString(SESSION_CLIENTE_NOME, c.Nome);
                        HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, c.TiposUsuario.ToString());
                        return RedirectToAction("Historico", "Cliente");
                            
                        default:
                        HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                        HttpContext.Session.SetString(SESSION_CLIENTE_NOME, c.Nome);
                        HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, c.TiposUsuario.ToString());
                        return RedirectToAction("Dashboard", "Administrador");
                        }


                    }
                    else
                    {
                        return View("Erro" , new RespostaViewModel("Senha incorreta")
                        {
                            NomeView = "Login"
                        });
                    }

                }
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado.")
                        {
                            NomeView = "Login"
                        });
                }

            }                      
                catch (Exception e)
                {
                    System.Console.WriteLine(e.StackTrace);
                    return View("Erro");
                }
            }

            public IActionResult Logoff()
            {
                HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
                HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
                HttpContext.Session.Clear();
                return RedirectToAction("Index", "Home");
            }
    }
}