namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ############ CONVERSÃO DE TIPOS ############

            //int a = 5;
            //int b = 2;

            //double casting = (double)a / (double)b; // CAST EXPLICITO
            //double convert = Convert.ToDouble(a) / Convert.ToDouble(b); // CONVERSÃO COM CLASSE CONVERT


            // ############ EXERCICIO 1 ############

            //Console.Write("Digite o primeiro número: ");
            //int primeiroNumero = int.Parse(Console.ReadLine());

            //Console.Write("Digite o segundo número: ");
            //int segundoNumero = int.Parse(Console.ReadLine());  

            //int media = (primeiroNumero + segundoNumero) / 2;

            //Console.WriteLine("A média dos dois números é: " + media);


            // ############ EXERCICIO 2 ############

            //Console.Write("Digite a temperatura em Celsius: ");
            //int celsius = int.Parse(Console.ReadLine());

            //double fahrenheit = (celsius * 1.8) + 32;

            //Console.WriteLine("A temperatura em Fahrenheit é: " +  fahrenheit);


            // ############ EXERCICIO 3 ############

            Console.Write("Digite o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.WriteLine($"O primeiro número digitado é: {primeiroNumero}, o segundo número digitado é: {segundoNumero}");

            int aux = primeiroNumero; // variavel auxiliar para fazer o "backup" do primeiro numero
            primeiroNumero = segundoNumero;
            segundoNumero = aux;

            Console.WriteLine($"O valor invertido do primeiro número é: {primeiroNumero} e do segundo é: {segundoNumero} ");
        }
    }
}