namespace _09_PesquisaNumeroNaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
            //Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

            // declaração da matriz
            int[,] matriz = new int[3, 3];

            // instância de Random
            Random gerador = new Random();

            // Gera valores para a matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = gerador.Next(0, 50);
                }
            }

            // impressão da matriz no console
            Console.WriteLine("Matriz: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"[{matriz[i, j]}]\t");
                }
                Console.WriteLine();
            }

            // solicita número ao usuário
            Console.WriteLine("\nQual número você deseja pesquisar na matriz?");
            int numero = int.Parse(Console.ReadLine());

            // pesquisa o número na matriz
            bool existe = false;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        existe = true;
                        break;
                    }
                }
            }

            // imprime mensagem de resultado da pesquisa
            if (existe == true)
            {
                Console.WriteLine($"\nO número {numero} existe na matriz.");
            }
            else
            {
                Console.WriteLine($"\nO número {numero} não existe na matriz.");
            }

        }
    }
}