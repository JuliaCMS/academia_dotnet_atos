using static System.Net.Mime.MediaTypeNames;

namespace _1_AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            //Área do triangulo = (base * altura) / 2; Teste se a base ou a altura digitada não foi igual a zero.

            Console.Write("Informe a base do triângulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do triângulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            if (baseTriangulo != 0 && alturaTriangulo != 0)
            {
                Console.WriteLine($"A área do triângulo é: {areaTriangulo}");
            }
            else
            {
                Console.WriteLine("Base ou altura invalida!");
            }
        }
    }
}