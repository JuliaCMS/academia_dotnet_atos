namespace _04_DadosMatriz5x5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4) Popule uma matriz 5x5 e informe:
            //-Quantos números são pares
            //- Quantos números são impares
            //- Quantos números são positivos
            //- Quantos números são negativos
            //- Quantos zeros existem!

            int[,] matriz = new int[5, 5];
            Random gerador = new Random();
            int par = 0;
            int impar = 0;
            int negativo = 0;
            int zero = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Insira um valor para a posição [{i}, {j}] da matriz: ");
                    matriz[i, j] = gerador.Next(-50, 50);
                    Console.Write(matriz[i, j]);
                    Console.WriteLine();
                    // conta números pares
                    if (matriz[i, j] % 2 == 0)
                    {
                        par += 1;
                    }
                    // conta números impares
                    else if (matriz[i, j] % 2 != 0)
                    {
                        impar += 1;
                    }
                    // conta números negativos
                    if (matriz[i, j] < 0)
                    {
                        negativo += 1;
                    }
                    // conta números zeros
                    if (matriz[i, j] == 0)
                    {
                        zero += 1;
                    }
                }
            }

            Console.WriteLine("\nMatriz preenchida:");
            // exibe a matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // mostra na tela o resultado
            Console.WriteLine($"\nHá {par} números pares na matriz\nHá {impar} números impares na matriz");
            Console.WriteLine($"Há {negativo} números negativos na matriz\nHá {zero} zeros na matriz");
        }
    }
}