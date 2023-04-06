namespace _9_MediaGlicemia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da glicemia em jejum do dia 1:");
            double glicemiaJejum1 = double.Parse(Console.ReadLine());
            if(glicemiaJejum1 < 65)
            {
                Console.WriteLine("Valor abaixo do esperado!\nRisco de hipoglicemia.");
            }
            else if (glicemiaJejum1 > 250)
            {
                Console.WriteLine("Valor acima do esperado!\nRisco de hiperglicemia.");
            }

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Digite o valor da glicemia em jejum do dia 2:");
            double glicemiaJejum2 = double.Parse(Console.ReadLine());
            if (glicemiaJejum2 < 65)
            {
                Console.WriteLine("Valor abaixo do esperado!\nRisco de hipoglicemia.");
            }
            else if (glicemiaJejum2 > 250)
            {
                Console.WriteLine("Valor acima do esperado!\nRisco de hiperglicemia.");
            }

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Digite o valor da glicemia em jejum do dia 3:");
            double glicemiaJejum3 = double.Parse(Console.ReadLine());
            if (glicemiaJejum3 < 65)
            {
                Console.WriteLine("Valor abaixo do esperado!\nRisco de hipoglicemia.");
            }
            else if (glicemiaJejum3 > 250)
            {
                Console.WriteLine("Valor acima do esperado!\nRisco de hiperglicemia.");
            }

            Console.WriteLine("----------------------------------------------------------");

            double mediaGlicemiaJejum = (glicemiaJejum1 + glicemiaJejum2 + glicemiaJejum3) / 3;
            if (mediaGlicemiaJejum < 80)
            {
                Console.WriteLine("É preciso diminuir 2 unidades de insulina.");
            }
            else if (mediaGlicemiaJejum > 150)
            {
                Console.WriteLine("Será necessário adicionar 2 unidades de insulina.");
            }
            else
            {
                Console.WriteLine("Não será necessário alterar a dose de insulina.");
            }
        }
    }
}