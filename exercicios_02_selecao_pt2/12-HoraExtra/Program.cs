namespace _12_HoraExtra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e
número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo - se que ele ganha
R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento
armazenando - o na variável "extra", caso contrário zerar tal variável.A hora excedente de trabalho vale R$ 20,00.
No final do processamento, exibir o salário total e o salário excedente do operário.*/

            Console.WriteLine("Informe o código do operário: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de horas trabalhadas pelo operário: ");
            int numeroHoras = int.Parse(Console.ReadLine());

            double salarioFuncionario = 10.00 * numeroHoras;
            double extra = 0;

            if (numeroHoras > 50)
            {
                extra = (numeroHoras - 50) * 20.00;
                salarioFuncionario += extra;
                Console.WriteLine($"Salário total do operário de código {codigo}: R${salarioFuncionario:N2}\nO salário excedente foi de: R${extra:N2}");
            }
            else
            {
                Console.WriteLine($"Salário total do operário de código {codigo}: R${salarioFuncionario:N2}\nO salário excedente foi de: R${extra:N2}");
            }
        }
    }
}