using System.Runtime.Serialization.Formatters;

namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* RESOLUÇÃO EXERCICIO 15

            double area, qtd, vtotal, qtdlatas, qtdlatasCeiling, qtdlatasFloor;
            Console.WriteLine("Digite a área a ser pintada: ");
            area = double.Parse(Console.ReadLine());
            qtd = area / 3;
            qtdlatas = qtd / 18;
            qtdlatasCeiling = Math.Ceiling(qtdlatas);
            qtdlatasFloor = Math.Floor(qtdlatas);
            Console.WriteLine("A área de " + area + " precisará de " + qtd + " litros de tinta");
            Console.WriteLine("Será necessário comprar " + qtdlatas + " latas de tinha");
            Console.WriteLine("Será necessário comprar " + qtdlatasCeiling + " latas de tinha - Ceiling");
            Console.WriteLine("Será necessário comprar " + qtdlatasFloor + " latas de tinha - Floor");
            vtotal = qtdlatasCeiling * 80;
            Console.WriteLine("Custará " + vtotal);

            */









            /* RESOLUÇÃO EXERCICIO 19

            int n1, n2, n3;
            Console.WriteLine("Digite o N1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o N2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o N3: ");
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                if (n2 < n3)
                {
                    Console.WriteLine("N2 " + n2);
                    Console.WriteLine("N3 " + n3);
                }
                else if (n2 > n3)
                {
                    Console.WriteLine("N3 " + n3);
                    Console.WriteLine("N2 " + n2);
                }
                else
                {
                    Console.WriteLine("N2 e N3 são iguais");
                }
                Console.WriteLine("N1 " + n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                if (n1 < n3)
                {
                    Console.WriteLine("N1 " + n1);
                    Console.WriteLine("N3 " + n3);
                }
                else if (n1 > n3)
                {
                    Console.WriteLine("N3 " + n3);
                    Console.WriteLine("N1 " + n1);
                }
                else
                {
                    Console.WriteLine("N1 e N3 são iguais");
                }
                Console.WriteLine("N2 " + n2);
            }
            else if (n3 > n1 && n3 > n2)
            {
                if (n1 < n2)
                {
                    Console.WriteLine("N1 " + n1);
                    Console.WriteLine("N2 " + n2);
                }
                else if (n1 > n2)
                {
                    Console.WriteLine("N2 " + n2);
                    Console.WriteLine("N1 " + n1);
                }
                else
                {
                    Console.WriteLine("N1 e N2 são iguais");
                }
                Console.WriteLine("N3 " + n3);
            }
            else
            {
                Console.WriteLine("Algum dos valores são iguais");
            }

            */










            // EXERCICIO 1 - ESTRUTURA FOR - mostre na tela os números de 0 a 10

            /*
           for(int i = 0; i <= 10;  i++)
            {
                Console.WriteLine(i);
            }
            */











            // EXERCÍCIO 2 - Escreva um algoritmo que mostre todos os números de 20 a 5.
            /*
            for (int i = 20; i >= 5; i--)
            {
                Console.WriteLine(i);
            }
            */









            // EXERCÍCIO 3 - Escreva um algoritmo leia pelo teclado os dois valores inteiros chamados inicio e fim, e então mostre todos os números entre inicio e fim.
            //Console.WriteLine("Digite um número inteiro que reprente o início: ");
            //int inicio = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um número inteiro que reprente o fim: ");
            //int fim = int.Parse(Console.ReadLine());

            //if (inicio < fim)
            //{
            //    for (int i = inicio + 1; i < fim; i++)
            //    {
            //        Console.WriteLine($"O números entre início e fim são: {i}");
            //    }
            //}
            //else if (inicio > fim)
            //{
            //    for (int i = inicio + 1; i > fim; i--)
            //    {
            //        Console.WriteLine($"O números entre início e fim são: {i}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Os números são iguais");
            //}












            //EXERCICIO 4 - Escreva um algoritmo leia pelo teclado um valor inteiro chamado x, e então mostre na tela todos os números de 0 a 100, pulando de x em x.
            /*
            Console.WriteLine("Digite um valor inteiro: ");
            int x  = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 100;  i += x) // i = i + x    ==     i += x
            {
                Console.WriteLine(i);
            }
            */













            // EXERCICIO 1

            Console.WriteLine("Digite o número de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            int somaIdade = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite a idade da {i + 1}ª pessoa: ");
                int idade = int.Parse(Console.ReadLine());
                somaIdade += idade;
            }

            double mediaIdades = somaIdade / n;
            Console.WriteLine($"A média das idades é de: {mediaIdades:N1}.");
        }
    }
}