namespace _05_SomaMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5) Leia duas matrizes 2x3 de números double. Imprima a soma destas duas matrizes.

            double[,] matriz1 = new double[2, 3];
            double[,] matriz2 = new double[2, 3];
            double[,] somaDasMatrizes = new double[2, 3];
            Random gerador = new Random();

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write($"Insira um valor para a posição [{i}, {j}] da primeira matriz: ");
                    matriz1[i, j] = gerador.NextDouble() * 50;
                    Console.Write($"{matriz1[i,j]:N2}");
                    Console.WriteLine();
                }
            }

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.Write($"Insira um valor para a posição [{i}, {j}] da segunda matriz: ");
                    matriz2[i, j] = gerador.NextDouble() * 50;
                    Console.Write($"{matriz2[i, j]:N2}");
                    Console.WriteLine();
                }
            }

            for (int i = 0; i < somaDasMatrizes.GetLength(0); i++)
            {
                for (int j = 0; j < somaDasMatrizes.GetLength(1); j++)
                {
                    somaDasMatrizes[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("\nSoma das matrizes:");
            for (int linha = 0; linha < somaDasMatrizes.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < somaDasMatrizes.GetLength(1); coluna++)
                {
                    Console.Write($"[{linha}, {coluna}] - {somaDasMatrizes[linha, coluna]:N2}\t");
                }
                Console.WriteLine();
            }

        }
    }
}