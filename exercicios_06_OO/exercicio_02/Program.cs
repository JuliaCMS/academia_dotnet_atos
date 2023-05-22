namespace exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 - Criar uma classe chamada Aluno com 3 construtores, sendo que o primeiro recebe o nome e a matrícula
            //do aluno, o segundo recebe apenas a data de nascimento do aluno e o terceiro construtor recebe o nome
            //do aluno, a data de nascimento e o ano em que o aluno ingressou na faculdade.
            //Crie uma classe principal, com 3 objetos, cada um instanciando a classe com um construtor diferente.

            // primeiro construtor
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a matricula: ");
            string matricula = Console.ReadLine();
            Aluno aluno1 = new Aluno(nome, matricula);

            // segundo construtor
            Console.Write("Digite a data de nascimento do aluno (ano/mês/dia): ");
            string dataNascimento = Console.ReadLine();
            Aluno aluno2 = new Aluno(dataNascimento);

            // terceito construtor
            Console.Write("Digite o ano de ingresso na faculdade: ");
            int anoIngressoFaculdade = int.Parse(Console.ReadLine());
            Aluno aluno3 = new Aluno(nome, dataNascimento, anoIngressoFaculdade);


            Console.WriteLine("Nome: " + nome + "\nMatrícula: " + matricula + "\nData de nascimento: " + dataNascimento + "\nAnos de ingresso na faculdade: " + anoIngressoFaculdade);
        }
    }
}