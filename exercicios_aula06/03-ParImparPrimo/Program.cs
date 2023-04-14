namespace _03_ParImparPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Digite um número (digite 0 para sair): ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }
                else
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine($"O número {numero} é par!");
                    }
                    else
                    {
                        Console.WriteLine($"O número {numero} é impar!");
                    }

                    bool primo = true;
                    for (int i = 2;  i < numero; i++) 
                    {
                        if (numero % i == 0)
                        {
                            primo = false; // se o resto da divisão for igual a 0 o valor de primo será alterado para false
                            break; // vai para a proxima linha de codigo depois do loop
                        }
                    }
                    if (primo) // se primo continuou true o numero é primo
                    {
                        Console.WriteLine($"O número {numero} é primo!\n");
                    }
                    else
                    {
                        Console.WriteLine($"O número {numero} não é primo!\n");
                    }
                }
            }
        }
    }
}