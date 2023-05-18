namespace _13_PesoIdeal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
            seu peso ideal, utilizando as seguintes fórmulas:
            Para homens: (72.7 * h) - 58
            Para mulheres: (62.1 * h) - 44.7
            */
            Console.WriteLine("Informe o sexo biológico (F ou M):");
            string sexo = Console.ReadLine();

            Console.WriteLine("Informe a altura (em metros):");
            double h = double.Parse(Console.ReadLine());

            if (sexo == "F" || sexo == "f") 
            {
                double pesoMulheres = (62.1 * h) - 44.7;
                Console.WriteLine($"O peso ideal para mulheres de {h:N2} metros de altura é de: {pesoMulheres:N1}Kg.");
            }
            else if (sexo == "M" || sexo == "m")
            {
                double pesoHomens = (72.7 * h) - 58;
                Console.WriteLine($"O peso ideal para homens de {h:N2} metros de altura é de: {pesoHomens:N1}Kg.");
            }
        }
    }
}