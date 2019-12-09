using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Database;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class EventoController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        EventoRepository eventoRepository = new EventoRepository();
        TipoEventoRepository tipoEventoRepository = new TipoEventoRepository();
        ConvidadosRepository convidadosRepository = new ConvidadosRepository();

        public IActionResult Evento()
        {
            EventoViewModel evm = new EventoViewModel();
            evm.TipoEvento = tipoEventoRepository.ObterTodos();
            evm.Convidados = convidadosRepository.ObterTodos();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                evm.NomeCliente = nomeUsuarioLogado;
            }
            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                evm.Cliente = clienteLogado;
            }
            evm.NomeView = "Evento";
            evm.UsuarioEmail = usuarioLogado;
            evm.UsuarioNome = nomeUsuarioLogado;

            return View(evm);

        }
        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Evento";
            Evento evento = new Evento();

            var nomeTipoEvento = form["evento"];
            TipoEvento tipoEvento = new TipoEvento();
            tipoEvento.Nome = nomeTipoEvento;
            evento.TipoEvento = tipoEvento;

            var nomeConvidados = form["convidados"];
            Convidados convidados = new Convidados (nomeConvidados);

            Cliente cliente = new Cliente(){
                Email = form["email"],
                Senha = form["senha"],
            };
            evento.Cliente = cliente;

            evento.DataDoEvento = DateTime.Now;

            if(eventoRepository.Inserir(evento))
            {
                return View("Sucesso", new RespostaViewModel(){
                    NomeView = "Evento",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }else{
                return View("Erro", new RespostaViewModel(){
                    NomeView = "Evento",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        
        public IActionResult Aprovar (ulong id)
        {
            var evento = eventoRepository.ObterPor(id);
            evento.Status = (uint) StatusEvento.APROVADO;

            if(eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar o evento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        
        public IActionResult Reprovar (ulong id)
        {
            var evento = eventoRepository.ObterPor(id);
            evento.Status = (uint) StatusEvento.REPROVADO;

            if(eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()

                });
            }
        }
    }
}