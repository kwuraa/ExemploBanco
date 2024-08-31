using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplo_POO.Models;

namespace Exemplo_POO.Models
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private int Idade { get; set; }

        public Pessoa (string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Apresentacao()
        {
            Console.WriteLine($"                       !!! Olá {Nome}, seja Bem Vindo(a) a SuaConta.com !!!");
        }

    }
}