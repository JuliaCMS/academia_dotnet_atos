namespace _07_NovaMatrizSubtracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

            // declaração das matrizes
            int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];
            int[,] matrizC = new int[3, 3];

            // instância da classe Random
            Random gerador = new Random();

            // Gerando valores para a matriz A 
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write($"Insira um valor para a posição [{i}, {j}] da matriz A: ");
                    matrizA[i, j] = gerador.Next(0, 50);
                    Console.Write($"{matrizA[i, j]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            // Gerando valores para a matriz B
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write($"Insira um valor para a posição [{i}, {j}] da matriz B: ");
                    matrizB[i, j] = gerador.Next(0, 50);
                    Console.Write($"{matrizB[i, j]}");
                    Console.WriteLine();
                }
            }

            // Subtração da matriz A pela matriz B para formar a matriz C
            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }

            // impressão da matriz C no console
            Console.WriteLine("\nMatriz C - Subtração da Matriz A pela Matriz B: ");
            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    Console.Write($"[{matrizC[i, j]}]\t");
                }
                Console.WriteLine();
            }

        }
    }
}