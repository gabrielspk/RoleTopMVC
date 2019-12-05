using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class TipoEventoRepository
    {
        private const string PATH = "Database/TipoEvento.csv";

        public List<TipoEvento> ObterTodos()
        {
            List<TipoEvento> tipoEvento = new List<TipoEvento>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var linha in linhas)
            {
                TipoEvento t = new TipoEvento();
                string[] dados = linha.Split(";");
                t.Nome = dados[0];
                tipoEvento.Add(t);
            }

            return tipoEvento;
        }
    }
}