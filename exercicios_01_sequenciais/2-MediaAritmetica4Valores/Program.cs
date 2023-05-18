namespace MediaAritmetica4Valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int terceiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o quarto número: ");
            int quartoNumero = int.Parse(Console.ReadLine());

            int media = (primeiroNumero + segundoNumero + terceiroNumero + quartoNumero) / 4;

            Console.WriteLine("A média dos quatro números é: " + media);
        }
    }
}