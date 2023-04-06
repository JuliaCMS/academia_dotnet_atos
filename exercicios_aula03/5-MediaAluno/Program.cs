namespace _5_MediaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            Console.WriteLine("--------------------------------");

            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Digite a nota do exame:");
                double notaExame = double.Parse(Console.ReadLine());
                double mediaFinal = (media + notaExame) / 2;

                Console.WriteLine("--------------------------------");

                if (mediaFinal >= 5)
                {
                    Console.WriteLine("Aluno aprovado!");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado!");
                }
            }
        }
    }
}