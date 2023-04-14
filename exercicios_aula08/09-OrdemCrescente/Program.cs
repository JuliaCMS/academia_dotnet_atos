namespace _09_OrdemCrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.
            
            // --------------------- lógica utilizando o algoritmo de ordenação Bubble Sort --------------------------

            int[] vetor = new int[10];
            // int[] vetorAux = new int[10];  ???

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor do {i + 1}º elemento: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        int aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }

            Console.WriteLine("Vetor ordenado em ordem crescente: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{vetor[i]}] ");
            }

            
            // --------------------- lógica utilizando o o método Array.Sort --------------------------
            /*
            int[] vetor = new int[10];
            
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor do {i + 1}º elemento: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort( vetor );

            Console.WriteLine("Vetor ordenado em ordem crescente: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{vetor[i]}] ");
            }
            */
        }
    }
}