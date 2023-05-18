namespace _05_ContaVotosPt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######## CONTAGEM DE VOTOS PARA A PREFEITURA ########\n");

            int contagemJoao = 0;
            int contagemZeca = 0;
            int contagemBranco = 0;
            int contagemNulos = 0;

            for (; ; )
            {
                Console.WriteLine("Para qual candidato você deseja atribuir um voto?\nJOAO \nZECA \nBRANCO\n");
                string candidato = Console.ReadLine();

                if (candidato == "JOAO")
                {
                    contagemJoao += 1;
                }
                else if (candidato == "ZECA")
                {
                    contagemZeca += 1;
                }
                else if (candidato == "BRANCO")
                {
                    contagemBranco += 1;
                }
                else
                {
                    contagemNulos += 1;
                }

                Console.WriteLine("Tecle enter para continuar inserindo votos ou digite \"FIM\" para encerrar");
                string opcao = Console.ReadLine();

                if (opcao == "FIM")
                {
                    Console.WriteLine("\n######## APURAÇÃO DOS VOTOS ########");
                    Console.WriteLine($"O candidato JOAO recebeu {contagemJoao} votos");
                    Console.WriteLine($"O candidato ZECA recebeu {contagemZeca} votos");
                    Console.WriteLine($"Total de votos BRANCOS: {contagemBranco}");
                    Console.WriteLine($"Total de votos NULOS: {contagemNulos}");
                    Console.WriteLine("Total de pessoas que votaram: " + (contagemJoao + contagemZeca + contagemBranco + contagemNulos));

                    if (contagemJoao > contagemZeca)
                    {
                        Console.WriteLine("Candidato eleito: JOAO");
                    }
                    else if (contagemZeca > contagemJoao)
                    {
                        Console.WriteLine("Candidato eleito: Zeca");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível definir a eleição de um candidato!");
                    }
                    break;
                }
            }
        }
    }
}