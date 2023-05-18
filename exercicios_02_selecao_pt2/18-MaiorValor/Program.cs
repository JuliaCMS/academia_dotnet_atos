namespace _18_MaiorValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

            Console.WriteLine("Digite o primeiro valor:");
            int primeiroValor = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int segundoValor = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            int terceiroValor = int.Parse(Console.ReadLine());

            if ( primeiroValor > segundoValor && primeiroValor > terceiroValor )
            {
                Console.WriteLine($"O primeiro valor ({primeiroValor}) é o maior!");
            }
            else if (segundoValor > primeiroValor && segundoValor  > terceiroValor )
            {
                Console.WriteLine($"O segundo valor ({segundoValor}) é o maior!");
            }
            else
            {
                Console.WriteLine($"O terceiro valor ({terceiroValor}) é o maior!");
            }
        }
    }
}