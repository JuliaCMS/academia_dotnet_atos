namespace _21_ConversãoDeMedida
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Digite o número correspondente a unidade de medida de entrada desejada:\n");
            Console.WriteLine("[1] - Metros");
            Console.WriteLine("[2] - Centímetros");
            Console.WriteLine("[3] - Polegadas");
            Console.WriteLine("[4] - Pés");
            int unidadeEntrada = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número correspondente a unidade de medida de saída desejada:\n");
            Console.WriteLine("[1] - Metros");
            Console.WriteLine("[2] - Centímetros");
            Console.WriteLine("[3] - Polegadas");
            Console.WriteLine("[4] - Pés");
            int unidadeSaida = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de entrada a ser convertido:");
            double valorEntrada = int.Parse(Console.ReadLine());

            double valorConvertido = 0;

            switch (unidadeEntrada)
            {
                case 1:
                    switch (unidadeSaida)
                    {
                        case 1: // metros
                            valorConvertido = valorEntrada;
                            break;
                        case 2: // centimetros
                            valorConvertido = valorEntrada * 100;
                            break;
                        case 3: // polegadas
                            valorConvertido = valorEntrada * 39.37;
                            break;
                        case 4: // pés
                            valorConvertido = valorEntrada * 3.281;
                            break;
                    }
                    break;
                case 2:
                    switch (unidadeSaida)
                    {
                        case 1: // metros
                            valorConvertido = valorEntrada / 100;
                            break;
                        case 2: // centimetros
                            valorConvertido = valorEntrada;
                            break;
                        case 3: // polegadas
                            valorConvertido = valorEntrada * 0.3937;
                            break;
                        case 4: // pés
                            valorConvertido = valorEntrada * 0.03281;
                            break;
                    }
                    break;
                    case 3:
                    switch (unidadeSaida)
                    {
                        case 1: // metros
                            valorConvertido = valorEntrada / 39.37;
                            break;
                        case 2: // centimetros
                            valorConvertido = valorEntrada / 0.3937;
                            break;
                        case 3: // polegadas
                            valorConvertido = valorEntrada;
                            break;
                        case 4: // pés
                            valorConvertido = valorEntrada * 0.08333;
                            break;
                    }
                    break;
                    case 4:
                    switch (unidadeSaida)
                    {
                        case 1: // metros
                            valorConvertido = valorEntrada / 3.281;
                            break;
                        case 2: // centimetros
                            valorConvertido = valorEntrada / 0.03281;
                            break;
                        case 3: // polegadas
                            valorConvertido = valorEntrada / 0.08333;
                            break;
                        case 4: // pés
                            valorConvertido = valorEntrada;
                            break;
                    }
                    break;
            }
            Console.WriteLine($"O valor convertido é: {valorConvertido:N2}");
            return 0;
        }
    }
}