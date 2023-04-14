namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Resolução exercicio 01
            /*
            int x = 0;

            for (; x <= 0;)
            {
                Console.WriteLine("Informe um valor positivo:");
                x = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            */

            // SINTAXE WHILE
            /*
            criterio de inicio
            while (condição)
            {

            }
            */

            int x = 0;
             while (x <=  0)
            {
                Console.WriteLine("Informe um valor positivo: ");
                x = int.Parse(Console.ReadLine());
            }

            int soma = 0;
            int contagem = 0;

            for (int i = 1; i < x; i++)
            {
                if ( i % 2 == 0 )
                {
                    Console.Write(i + ", ");
                    contagem++;
                    soma += i; // soma = soma + i;
                }
            }


        }
    }
}