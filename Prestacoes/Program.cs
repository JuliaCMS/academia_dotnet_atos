namespace Prestacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o Valor da Mercadoria: ");
            double valorMercadoria = double.Parse(Console.ReadLine());

            int prestacao = (int)valorMercadoria / 3;
                        
            double entrada = valorMercadoria - (prestacao * 2);

            Console.WriteLine($"Valor de entrada: {entrada:N2}\nValor da prestação: {prestacao:N2}");
        }
    }
}