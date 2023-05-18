namespace _01_ValidaPositivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que solicite um número inteiro positivo ao usuário, validando a entrada de dados (informando se ele estiver errado e repetindo
            // a solicitação até que esteja correto). Após, o programa deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

            for (; ; )
            {
                Console.WriteLine("Informe um número positivo e inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 0 )
                {
                    Console.WriteLine("Entrada de número incorreta! ");
                    continue;
                }
                else
                {
                    Console.WriteLine("Numeros pares entre 1 e {0}: ", numero);

                    for (int i = 1; i < numero; i++) 
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                }
            }
        }
    }
}