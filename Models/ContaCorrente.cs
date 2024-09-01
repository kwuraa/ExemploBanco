using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplo_POO.Models;

namespace Exemplo_POO.Models
{
    public class ContaCorrente : Conta
    {

        public override void Creditar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($" Saldo Disponivel: {Saldo.ToString("C")}");
        }
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            
        }
        private int NumeroConta { get; set; }

        public void Sacar(decimal valor)
        {

            if (Saldo >= valor)
            {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor.ToString("C")} efetuado com sucesso!!!");
            } 
            else 
            {
                Console.WriteLine("Saldo insuficiente para este valor de saque!");
            }
        }

    }
}