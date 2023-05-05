using System.Runtime.Serialization;

namespace Aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Listas - são coleções com características de vetores dinâmicos
            Exemplos:
                - List
                - LinkedList
                - Hash

            Random gerador = new random();
            int[] vetor = new int [5]
            - [Generate Random Numbers in C#](https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp)

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = gerador.Next(20 , 50);  // faixa de numeros randomicos
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            

            Tipos Estruturados de Dados
                - uma dimensão = VETOR
                - duas dimensões = MATRIZ

            */
















            // 1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna, some 10 aos elementos da 1ª coluna.
            // Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.
            /*
            
            // padrão de preenchimento de matrizes: linha X coluna 
            // 5        15          10   
            // 3         0            0
            // 2         0            0
            // 6         0            0
            // 4         0            0

            // declaração
            int[,] matriz = new int[5, 3];

            // preenchimento das colunas
            for (int linha = 0; linha < 5; linha++)
            {
                Console.Write("Digite um valor para a primeira coluna: ");
                matriz[linha, 0] = int.Parse(Console.ReadLine());
                matriz[linha, 1] = matriz[linha, 0] + 10;
                matriz[linha, 2] = matriz[linha, 0] * 2;
            }

            // saída da resposta
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            */





















            // 2) Solicite ao usuário, preencher uma Matriz 3x3
            /*      Informe ao usuário:
                            *A soma dos elementos de cada linha: 
                                    -Ex: Linha 1: 30
                                            Linha 2: 17
                            * A soma dos elementos de cada coluna
                                    -Ex: Coluna 1: 23
                                            Coluna 2: 36                                    */

            // declara a matriz e lê os valores
            int[,] matriz = new int[3, 3];
            for (int i = 0; i < matriz.GetLength(0); i++) // GetLength(0) obtem o tamanho da primeira dimensão
            {
                for (int j = 0; j < matriz.GetLength(1);  j++) // GetLength(1) obtem o tamanho da segunda dimensão
                {
                    Console.Write($"Informe o valor na posição [{i}, {j}] da matriz: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // mostra os valores inseridos na matriz
            Console.WriteLine("Valores inseridos na matriz: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // soma os elementos de cada linha
            for (int i = 0;i < matriz.GetLength(0);i++)
            {
                int somaLinha = 0;
                for (int j = 0;j < matriz.GetLength(1);j++)
                {
                    somaLinha += matriz[i, j];
                }
            }


        }
    }
}