namespace _07_NomeIdadeSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Informe o seu nome: ");
                string nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome) || nome.Any(char.IsDigit)) 
                {
                    Console.WriteLine("Nome incorreto!");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe a sua idade: ");
                    int idade = int.Parse(Console.ReadLine());

                    if (idade <= 0)
                    {
                        Console.WriteLine("Idade inválida!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Informe o seu salário: ");
                        double salario = double.Parse(Console.ReadLine());

                        if (salario <= 0)
                        {
                            Console.WriteLine("Salário inválido!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nSalário: {salario:N2}");
                            break;
                        }
                    }
                }
            }
        }
    }
}