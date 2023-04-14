namespace _06_OrdemContraria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6. Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |

            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite um valor para a posição [{i}] do array: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("O vetor na ordem contrária é: ");

            // inicia na ultima posição do array, sendo length -1 pois o índice do último elemento é n-1.
            // o laço vai iterar até o primeiro elemento (índice "0")
            // por ser na ordem decrescente terá o decremento i-- (de vetor.Length - 1 até 0)
            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                Console.Write($"{vetor[i]} ");
            }



            // USANDO O MÉTODO Array.Reverse();
            /*
           
            int[] vetor = new int[3];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor para o indice [{i}] do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(vetor);
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            */
        }
    }
}