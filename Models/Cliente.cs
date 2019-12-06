using System;

namespace RoleTopMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Senha {get;set;}
        public string Telefone {get;set;}
        public string Email {get;set;}
        public string Cpf_cnpj {get;set;}
        public uint TipoUsuario {get;set;}
        

        public Cliente()
        {

        }

        public Cliente(string nome, string senha, string telefone, string email, string cpf_cnpj)
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Telefone = telefone;
            this.Email = email;
            this.Cpf_cnpj = cpf_cnpj;
            
        }       
    }
}