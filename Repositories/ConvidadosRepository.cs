using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ConvidadosRepository
    {
        private const string PATH = "Database/Convidados.csv";

        public List<Convidados> ObterTodos()
        {
            List<Convidados> convidados = new List<Convidados>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var linha in linhas)
            {
                Convidados c = new Convidados();
                string[] dados = linha.Split(";");
                c.Nome = dados[0];
                convidados.Add(c);
            }

            return convidados;
        }
    }
}