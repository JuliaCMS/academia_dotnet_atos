namespace _06_MaiorValorMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
            //Random random = new Random();
            //int randomNumber = random.Next(0, 100);

            int[,] m = new int[4, 4];
            Random random = new Random();
            int maiorNumero = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = random.Next(0, 9);
                    if (m[i, j] > maiorNumero)
                    {
                        maiorNumero = m[i, j];
                    }
                }
            }

            Console.WriteLine("Matriz M:");
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"[{m[i, j]}]\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"O maior número da matriz é {maiorNumero}!");
        }
    }
}