namespace _12_BuscaNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor.
            // Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".
                        
            int[] vetor = new int[10];

            Console.WriteLine("Digite 10 valores");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Qual número você deseja verificar se existe no vetor?");
            int procurado = int.Parse(Console.ReadLine());
            bool existeNoVetor = false;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == procurado)
                {
                    existeNoVetor = true;
                    Console.WriteLine($"O número {procurado} foi encontrado na posição [{i}] do vetor! ");
                }
            }

            if ( existeNoVetor == false)
            {
                Console.WriteLine($"O número fornecido: {procurado} não existe no vetor!");
            }


            // -------------- alternativa utilizando o método Contains da classe System.Linq ----------------
            /*
            // adicionar a referência do método ao namespace no início do arquivo (using System.Linq;)

            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Qual número você deseja verificar se existe no vetor?");
            int procurado = int.Parse(Console.ReadLine());

            bool existe = vetor.Contains(numero);
            if (existe)
            {
                Console.WriteLine($"O número {numero} existe no vetor na posição [{i}].");
            }
            else
            {
                Console.WriteLine($"O número {numero} não existe no vetor.");
            }

            */


        }
    }
}