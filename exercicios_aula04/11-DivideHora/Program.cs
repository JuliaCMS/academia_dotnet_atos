namespace _11_DivideHora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
            //O programa deve exibir se a hora digitada está ou não válida. 
            //Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

            Console.WriteLine("Digite a hora, separando as horas dos minutos com \":\":"); // necessário "escapar" as aspas duplas para o compilador entender que faz parte da string
            string horas = Console.ReadLine();

            string[] partes = horas.Split(':'); // divide a string com o parametro ":", armazenando as partes no array "partes"

            int hora = int.Parse(partes[0]);
            int minutos = int.Parse(partes[1]);

            Console.WriteLine("------------------------------------------------------");

            if (hora >= 0 && hora <= 23 && minutos >= 0 && minutos <= 59)
            {
                Console.WriteLine($"{horas}\nHora válida!");
            }
            else
            {
                Console.WriteLine($"{horas}\nHora inválida!");
            }
        }
    }
}