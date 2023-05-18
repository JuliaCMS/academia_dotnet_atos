namespace _08_OrdemDiretaEInversaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

            int[,] matriz = new int[4, 4];
            Random gerador = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Insira um valor para a posição [{i}, {j}] da matriz: ");
                    matriz[i, j] = gerador.Next(0, 50);
                    Console.Write($"{matriz[i, j]}");
                    Console.WriteLine();
                }
            }

            // impressão da matriz na ordem direta
            Console.WriteLine("\nOrdem direta da matriz (ordem de leitura): ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"[{matriz[i, j]}]\t");
                }
                Console.WriteLine();
            }

            // impressão da matriz na ordem inversa
            Console.WriteLine("\nOrdem inversa da matriz: ");
            for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write($"[{matriz[i, j]}]\t");
                }
                Console.WriteLine();
            }
        }
    }
}