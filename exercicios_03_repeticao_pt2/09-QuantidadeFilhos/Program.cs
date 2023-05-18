namespace _09_QuantidadeFilhos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pessoas = 30;
            int contagem0 = 0;
            int contagem1E3 = 0;
            int contagem4E7 = 0;
            int contagem8 = 0;
            
            for (int i = 1; i <= pessoas; i++)
            {
                Console.WriteLine($"Quantos filhos a {i}ª pessoa tem?");
                int filhos = int.Parse( Console.ReadLine() );

                if (filhos == 0)
                {
                    contagem0 += 1;
                }
                else if (filhos >= 1 && filhos <= 3)
                {
                    contagem1E3 += 1;
                }
                else if (filhos >= 4 && filhos <= 7)
                {
                    contagem4E7 += 1;
                }
                else if (filhos >= 8)
                {
                    contagem8 += 1;
                }
            }
            Console.WriteLine($"{contagem0} pessoas não tem filhos");
            Console.WriteLine($"{contagem1E3} pessoas tem entre 1 e 3 filhos");
            Console.WriteLine($"{contagem4E7} pessoas tem entre 4 e 7 filhos");
            Console.WriteLine($"{contagem8} pessoas tem mais de 8 filhos");
        }
    }
}