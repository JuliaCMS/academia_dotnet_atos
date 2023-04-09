namespace _19_OrdemCrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.
            int[] valores = new int[3];

            Console.WriteLine("Digite o primeiro valor:");
            valores[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            valores[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            valores[2] = int.Parse(Console.ReadLine());

            Array.Sort(valores); // ordena os valores em ordem crescente

            Console.WriteLine("Os valores em ordem crescente são: ");

            foreach (int valor in valores) // percorre o array valores
            {
                Console.Write(valor + " ");
            }
        }
    }
}