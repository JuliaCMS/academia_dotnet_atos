namespace _07_ParesEImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por um usuário. Apresente o resultado.

            int contagemPares = 0;
            int contagemImpares = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número");
                int n = int.Parse(Console.ReadLine());
                
                if ( n % 2 == 0 )
                {
                    contagemPares += 1;
                }
                else
                {
                    contagemImpares += 1;
                }
            }
           Console.WriteLine("\nNúmeros pares: " + contagemPares + "\nNúmeros impares: " + contagemImpares);
        }
    }
}