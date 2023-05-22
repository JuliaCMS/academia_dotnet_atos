namespace exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3 - Crie uma classe ContaCorrente que obedeça à descrição abaixo: A classe possui o atributo saldo do tipo 
            double e os métodos definirSaldoInicial, depositar e sacar. O método definirSaldoInicial deve atribuir o
            valor passado por parâmetro ao atribuito saldo O método depositar, deve adicionar o valor passado por
            parâmetro ao atributo saldo O método sacar deve reduzir o valor passado por parâmetro do saldo já 
            existente Necessário verificar a condição de o valor do saldo ser insuficiente para o saque que se deseja
            fazer. O valor de retorno deve ser true (verdadeiro) quando for possível realizar o saque e false (falso)
            quando não for possível
             */

            ContaCorrente contaCorrente = new ContaCorrente();

            Console.WriteLine("Informe o saldo da conta: ");
            double saldo = double.Parse(Console.ReadLine());
            contaCorrente.DefinirSaldoInicial(saldo);
            Console.WriteLine("-------------------------");

            Console.WriteLine("Digite [1] para fazer um depósito\nDigite [2] para fazer um saque");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");

            if (opcao == 1)
            {
                Console.WriteLine("Informe o valor que deseja depositar: ");
                double deposito = double.Parse(Console.ReadLine());
                contaCorrente.Depositar(deposito);
            }

            if (opcao == 2)
            {
                Console.WriteLine("Informe o valor que deseja sacar: ");
                double saque = double.Parse(Console.ReadLine());
                contaCorrente.Sacar(saque);
            }
        }
    }
}