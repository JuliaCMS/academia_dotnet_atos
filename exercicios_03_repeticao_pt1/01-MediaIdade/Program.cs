namespace _01_MediaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
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