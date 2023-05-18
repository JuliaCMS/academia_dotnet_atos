namespace _16_PlacarJogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
            na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
            enfrentar novamente em um novo jogo.
            ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
            ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
            plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.
            */
            Console.WriteLine("########## PLACAR DO PRIMEIRO JOGO ##########");

            Console.WriteLine("Digite a quantidade de gols do time da casa:");
            int golsCasa = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de gols do time de fora:");
            int golsDeFora = int.Parse(Console.ReadLine());

            if (golsDeFora - golsCasa > 2)
            {
                Console.WriteLine("O time de fora já se classificou para a próxima fase.");
            }
            else
            {
                Console.WriteLine("Os dois times se enfrentarão em um novo jogo.");

                Console.WriteLine("\n");
                Console.WriteLine("########## PLACAR DO SEGUNDO JOGO ##########");

                Console.WriteLine("Digite a quantidade de gols do time da casa:");
                int golsCasa2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de gols do time de fora:");
                int golsDeFora2 = int.Parse(Console.ReadLine());

                if (golsCasa + golsCasa2 > golsDeFora + golsDeFora2)
                {
                    Console.WriteLine("O time da casa se classificou para a próxima fase.");
                }
                else if (golsDeFora + golsDeFora2 > golsCasa + golsCasa2)
                {
                    Console.WriteLine("O time de fora se classificou para a próxima fase.");
                }
                else
                {
                    Console.WriteLine("Houve empate e a decisão será feita pelos pênaltis.");
                }
            }
        }
    }
}