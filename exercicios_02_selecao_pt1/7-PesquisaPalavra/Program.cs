namespace _7_PesquisaPalavra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine("Qual palavra você deseja pesquisar?");
            string palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine($"A palavra {palavra.ToUpper()} encontra-se na frase: {frase}");
            }
            else
            {
                Console.WriteLine($"A palavra {palavra.ToUpper()} não se encontra na frase: {frase}");
            }
        }
    }
}