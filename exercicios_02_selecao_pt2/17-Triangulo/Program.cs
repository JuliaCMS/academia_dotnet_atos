namespace _17_Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
            formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
            os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).
            */
            Console.WriteLine("Digite o lado A do triângulo:");
            double ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado B do triângulo:");
            double ladoB = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado C do triângulo:");
            double ladoC = double.Parse(Console.ReadLine());

            if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB) // verifica se é um triângulo
            {
                if (ladoA == ladoB && ladoB == ladoC) // verifica se é equilátero
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC) // verifica se é isósceles
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else // verifica se é escaleno (todos os lados distintos)
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else 
            {
                Console.WriteLine("Não é um triângulo!");
            }
        }
    }
}