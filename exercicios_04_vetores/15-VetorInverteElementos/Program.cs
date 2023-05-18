namespace _15_VetorInverteElementos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 15.	Faça um programa em C# que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor,
            // invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo.
            // Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

            int[] vetorLeitura = new int[20];
            int[] vetorInvertido = new int[20];

            Console.WriteLine("Digite 20 valores inteiros");
            for (int i = 0; i < vetorLeitura.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                vetorLeitura[i] = int.Parse(Console.ReadLine());
            }

            Array.Copy(vetorLeitura, vetorInvertido, vetorLeitura.Length);

            for (int i = 0; i < vetorLeitura.Length;  i++)
            {
                Console.Write($"{vetorLeitura[i]} ");
            }

            Console.WriteLine();

            for (int i = vetorInvertido.Length -1; i >= 0; i--)
            {
                Console.WriteLine($"{vetorInvertido[i]} ");
            }
        }
    }
}