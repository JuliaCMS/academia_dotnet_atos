namespace _04_ContaVotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######## CONTAGEM DE VOTOS PARA A PREFEITURA ########\n");

            int contagemJoao = 0;
            int contagemZeca = 0;
            int contagemBranco = 0;

            for (; ; )
            {
                Console.WriteLine("Para qual candidato você deseja atribuir um voto?\nJOAO \nZECA \nBRANCO\n");
                string candidato = Console.ReadLine();
                                
                if ( candidato == "JOAO")
                {
                    contagemJoao += 1;
                }
                else if ( candidato == "ZECA")
                {
                    contagemZeca += 1;
                }
                else if ( candidato == "BRANCO")
                {
                    contagemBranco += 1;
                }
                else
                {
                    Console.WriteLine("Voto inválido!");
                }

                Console.WriteLine("Tecle enter para continuar inserindo votos ou digite \"FIM\" para encerrar");
                string opcao = Console.ReadLine();

                if (opcao == "FIM")
                {
                    Console.WriteLine("\n######## APURAÇÃO DOS VOTOS ########");
                    Console.WriteLine($"O candidato JOAO recebeu {contagemJoao} votos");
                    Console.WriteLine($"O candidato ZECA recebeu {contagemZeca} votos");
                    Console.WriteLine($"Total de votos BRANCOS: {contagemBranco}");
                    break;
                }
            }
        }
    }
}