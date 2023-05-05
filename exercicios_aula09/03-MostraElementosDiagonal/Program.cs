namespace _03_MostraElementosDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

            int[,] matriz = new int[4,4];
            Random gerador = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++ )
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Insira um valor para a posição [{i}, {j}] da matriz: ");
                    matriz[i, j] = gerador.Next(0, 50);
                    Console.Write(matriz[i, j]);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Elementos inseridos na diagonal principal: ");
            Console.WriteLine($"{matriz[0,0]}, {matriz[1, 1]}, {matriz[2, 2]}, {matriz[3, 3]}");
        
              
        }
    }
}