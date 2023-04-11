namespace _05_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo para calcular o fatorial de um número.

            Console.WriteLine("DIgite o número que você deseja fatorar: ");
            int n = int.Parse(Console.ReadLine());

            int fatoracao = 1; // iniciada em 1 pq todo numero multiplicado por 0 é igual a 0
            for (int i = n; i >= 1 ; i--)
            {
                fatoracao *= i;
            }

            Console.WriteLine(fatoracao);
        }
    }
}