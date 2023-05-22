namespace Aula22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Julia Caroline";
            p1.Email = "julia@email.com";
            //Console.WriteLine("Nome: " + p1.Nome);
            //Console.WriteLine("Email: " + p1.Email);
            p1.End = new Endereco();
            p1.End.Rua = "Rua dos Andradas";
            p1.End.Numero = 1614;
            p1.End.Complemento = "Conjunto 1 - UFN";
            //Console.WriteLine("Endereço: \nRua: " + p1.End.Rua);
            //Console.WriteLine("Número: " + p1.End.Numero);
            //Console.WriteLine("Complemento: " + p1.End.Complemento);

            Pessoa p2 = new Pessoa();
            p2.Nome = "Ricardo Frolich";
            p2.Email = "ricardo@email.com";
            p2.End = new Endereco();
            p2.End.Rua = "Rua dos Andradas";
            p1.End.Numero = 1614;
            p1.End.Complemento = "Conjunto 1 - UFN";

            Pessoa p3 = new Pessoa();
            p3.Nome = "Fabricio Londero";
            p2.Email = "fabricio@email.com";
            p2.End = new Endereco();
            p2.End.Rua = "Rua dos Andradas";
            p1.End.Numero = 1614;
            p1.End.Complemento = "Conjunto 1 - UFN";

            List<Pessoa> listaPessoas = new List<Pessoa>();
            listaPessoas.Add(p1);
            listaPessoas.Add(p2);
            listaPessoas.Add(p3);

            foreach(Pessoa pessoa in listaPessoas) // percorrendo a lista listaPessoas
            {
                Console.WriteLine("Nome: " + pessoa.Nome);
                Console.WriteLine("E-mail: " + pessoa.Email);
                Console.WriteLine("Rua: " + pessoa.End.Rua);
                Console.WriteLine("Numero: " + pessoa.End.Numero);
                Console.WriteLine("Complemento: " + pessoa.End.Complemento);
            }

            // Outra forma de lidar com essa lista seria usando o for 
            //for (int i = 0; i < listaPessoas.Count; i++)
            //{
            //    Console.WriteLine("ELemento: " + i + "\nNome: " + listaPessoas[i].Nome);
            //}
        }
    }
}