namespace TrocaValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.WriteLine($"O primeiro número digitado é: {primeiroNumero}, o segundo número digitado é: {segundoNumero}");

            int aux = primeiroNumero;
            primeiroNumero = segundoNumero;
            segundoNumero = aux;

            Console.WriteLine($"O valor invertido do primeiro número é: {primeiroNumero} e do segundo é: {segundoNumero} ");
        }
    }
}