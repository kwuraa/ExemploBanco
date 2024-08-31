using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplo_POO.Models;

namespace Exemplo_POO.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
            
        }
        private int NumeroConta { get; set; }
        private decimal Saldo { get; set; }

        public void Sacar(decimal valor)
        {

            if (Saldo >= valor)
            {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor} efetuado com sucesso!!!");
            } 
            else 
            {
                Console.WriteLine("Saldo insuficiente para este valor de saque!");
            }
        }

        public void ExbirSaldo()
        {
            Console.WriteLine($"Saldo Disponivel: {Saldo.ToString("C")}");
        }

    }
}