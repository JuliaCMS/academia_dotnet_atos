namespace _02_MaiorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 - Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.

            Console.WriteLine("Informe 10 números");

            int maior = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Informe o {i + 1}º número: ");
                int numero = int.Parse( Console.ReadLine() );
                
                if (numero > maior)
                {
                    maior = numero;
                }
            }
            Console.WriteLine($"O maior número é: {maior}");
        }
    }
}