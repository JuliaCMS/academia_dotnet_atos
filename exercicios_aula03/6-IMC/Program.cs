namespace _6_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            double IMC = peso / (altura * altura);

            Console.WriteLine("-------------------------");

            if (IMC <= 18 )
            {
                Console.WriteLine($"Nome: {nome.ToUpper()}\nIMC: {IMC:N2}\nbaixo peso!");
            }
            else if(IMC > 18 && IMC <= 25 ) 
            {
                Console.WriteLine($"Nome: {nome.ToUpper()}\nIMC: {IMC:N2}\nPeso ideal!");
            }
            else if(IMC > 25 && IMC <= 30)
            {
                Console.WriteLine($"Nome: {nome.ToUpper()}\nIMC: {IMC:N2}\nSobrepeso!");
            }
            else if (IMC > 30 && IMC <= 35)
            {
                Console.WriteLine($"Nome: {nome.ToUpper()}\nIMC: {IMC:N2}\nObesidade!");
            }
            else 
            {
                Console.WriteLine($"Nome: {nome.ToUpper()}\nIMC: {IMC:N2}\nObesidade grau sério!");
            }
        }
    }
}