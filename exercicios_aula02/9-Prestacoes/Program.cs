namespace Prestacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor da mercadoria: ");
            double valorMercadoria = double.Parse(Console.ReadLine());

            int prestacao = (int)valorMercadoria / 3;
                        
            double entrada = valorMercadoria - (prestacao * 2);

            Console.WriteLine($"Valor de entrada: R${entrada:N2}\nValor das duas prestações: R${prestacao:N2}");
        }
    }
}