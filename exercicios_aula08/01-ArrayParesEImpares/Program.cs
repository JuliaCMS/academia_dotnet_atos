namespace _01_ArrayParesEImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

            int[] vetor = new int[10];
            int somaPar = 0;
            int somaImpar = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor para a posição {i + 1} do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    somaPar += 1;
                }
                else
                {
                    somaImpar += 1;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {somaPar}\nQuantidade de números impares: {somaImpar}");
        }
    }
}