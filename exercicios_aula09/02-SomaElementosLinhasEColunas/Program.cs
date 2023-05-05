namespace _02_SomaElementosLinhasEColunas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Solicite ao usuário, preencher uma Matriz 3x3
            /*
                        Informe ao usuário:
                        *A soma dos elementos de cada linha
                                -Ex: Linha 1: 30
                                        Linha 2: 17
                        *A soma dos elementos de cada coluna
                                -Ex: Coluna 1: 23
                                        Coluna 2: 36
            */

            int[,] matriz = new int[2, 3];
            Console.WriteLine(matriz.GetLength(0)); //mostra qtas linhas ha
            Console.WriteLine(matriz.GetLength(1)); //mostra qtas colunas ha

            Console.WriteLine("Preencha a matriz 2x3!!");

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write("Posicao[" + linha + "," + coluna + "]: ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            //exibir a matriz
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            int soma;
            //calcular e mostrar a soma de linha a linha
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                soma = 0;
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    soma = soma + matriz[linha, coluna];
                }
                Console.WriteLine("A soma dos elementos da linha " + linha + ": " + soma);
            }


            //calcular e mostrar a soma de coluna a coluna
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                soma = 0;
                for (int linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    soma = soma + matriz[linha, coluna];
                }
                Console.WriteLine("A soma dos elementos da coluna " + coluna + ": " + soma);
            }
        }
    }
}