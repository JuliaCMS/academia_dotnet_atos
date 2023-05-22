namespace exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             9 - Crie uma classe chamada ContaBancaria que tenha as propriedades NumeroConta, Titular, Saldo e Limite. Crie também
            um método chamado Depositar, que recebe um valor e adiciona ao saldo da conta, e um método Sacar, que recebe um 
            valor e verifica se o saldo é suficiente para a operação.
            */

            ContaBancaria c = new ContaBancaria();

            Console.WriteLine("Bem vindo ao caixa eletrônico!");

            Console.WriteLine("Digite o número da conta: ");
            c.NumeroConta = Console.ReadLine();

            Console.WriteLine("Digite o nome do titular: ");
            c.Titular = Console.ReadLine();

            Console.WriteLine("Digite o limite da conta: ");
            c.Limite = double.Parse(Console.ReadLine());

            Console.Clear();
                       
            while (true)
            {
                int op;
                double valor;

                Console.WriteLine("Digite o número: \n[1] Sacar\n[2] Depositar \n[3] Mostrar dados da conta \n[0] Sair");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("Digite o valor do saque: ");
                    valor = double.Parse(Console.ReadLine());
                    if (c.Sacar(valor))
                        Console.WriteLine("Saque efetuado! Saldo atual: " + c.Saldo);
                    else
                        Console.WriteLine("Saque não efetuado, sem saldo disponível! Saldo atual: " + c.Saldo);
                }
                else if (op == 2)
                {
                    Console.WriteLine("Digite o valor do depósito: ");
                    valor = double.Parse(Console.ReadLine());
                    c.Depositar(valor);
                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Dados da conta: ");
                    Console.WriteLine("Número da conta: " + c.NumeroConta);
                    Console.WriteLine("Titular da conta: " + c.Titular);
                    Console.WriteLine("Limite da conta: " + c.Limite);
                    Console.WriteLine("Saldo da conta: " + c.Saldo);
                }
                else if (op == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Operação inválida!");
                }
            }
        }
    }
}