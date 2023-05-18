namespace _04_Potencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.

            Console.WriteLine("### Cálculo de potência ###\n");
            Console.WriteLine("Digite a base: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a potência: ");
            int y = int.Parse(Console.ReadLine());

            int potencia = 1;

            for (int i = 1; i <= y; i++)
            {
                potencia = potencia * x;
            }
            Console.WriteLine($"O resultado de {x} elevado a {y} é {potencia.ToString("N0")}"); // "N0" formata o número com separadores de milhar
        }
    }
}