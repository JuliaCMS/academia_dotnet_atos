namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      EXERCICIO = calculadora utilizando switch-case

            //Console.WriteLine("Qual operação você deseja realizar?");
            //Console.WriteLine("[+] - SOMA");
            //Console.WriteLine("[-] - SUBTRAÇÃO");
            //Console.WriteLine("[*] - MULTIPLICAÇÃO");
            //Console.WriteLine("[/] - DIVISÃO");
            //char operacao = char.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o primeiro número:");
            //int numero1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo número:");
            //int numero2 = int.Parse(Console.ReadLine());
                                                
            //switch (operacao)
            //{
            //    case '+':
            //        Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2} ");
            //        break;
            //     case '-':
            //        Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2} ");
            //        break;
            //     case '*':
            //        Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2} ");
            //        break;
            //     case '/':
            //        Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
            //        break;
            //     default:
            //        Console.WriteLine("Operção inválida!");
            //        break;
            //}









            // OPERADOR TERNÁRIO (?)
            //int x = 0, i;
            //i = int.Parse(Console.ReadLine());
            //x = (i % 2 == 0) ? x = 1 : x = 2;
            //Console.WriteLine("resultado = " + x);

                        
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(i + " é " + (i % 2 == 0 ? "par" : "impar"));

        }
    }
}