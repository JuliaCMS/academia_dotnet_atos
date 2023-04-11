namespace _06_MediaAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações aplicadas para aquela turma.
            // Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final (média das notas das avaliações).
            
            Console.WriteLine("Informe a quantidade de alunos da turma: ");
            int qtdAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de avaliações aplicadas para a turma: ");
            int qtdAvaliacoes = int.Parse(Console.ReadLine());
                        
            for (int i = 1; i <= qtdAlunos; i++)
            {
                double soma = 0;
                for (int j = 1; j <= qtdAvaliacoes; j++)
                {
                    Console.WriteLine($"Informe a nota da avaliação {j} do aluno {i}: ");
                    double nota = double.Parse(Console.ReadLine());
                    soma += nota; 
                }
                double media = soma / qtdAvaliacoes;
                Console.WriteLine("A média do aluno " + (i) + " = " + media);
            }
        }
    }
}