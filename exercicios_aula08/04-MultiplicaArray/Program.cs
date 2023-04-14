namespace _04_MultiplicaArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 - Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] multiplicaVetores = new int[10];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine($"Digite o valor para a posição [{i}] do primeiro vetor: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < vetor2.Length; j++)
            {
                Console.WriteLine($"Digite o valor para a posição [{j}] do segundo vetor: ");
                vetor2[j] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < multiplicaVetores.Length; k++)
            {
                multiplicaVetores[k] = vetor1[k] * vetor2[k];
                Console.WriteLine($"Valor da posição [{k}] do vetor multiplicaVetores: {multiplicaVetores[k]}");
            }
        }
    }
}