namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            ############### ESTRUTURA DE CONDIÇÃO IF-ELSE ###############
            if(CONDICAO) {
            instrucoes;
            }
            else {
            instruções;
            }
            */





            /*
            ############### numero par ###############
            Console.WriteLine("Informe um número: ");
            int x = int.Parse(Console.ReadLine());

            if(x  %  2 == 0)
            {
                Console.WriteLine("O número é par!");
            }
           else
           {
               Console.WriteLine("O número é impar!");
            */






            /*############# Numero divisivel por 2, 4, 8 ###############
           
            Console.WriteLine("Informe um número: ");
            int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 2!");
            //}

            //if (x % 4 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 4!");
            //}

            //if (x % 8 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 8!");
            //}

            //necessário criar vários ifs pq todos os numeros pares caíriam direto na primeira condição e os outros blocos não seriam executados
            */






            // EXERCICIO: maior de idade

            //Console.WriteLine("Digite sua idade: ");
            //int idade = int.Parse(Console.ReadLine());

            //if(idade >= 18)
            //{
            //    Console.WriteLine("Maior de idade!");
            //}
            //else
            //{
            //    Console.WriteLine("Menor de idade!");
            //}









            // EXERCICIO: calculadora
            Console.WriteLine("Digite o primeiro valor: ");
            int primeiroValor = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int segundoValor = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação você deseja realizar?");
            Console.WriteLine("Para soma digite: 1");
            Console.WriteLine("Para subtração digite: 2");
            Console.WriteLine("Para multiplicação digite: 3");
            Console.WriteLine("Para divisão digite: 4");
            int operacao = int.Parse(Console.ReadLine());

            double resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = primeiroValor + segundoValor;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;

                case 2:
                    resultado = primeiroValor - segundoValor;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;

                case 3:
                    resultado = primeiroValor * segundoValor;
                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;

                case 4:
                    if (segundoValor != 0)
                    {
                        resultado = primeiroValor / segundoValor;
                        Console.WriteLine("O resultado da divisão é: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Não é possível realizar a divisão por zero.");
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}