namespace _14_CodigoNumerico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. Se o código for zero, termine o algoritmo.
            // Se o código for 1, mostre o vetor na ordem em que foi lido. Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

            int codigo;
            int[] vetor = new int[50];

            Console.WriteLine("Digite 50 números para adicionar ao vetor: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("\nDigite o código desejado: \n[0] Finalizar o algoritmo\n[1] Mostrar o vetor na ordem de leitura\n[2] Mostrar o vetor na ordem inversa de leitura");
                codigo = int.Parse(Console.ReadLine());
                              
                switch (codigo)
                {
                    case 0:
                        Console.WriteLine("\nFim do algoritmo.");
                        break;
                    case 1:
                        Console.WriteLine("\nMostrando o vetor na ordem de leitura: ");
                        for (int j = 0; j < vetor.Length; j++)
                        {
                            Console.Write(vetor[j] + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("\nMostrando o vetor na ordem inversa: ");
                        for (int j = vetor.Length - 1; j >= 0; j--)
                        {
                            Console.Write(vetor[j] + " ");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Código inválido. Tente novamente.");
                        break;
                }
            } while (codigo != 0);

        }
    }
}