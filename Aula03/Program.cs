namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
 * Encademento de condições (if aninhado)
 * if(condição 1) {
 *      if(condição 2) {
 *              desvio condicional composto (if aninhado)
 *       }
 * }
 */

            /*
             *    OPERADORES LÓGICOS
             *    AND && (E) ambas as sentenças devem ser verdadeiras para ser true
             *    OR || (OU) pelo menos uma sentença deve ser verdadeira para retornar true
             *    NOT  ! (NAO) nega uma sentença
             */

            // ------------------------------------------------------------------------------------------------------------------------------------------

            // EXERCÍCIO: Considere que será concedido um bonus aos trabalhadores de uma empresa, conforme o salário atual do vendedor, descrito abaixo.
            // Desenvolva o algoritmo para ler o salário e calcular o valor em reais do aumento. exibir na tela, o salário atual, o aumento (% e R$) e o novo salário.
            //          salários:                               aumento (%)
            // até 900,00 (inclusive)                       5%
            // de 900 a 1400                                    8%
            // acima de 1400 (inclusive)               10%

            //Console.Write("Informe o salário atual do trabalhador: R$");
            //double salarioAtual = double.Parse(Console.ReadLine());

            //double aumento = 0;
            //int percentualAumento = 0;

            //if (salarioAtual <= 900)
            //{
            //    aumento = salarioAtual * 0.05;
            //    percentualAumento = 5;
            //}
            //else if (salarioAtual <= 1400)
            //{
            //    aumento = salarioAtual * 0.08;
            //    percentualAumento = 8;
            //}
            //else
            //{
            //    aumento = salarioAtual * 0.1;
            //    percentualAumento = 10;
            //}

            //double novoSalario = salarioAtual + aumento;

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine($"Salário atual: R${salarioAtual:N2}");
            //Console.WriteLine($"Aumento: {aumento:N2} ({percentualAumento}%)");
            //Console.WriteLine($"Novo salário: R${novoSalario:N2}");

            // ------------------------------------------------------------------------------------------------------------------------------------------

            // EXERCICIO

            //Console.WriteLine("Digite o lado A do triângulo:");
            //double ladoA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o lado B do triângulo:");
            //double ladoB = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o lado C do triângulo:");
            //double ladoC = double.Parse(Console.ReadLine());

            //if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB) // verifica se é um triângulo
            //{
            //    if (ladoA == ladoB && ladoB == ladoC) // verifica se é equilátero
            //    {
            //        Console.WriteLine("O triângulo é equilátero.");
            //    }
            //    else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC) // verifica se é isósceles
            //    {
            //        Console.WriteLine("O triângulo é isósceles.");
            //    }
            //    else // verifica se é escaleno (todos os lados distintos)
            //    {
            //        Console.WriteLine("O triângulo é escaleno.");
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("Não é um triângulo!");
            //}

            // ------------------------------------------------------------------------------------------------------------------------------------------

            // EXERCICIO

            //Console.Write("Informe a base do triângulo: ");
            //double baseTriangulo = double.Parse(Console.ReadLine());

            //Console.Write("Informe a altura do triângulo: ");
            //double alturaTriangulo = double.Parse(Console.ReadLine());

            //double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            //if(baseTriangulo != 0 && alturaTriangulo != 0)
            //{
            //    Console.WriteLine($"A área do triângulo é: {areaTriangulo}");
            //}
            //else
            //{
            //    Console.WriteLine("Base ou altura invalida!");
            //}

            // ------------------------------------------------------------------------------------------------------------------------------------------

            // EXERCICIO 

            Console.Write("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            double valor3 = double.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor: ");
            double valor4 = double.Parse(Console.ReadLine());

            double media = (valor1 + valor2 + valor3 + valor4) / 4.0;

            Console.WriteLine($"A média dos valores é: {media}");

            if (valor1 > media)
            {
                Console.WriteLine($"O valor {valor1} é maior que a média");
            }

            if (valor2 > media)
            {
                Console.WriteLine($"O valor {valor2} é maior que a média");
            }

            if (valor3 > media)
            {
                Console.WriteLine($"O valor {valor3} é maior que a média");
            }

            if (valor4 > media)
            {
                Console.WriteLine($"O valor {valor4} é maior que a média");
            }
        }
    }
}