namespace _10_SubstituiValorNulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.

            int[] vetor = new int[4];
            int[] substituiNulo = new int[4];

            Console.WriteLine("Digite 20 valores");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Array.Copy(vetor, substituiNulo, vetor.Length);
            /*Array.Copy é um método que permite copiar elementos de um array para outro. O primeiro parâmetro especifica o array de origem, 
             * o segundo parâmetro especifica o array de destino e o terceiro parâmetro especifica o número de elementos a serem copiados.*/

            for (int i = 0; i < substituiNulo.Length; i++)
            {
                if (substituiNulo[i] == 0)
                {
                    substituiNulo[i] = 2;
                }
            }

            Console.WriteLine("Vetor com valores lidos: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"{vetor[i]} ");
            }
                        
            Console.WriteLine("Vetor com valores nulos substituídos por 2: ");
            for (int i = 0; i < substituiNulo.Length; i++)
            {
                Console.WriteLine($"{substituiNulo[i]} ");
            }

        }
    }
}