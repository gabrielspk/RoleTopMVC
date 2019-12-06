using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : AbstractController
    {   
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Cadastro()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = form["nome"];
                cliente.Senha = form["senha"];
                cliente.Telefone  =  form["telefone"];
                cliente.Email =   form["email"];
                cliente.Cpf_cnpj =   form["cpf"];
                cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;

                clienteRepository.Inserir(cliente);
                return View("Sucesso", new RespostaViewModel("Sucesso")
                {
                    NomeView = "Cadastro",
                    UsuarioNome = ObterUsuarioNomeSession(),
                    UsuarioEmail = ObterUsuarioSession()
                
                });
            
            
            }catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro" , new BaseViewModel()
                {

                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}