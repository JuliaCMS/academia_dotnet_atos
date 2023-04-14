namespace _08_ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Digite um número inteiro: ");
                double numero = double.Parse(Console.ReadLine());

                if (numero % 1 != 0) // verifica se é um numero inteiro
                {
                    Console.WriteLine("O número digitado não é um inteiro!\n");
                    continue;
                }
                else
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine($"O número {numero} é par!\n");
                    }
                    else
                    {
                        Console.WriteLine($"O número {numero} é impar!\n");
                    }
                    Console.WriteLine("Deseja repetir o programa? [S/N]");
                    string opcao = Console.ReadLine();
                    Console.WriteLine();

                    if (opcao == "S" || opcao == "s")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}