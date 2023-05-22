using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_03
{
    internal class ContaCorrente
    {
        public double saldo;

        public ContaCorrente()
        {

        }

        public void DefinirSaldoInicial(double saldo)
        {
            this.saldo = saldo;
        }

        public void Depositar(double deposito)
        {
            this.saldo += deposito;
            Console.WriteLine($"Saldo atual: R${this.saldo}");
        }

        public bool Sacar(double saque)
        {
            if (this.saldo > saque)
            {
                this.saldo -= saque;
                Console.WriteLine($"Saldo atual: R${this.saldo}");
                return true;
            }
            else
            {
                Console.WriteLine("Você não possui saldo suficiente para o saque ");
                return false;
            }
        }

    }
}
