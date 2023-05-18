namespace _13_Procura248
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8.
            // O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.

            int[] vetor = new int[20]; // 20 posições pois o exercício pede NO MÁXIMO 100, escolhi 20 :D
            int count2 = 0;
            int count4 = 0;
            int count8 = 0;
            
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro e positivo [-1 para sair]: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == -1)
                {
                    break;
                }

                if (numero == 2)
                {
                    count2++;
                }
                else if (numero == 4)
                {
                    count4++;
                }
                else if (numero == 8)
                {
                    count8++;
                }
            }

            Console.WriteLine($"O número 2 apareceu {count2} vezes.");
            Console.WriteLine($"O número 4 apareceu {count4} vezes.");
            Console.WriteLine($"O número 8 apareceu {count8} vezes.");
        }
    }
}