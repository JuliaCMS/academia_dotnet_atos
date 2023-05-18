namespace _02_SomaArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.	Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição,
            // armazenando o resultado em um outro vetor.

            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];
            int[] somaVetores = new int[20];

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

            for (int k = 0; k < somaVetores.Length; k++)
            {
                somaVetores[k] = vetor1[k] + vetor2[k];
                Console.WriteLine($"Valor da posição [{k}] do vetor somaVetores: {somaVetores[k]}");
            }
        }
    }
}