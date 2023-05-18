namespace _3_Media4Valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo para ler quatro valores, calcular a sua média, e escrever na tela os que são superiores à média.
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