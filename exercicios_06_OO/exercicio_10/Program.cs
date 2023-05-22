namespace exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie também um método chamado
            EmitirSom, que imprime na tela o som do animal.
             */

            Animal animal1 = new Animal();

            Console.WriteLine("Digite o nome do animal: ");
            animal1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a espécie do animal: ");
            animal1.Especie = Console.ReadLine();
            Console.WriteLine("Digite a idade do animal: ");
            animal1.Idade = int.Parse(Console.ReadLine());

            animal1.EmitirSom(animal1.Especie);


        }
    }
}