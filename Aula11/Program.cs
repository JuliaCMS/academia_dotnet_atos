using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Aula11
{
    internal class Program
    {
        public static void soma(double num1, double num2)
        {
            Console.WriteLine("Aqui eu estou na função soma:");
            double resultado;
            resultado = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {resultado}");
        }

        public static void subtrai(double num1, double num2)
        {
            Console.WriteLine("Aqui eu estou na função subtrai:");
            double resultado;
            resultado = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {resultado}");
        }

        public static double multiplica(double num1, double num2)
        {
            Console.WriteLine("Aqui eu estou na função multiplica:");
            double resultado;
            resultado = num1 * num2;
            return resultado;
        }

        public static double divide(double num1, double num2)
        {
            Console.WriteLine("Aqui eu estou na função divide:");
            double resultado;
            resultado = num1 / num2;
            return resultado;
        }

        public static void verificaPar (double numero)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é impar.");
            }
        }

        /*  
            - outra forma de construir a função:
         
            public static void verificaPar (double numero)
        {
           
        }

        */

        static void Main(string[] args)
        {
            double n1, n2, res;
            Console.WriteLine("Digite dois numeros: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            soma(n1, n2);

            subtrai(n1, n2);

            res = multiplica(n1, n2);
            Console.WriteLine($"{n1} * {n2} = {res}");

            // função divide direto no cw
            Console.WriteLine($"{n1} / {n2} = {divide(n1, n2)}");

            verificaPar(n1);
            verificaPar(n2);

        }
    }
}