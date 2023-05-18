namespace _10_Atletas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do atleta 1");
            Console.Write("Nome: ");
            string nomeAtleta1 = Console.ReadLine();
            Console.Write("Idade: ");
            int idadeAtleta1 = int.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double alturaAtleta1 = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------");

            Console.WriteLine("Dados do atleta 2");
            Console.Write("Nome: ");
            string nomeAtleta2 = Console.ReadLine();
            Console.Write("Idade: ");
            int idadeAtleta2 = int.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double alturaAtleta2 = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------");

            Console.WriteLine("Dados do atleta mais novo:");
            bool atletaMaisNovo = idadeAtleta1 < idadeAtleta2;

            if (atletaMaisNovo == true) 
            {
                Console.WriteLine($"NOME: {nomeAtleta1.ToUpper()}\nIDADE: {idadeAtleta1}\nALTURA: {alturaAtleta1}");
            }
            else if (atletaMaisNovo == false)
            {
                Console.WriteLine($"NOME: {nomeAtleta2.ToUpper()}\nIDADE: {idadeAtleta2}\nALTURA: {alturaAtleta2}");
            }
            else
            {
                Console.WriteLine("Os dois jogadores possuem a mesma idade.");
            }

            Console.WriteLine("--------------------------");

            Console.WriteLine("Dados do atleta mais alto:");
            bool atletaMaisAlto = alturaAtleta1 > alturaAtleta2;

            if (atletaMaisAlto == true)
            {
                Console.WriteLine($"NOME: {nomeAtleta1.ToUpper()}\nIDADE: {idadeAtleta1}\nALTURA: {alturaAtleta1}");
            }
            else if (atletaMaisAlto == false)
            {
                Console.WriteLine($"NOME: {nomeAtleta2.ToUpper()}\nIDADE: {idadeAtleta2}\nALTURA: {alturaAtleta2}");
            }
            else
            {
                Console.WriteLine("Os dois jogadores possuem a mesma altura.");
            }
        }
    }
}