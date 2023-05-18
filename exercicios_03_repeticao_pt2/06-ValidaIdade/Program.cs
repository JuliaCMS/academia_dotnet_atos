namespace _06_ValidaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Informe uma idade válida: ");
                int idade = int.Parse(Console.ReadLine());

                if (idade > 0 )
                {
                    Console.WriteLine($"Idade digitada válida!\nIdade: {idade}");
                    break;
                }
                else
                {
                    Console.WriteLine("Idade inválida!");
                }
            }
        }
    }
}