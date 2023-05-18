namespace Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Celsius: ");
            int celsius = int.Parse(Console.ReadLine());

            double fahrenheit = (9 * celsius + 160) / 5;
           
            Console.WriteLine($"A temperatura em graus Fahrenheit é: {fahrenheit}°F");
        }
    }
}