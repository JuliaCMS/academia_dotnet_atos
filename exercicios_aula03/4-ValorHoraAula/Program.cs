
using System.Net;
using System.Security.Claims;

namespace _4_ValorHoraAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
            //Mostrar na tela qual dos professores tem o maior salário total.
            Console.Write("Digite a quantidade de horas/aula dadas pelo professor A: ");
            int horasProfessorA = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor recebido por horas/aula do professor A: ");
            double valorHorasProfessorA = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------------------------------------------");

            Console.Write("Digite a quantidade de horas/aula dadas pelo professor B: ");
            int horasProfessorB = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor recebido por horas/aula do professor B: ");
            double valorHorasProfessorB = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------------------------------------------");

            double salarioProfessorA = (double)horasProfessorA * valorHorasProfessorA;
            double salarioProfessorB = (double)horasProfessorB * valorHorasProfessorB;

            if(salarioProfessorA > salarioProfessorB)
            {
                Console.WriteLine($"O professor A recebe o maior salário. \nSalário total: R${salarioProfessorA:N2}");
            }
            else
            {
                Console.WriteLine($"O professor B recebe o maior salário. \nSalário total: R${salarioProfessorB:N2}");
            }
        }
    }
}