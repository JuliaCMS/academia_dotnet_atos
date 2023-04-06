using System.Drawing;

namespace DistribuicaoOtimaSaque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor do saque:  R$");
            int valorSaque = int.Parse(Console.ReadLine());

            // divisão do valor informado pelo usuário pelo valor de cada nota disponível no caixa e atualização do valor de entrada utilizando o resto da divisão (módulo)
            int notas100 = valorSaque / 100;
            valorSaque %= 100;

            int notas50 = valorSaque / 50;
            valorSaque %= 50;

            int notas20 = valorSaque / 20;
            valorSaque %= 20;

            int notas10 = valorSaque / 10;
            valorSaque %= 10;

            int notas5 = valorSaque / 5;
            valorSaque %= 5;
                       
            int notas2 = valorSaque/2;
            valorSaque %= 2;

            Console.WriteLine($"Notas de R$50,00: {notas50}");
            Console.WriteLine($"Notas de R$20,00: {notas20}" );
            Console.WriteLine($"Notas de R$10,00: {notas10}");
            Console.WriteLine($"Notas de R$5,00: {notas5}");
            Console.WriteLine($"Notas de R$2,00: {notas2}");
        }
    }
}