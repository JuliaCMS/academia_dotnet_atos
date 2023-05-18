namespace _8_Comissao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o código do funcionário: ");
            string codigo = Console.ReadLine();

            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o salário base do funcionário: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas do funcionário: ");
            double totalVendas = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------------");

            double salarioFinal = 0;
            if ( totalVendas > 5000)
            {
                salarioFinal = salarioBase + (totalVendas * 0.1);
                Console.WriteLine($"Código do funcionário: {codigo}");
                Console.WriteLine($"Nome do funcionário: {nome.ToUpper()}");
                Console.WriteLine($"Salário base: R${salarioBase:N2}");
                Console.WriteLine($"Total de vendas realizadas: R${totalVendas:N2}");
                Console.WriteLine($"O funcionário receberá um acréscimo de 10% sobre o total de vendas!");
                Console.WriteLine($"Salário final: R${salarioFinal:N2}");
            }
            else if (totalVendas > 1000)
            {
                salarioFinal = salarioBase + (totalVendas * 0.07);
                Console.WriteLine($"Código do funcionário: {codigo}");
                Console.WriteLine($"Nome do funcionário: {nome.ToUpper()}");
                Console.WriteLine($"Salário base: R${salarioBase:N2}");
                Console.WriteLine($"Total de vendas realizadas: R${totalVendas:N2}");
                Console.WriteLine($"O funcionário receberá um acréscimo de 7% sobre o total de vendas!");
                Console.WriteLine($"Salário final: R${salarioFinal:N2}");
            }
            else if (totalVendas > 500)
            {
                salarioFinal = salarioBase + (totalVendas * 0.05);
                Console.WriteLine($"Código do funcionário: {codigo}");
                Console.WriteLine($"Nome do funcionário: {nome.ToUpper()}");
                Console.WriteLine($"Salário base: R${salarioBase:N2}");
                Console.WriteLine($"Total de vendas realizadas: R${totalVendas:N2}");
                Console.WriteLine($"O funcionário receberá um acréscimo de 5% sobre o total de vendas!");
                Console.WriteLine($"Salário final: R${salarioFinal:N2}");
            }
            else
            {
                Console.WriteLine($"Código do funcionário: {codigo}");
                Console.WriteLine($"Nome do funcionário: {nome.ToUpper()}");
                Console.WriteLine($"Salário base: R${salarioBase:N2}");
                Console.WriteLine($"Total de vendas realizadas: R${totalVendas:N2}");
                Console.WriteLine($"O funcionário não atingiu o valor de vendas necessário para receber acréscimo.");
            }
        }
    }
}