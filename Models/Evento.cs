using System;
using RoleTopMVC.Database;

namespace RoleTopMVC.Models
{
    public class Evento
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public TipoEvento TipoEvento {get;set;}
        public Convidados Convidados {get;set;}
        public DateTime DataDoEvento {get;set;}
        public uint Status {get;set;}

        public Evento()
        {
            this.Cliente = new Cliente();
            this.TipoEvento = new TipoEvento();
            this.Convidados = new Convidados();
            this.Id = 0;
            this.Status = (uint) StatusEvento.PENDENTE;
            
        }
    }
}