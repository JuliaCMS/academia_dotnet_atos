namespace _02_ValidaPositivoPt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Modificar o programa anterior para que ao final ele pergunte ao usuário se ele deseja informar um outro número. Caso positivo, o programa deve ser repetido.
            
            for (; ; )
            {
                Console.WriteLine("Informe um número inteiro positivo: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("Entrada inválida!");
                    continue;
                }
                else
                {
                    Console.WriteLine("Números pares entre 1 e {0}", numero);

                    for (int i = 0; i < numero; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    Console.WriteLine("Deseja informar outro número? [S/N]");
                    char opcao = char.Parse(Console.ReadLine());
                    
                    if (opcao == 'N' || opcao == 'n')
                    {
                        Console.WriteLine("Programa encerrado!");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}