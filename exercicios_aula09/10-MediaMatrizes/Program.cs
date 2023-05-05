namespace _10_MediaMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida,
            //diga quantos dos elementos lidos estão abaixo, acima e na média.

            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];
            int somaMatrizA = 0;
            int somaMatrizB = 0;
            int acimaMedia = 0;
            int abaixoMedia = 0;

                        
            Random gerador = new Random();

            // gera valores para a matriz A
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1);  j++)
                {
                    matrizA[i, j] = gerador.Next(0, 100);
                }
            }

            // soma os elementos da matriz A
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    somaMatrizA += matrizA[i, j];
                }
            }
            // faz a media da matriz A 
            double mediaMatrizA = somaMatrizA / 16;
                        
            // gera valores para a matriz B
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    matrizB[i, j] = gerador.Next(0, 100);
                }
            }

            // soma os elementos da matriz B
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    somaMatrizB += matrizB[i, j];
                }
            }
            // faz a media da matriz B 
            double mediaMatrizB = somaMatrizB / 16;

            // verifica quais elementos estão acima ou abaixo da media
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    if (matrizA[i, j] > mediaMatrizA)
                    {
                        acimaMedia += 1;
                    }
                    else if (matrizA[i, j] < mediaMatrizA)
                    {
                        abaixoMedia += 1;
                    }
                }
            }

            // verifica quais elementos estão acima ou abaixo da media na matriz B
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    if (matrizB[i, j] > mediaMatrizB)
                    {
                        acimaMedia += 1;
                    }
                    else if (matrizB[i, j] < mediaMatrizB)
                    {
                        abaixoMedia += 1;
                    }
                }
            }

            //imprime matrizes na tela
            Console.WriteLine("\nMatriz A:");
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
            //imprime resultados
            Console.WriteLine($"A media dos elementos da matriz A é: {mediaMatrizA}");
            Console.WriteLine($"A media dos elementos da matriz B é: {mediaMatrizB}");
            Console.WriteLine($"Número de elementos acima da media: {acimaMedia}");
            Console.WriteLine($"Número de elementos abaixo da media: {abaixoMedia}");
        }
    }
}