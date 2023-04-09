namespace _15_LatasDeTinta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
            da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
            e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
            Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.
            */
            Console.WriteLine("Informe o tamanho em metros quadrados da área a ser pintada:");
            double metrosQuadrados = double.Parse(Console.ReadLine());

            double litros = metrosQuadrados / 3;
            int latasTinta = (int)Math.Ceiling(litros / 18); // função Math.Ceilling arredonda o resultado para cima, caso o valor tenha casas decimais

            double precoLata = 80.00;

            double valorTotal = latasTinta * precoLata;

            Console.WriteLine($"A quantidade de latas necessárias para pintar uma área de {metrosQuadrados} m2 é de: {latasTinta} latas.\nValor total: R${valorTotal:N2}");
        }
    }
}