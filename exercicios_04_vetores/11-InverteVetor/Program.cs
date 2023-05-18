namespace _11_InverteVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11.	Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

            int[] vetor = new int[5];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}º valor: ");
                vetor[i] = int.Parse( Console.ReadLine() );
            }

            Console.WriteLine($"Elementos inseridos no vetor: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"[{vetor[i]}]");
            }

            Console.WriteLine($"Elementos na ordem inversa: ");
            for (int i = vetor.Length - 1; i >= 0; i--) //vetor.Length - 1 -> tamanho = n-1
            {
                Console.WriteLine($"[{vetor[i]}]");
            }

            // poderia simplesmente ter usado o Array.Reverse( vetor );
        }
    }
}