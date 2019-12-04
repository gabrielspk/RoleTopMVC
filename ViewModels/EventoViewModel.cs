using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class EventoViewModel : BaseViewModel
    {
        public List<TipoEvento> TipoEvento {get;set;}
        public List<Convidados> Convidados {get;set;}
        public Cliente Cliente {get;set;}
        public string NomeCliente {get;set;}

        public EventoViewModel()
        {
            this.TipoEvento = new List<TipoEvento>();
            this.Convidados = new List<Convidados>();
            this.Cliente = new Cliente();
            this.NomeCliente = "Jovem";
        }
    }
}