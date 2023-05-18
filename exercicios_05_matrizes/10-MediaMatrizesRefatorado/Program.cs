namespace _10_MediaMatrizesRefatorado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida,
            //diga quantos dos elementos lidos estão abaixo, acima e na média.

            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];
            int somaA = 0, somaB = 0;
            int acimaMediaA = 0, abaixoMediaA = 0;
            int acimaMediaB = 0, abaixoMediaB = 0;

            Random gerador = new Random();

            // gera valores para as matrizes A e B e soma os elementos
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrizA[i, j] = gerador.Next(0, 100);
                    matrizB[i, j] = gerador.Next(0, 100);
                    somaA += matrizA[i, j];
                    somaB += matrizB[i, j];
                }
            }

            // calcula a média das matrizes A e B
            double mediaA = (double)somaA / 16;
            double mediaB = (double)somaB / 16;

            // conta quantos elementos estão acima ou abaixo da media
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrizA[i, j] > mediaA)
                    {
                        acimaMediaA++;
                    }
                    else if (matrizA[i, j] < mediaA)
                    {
                        abaixoMediaA++;
                    }

                    if (matrizB[i, j] > mediaB)
                    {
                        acimaMediaB++;
                    }
                    else if (matrizB[i, j] < mediaB)
                    {
                        abaixoMediaB++;
                    }
                }
            }
            // imprime matrizes no console
            Console.WriteLine("Matriz A:");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write(matrizA[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz B:");
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write(matrizB[i, j] + " ");
                }
                Console.WriteLine();
            }

            // imprime resultados no console
            Console.WriteLine($"\nMatriz A: média = {mediaA:N2}, abaixo da média= {abaixoMediaA}, acima da média = {acimaMediaA}");
            Console.WriteLine($"Matriz B: média = {mediaB:N2}, abaixo da média= {abaixoMediaB}, acima da média= {acimaMediaB}");
        }
    }
}