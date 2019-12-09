using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class EventoRepository : RepositoryBase
    {
        private const string PATH = "Database/Eventos.csv";

        public EventoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Evento evento) {
            var quantidadeEvento = File.ReadAllLines(PATH).Length;
                evento.Id = (ulong) ++quantidadeEvento;
                var linha = new string[] {PrepararEventoCSV(evento)};
                File.AppendAllLines(PATH, linha);
                
                return true;

        }

        public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var eventos = ObterTodos();
            List<Evento> eventosCliente = new List<Evento>();

            foreach (var evento in eventos)
            {
                if(evento.Cliente.Email.Equals(emailCliente))
                {
                    eventosCliente.Add(evento);
                }
            }
            return eventosCliente;

        }
            public List<Evento> ObterTodos() {
                var linhas = File.ReadAllLines(PATH);
                List<Evento> eventos = new List<Evento>();
                foreach (var l in linhas) {
                    Evento evento = new Evento ();
                    
                    evento.Id = ulong.Parse(ExtrairValorDoCampo("id", l));
                    evento.Status = uint.Parse(ExtrairValorDoCampo("status_eventos", l));
                    evento.Cliente.Email = ExtrairValorDoCampo("cliente_email", l);
                    evento.Cliente.Senha = ExtrairValorDoCampo("cliente_senha", l);
                    evento.TipoEvento.Nome = ExtrairValorDoCampo("TipoEvento_nome", l);
                    evento.Convidados.Nome = ExtrairValorDoCampo("Convidados_nome", l);
                    evento.DataDoEvento = DateTime.Parse(ExtrairValorDoCampo("data_evento", l));

                    eventos.Add(evento);
                }
                return eventos;
            }

            public Evento ObterPor(ulong id)
            {
                var eventoTotais = ObterTodos();
                foreach (var evento in eventoTotais)
                {
                    if(id.Equals(evento.Id))
                    {
                        return evento;
                    }
                }
                return null;
            }

            public bool Atualizar(Evento evento)
            {
                var eventosTotais = File.ReadAllLines(PATH);
                var eventoCSV = PrepararEventoCSV(evento);
                var linhaEvento = -1;
                var resultado = false;

                for (int i = 0; i < eventosTotais.Length; i++)
                {
                    var idConvertido = ulong.Parse(ExtrairValorDoCampo("id" , eventosTotais[i]));
                    if(evento.Id.Equals(idConvertido))
                    {
                        linhaEvento = i;
                        resultado = true;
                        break;
                    }
                }

                if(resultado)
                {
                    eventosTotais[linhaEvento] = eventoCSV;
                    File.WriteAllLines(PATH , eventosTotais);
                }

                return resultado;


            }

            private string PrepararEventoCSV(Evento evento)
            {
                Cliente c = evento.Cliente;
                TipoEvento t = evento.TipoEvento;
                Convidados cv = evento.Convidados;

                return $"id={evento.Id};status_eventos={evento.Status};cliente_nome={c.Nome};cliente_email={c.Email};cliente_senha={c.Senha};TipoEvento_nome={t.Nome};Convidados_nome={cv.Nome};data_evento={evento.DataDoEvento}";
            }
    }
}