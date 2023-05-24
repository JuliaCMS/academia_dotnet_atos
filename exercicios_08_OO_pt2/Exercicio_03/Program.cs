namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 - Crie uma classe Animal com propriedades Nome e Idade. Em seguida, crie as classes Cachorro e Gato que herdam de Animal e adicionam uma propriedade Raca.

            Cachorro cachorro = new Cachorro("Ully", 10, "SRD");
            Gato gato = new Gato("Bartok", 1, "Manchadinho");

            cachorro.MostraDados();
            gato.MostraDados();
        }
    }
}