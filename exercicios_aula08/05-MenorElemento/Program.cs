namespace _05_MenorElemento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

            int[] vetor = new int[80];
            int posicaoMenorElemento = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor para o indice [{i}] do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int menorElemento = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < menorElemento)
                {
                    menorElemento = vetor[i];
                    posicaoMenorElemento = i;
                }
            }

            Console.WriteLine($"O menor elemento é {menorElemento} e está na posição [{posicaoMenorElemento}] do vetor.");
        }
    }
}