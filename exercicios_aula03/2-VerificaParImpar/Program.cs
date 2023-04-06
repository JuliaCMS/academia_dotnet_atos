namespace _2_VerificaParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par!");
                }
                else
                {
                    Console.WriteLine("O número é impar!");
                }     
        }
    }
}