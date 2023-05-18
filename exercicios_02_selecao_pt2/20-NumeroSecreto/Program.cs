using System.Runtime.Intrinsics.X86;

namespace _20_NumeroSecreto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            //plus: você pode gerar o número de forma randomica(função random c#).

            Console.WriteLine("########### JOGO DE ADIVINHAÇÃO ###########");
            Console.WriteLine("\nVocê tem 3 chances para adivinhar o número secreto!\n(OBS.: é um número inteiro)\n");

            Random instanciandoRandom = new Random(); // instanciando a classe Random
            int numeroSecreto = instanciandoRandom.Next(1, 11); // método .Next() gera um valor inteiro entre 1 e 10

            bool acertou = false; // iniciada como false e será alterada para true caso o usuário acerte o número

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite a sua {i + 1}ª tentativa");
                int tentativa = int.Parse(Console.ReadLine());
                if (tentativa == numeroSecreto)
                {
                    Console.WriteLine($"Você acertou!\nNúmero secreto: {numeroSecreto}");
                    acertou = true;
                    break; // sai do loop caso o usuário acerte o número
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine($"Errou! O número secreto é menor do que o número {tentativa}!\n");
                }
                else
                {
                    Console.WriteLine($"Errou! O número secreto é maior do que o número {tentativa}!\n");
                }
            }

            if (!acertou) // verifica se a variável "acertou" foi alterada para true, caso o usuário não tenha acertado ela permanecerá como false e a mensagem será exibida
            {
                Console.WriteLine($"Você perdeu!\nO número secreto era: {numeroSecreto}!");
            }
        }
    }
}
