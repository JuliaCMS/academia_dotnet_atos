namespace MediaAritmetica2valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());  

            int media = (primeiroNumero + segundoNumero) / 2;

            Console.WriteLine("A média dos dois números é: " + media);
        }
    }
}