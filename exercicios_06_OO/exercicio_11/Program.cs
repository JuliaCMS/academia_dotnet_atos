using System.Globalization;

namespace exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             11 - Crie uma classe "Aluno" com os atributos "nome", "nota1", "nota2" e "nota3". Os atributos devem ser privados e
            acessados através de propriedades. Em seguida, crie um método para calcular a média e verificar se o aluno está aprovado 
            ou reprovado (se a nota for maior ou igual a 6, está aprovado, senão está reprovado).
             */

            Aluno aluno1 = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a nota 1 do aluno: ");
            aluno1.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2 do aluno: ");
            aluno1.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3 do aluno: ");
            aluno1.Nota3 = double.Parse(Console.ReadLine());

            aluno1.Media(aluno1.Nota1, aluno1.Nota2, aluno1.Nota3);
        }
    }
}