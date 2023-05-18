namespace Aula17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Console.WriteLine("Olá, estou no meu primeiro programa OO");
            Pessoa p = new Pessoa(); // instanciando um objeto do tipo pessoa (criando uma instância da classe Pessoa)
            Console.WriteLine("Digite o nome da pessoa: "); 
            p.nome = Console.ReadLine(); // aqui estou atribuindo o nome que vem da classe pessoa
            Console.WriteLine("Digite a idade da pessoa: "); 
            p.idade = int.Parse(Console.ReadLine()); // aqui estou atribuindo a idade que vem da classe pessoa

            // abaixo, estou exibindo os dados:
            //Console.WriteLine($"A pessoa instanciada é: {p.nome}\nE tem {p.idade} anos.");

            p.exibeDados(); // chama o método de dentro da classe pessoa

            p = new Pessoa("Astolfo", 43); // altera os dados da pessoa p usando o construtor
            p.exibeDados();

            Pessoa p2 = new Pessoa("Ully", 6); // pega os dados com os parâmetros do construtor
            p2.exibeDados();

            */


            //------------------ EXERCÍCIO 1 ------------------
            /*Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e anoFabricacao. Além disso, na Main crie 2 objetos do tipo Carro e exiba 
             * na tela os valores dos atributos criados. (esses valores devem ser solicitados ao usuário, por linha de execução
             
            Carro carro1 = new Carro();
            Console.WriteLine("Informe a marca do carro 1: ");
            carro1.marca = Console.ReadLine();
            Console.WriteLine("Informe o modelo do carro 1: ");
            carro1.modelo = Console.ReadLine();
            Console.WriteLine("Informe o ano de fabricação do carro 1: ");
            carro1.anoFabricacao = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------");

            Carro carro2 = new Carro();
            Console.WriteLine("Informe a marca do carro 2: ");
            carro2.marca = Console.ReadLine();
            Console.WriteLine("Informe o modelo do carro 2: ");
            carro2.modelo = Console.ReadLine();
            Console.WriteLine("Informe o ano de fabricação do carro 2: ");
            carro2.anoFabricacao = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------");
            carro1.exibeDados();
            Console.WriteLine("------------------------------");
            carro1.exibeDados();
            Console.WriteLine("------------------------------");

            */





            //------------------ EXERCÍCIO 2 ------------------
            /*Crie uma classe chamada Computador que possua 4 atributos: marca, modelo tipo (notebook, netbook, tablet, etc) e preço. Crie 2 objetos onde o 
             * primeiro objeto deverá ser criado através da solicitação dos valores ao usuário por linha de execução. Já os valores do segundo objeto,
             * deverão ser definidos no código-fonte da classe que o criou. Exiba na tela os resultados

            Computador computador1 = new Computador();
            
            Console.WriteLine("Informe a marca do computador 1: ");
            computador1.marca = Console.ReadLine();
            Console.WriteLine("Informe o modelo do computador 1: ");
            computador1.modelo = Console.ReadLine();
            Console.WriteLine("Informe o tipo do computador 1: ");
            computador1.tipo = Console.ReadLine();
            Console.WriteLine("Informe o preço do computador 1: ");
            computador1.preco = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            
            Computador computador2 = new Computador("Acer", "Aspire 5", "Notebook", 2500.00);
            
            Console.WriteLine("------------------------------");
            computador1.exibeDadosComputador();
            Console.WriteLine("------------------------------");
            computador2.exibeDadosComputador();

            */






            //------------------ EXERCÍCIO 3 ------------------
            /* Criar uma classe chamada Pessoa com 2 construtores, um que receba o nome e a idade da pessoa e outro recebendo apenas a idade. Solicite ao 
             * usuário qual dos construtores ele gostaria de utilizar na instanciação da classe. Além de receber parâmetros, os construtores imprimem na tela o 
             * conteúdo dos parâmetros recebidos. 

            Console.WriteLine("Digite [1] para utilizar o construtor com nome e idade\nDigite [2] para utilizar o construtor somente com idade");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome da pessoa: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a idade da pessoa:");
                int idade = int.Parse(Console.ReadLine());

                Pessoa pessoa = new Pessoa(nome, idade);
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite a idade da pessoa:");
                int idade = int.Parse(Console.ReadLine());

                Pessoa pessoa = new Pessoa(idade);
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            */







            //------------------ EXERCÍCIO 4 ------------------
            /* Criar uma classe chamada Aluno com 3 construtores, sendo que o primeiro recebe o nome e a matrícula do aluno, o segundo recebe apenas a
                data de nascimento do aluno e o terceiro construtor recebe o nome do aluno, a data de nascimento e o ano em que o aluno ingressou na faculdade.
                - Crie uma classe principal, com 3 objetos, cada um instanciando a classe com um construtor diferente. 

            Aluno aluno1 = new Aluno("Julia", "SP53878");
            Aluno aluno2 = new Aluno(new DateTime(1996, 11, 23));
            Aluno aluno3 = new Aluno("João Kleber", new DateTime(1957, 08, 02), 2021);

            */





            //------------------ EXERCÍCIO 5 ------------------
            /* Crie uma classe ContaCorrente que obedeça à descrição abaixo: A classe possui o atributo saldo do tipo double e os métodos definirSaldoInicial, depositar 
             * e sacar. O método definirSaldoInicial deve atribuir o valor passado por parâmetro ao atribuito saldo. O método depositar, deve adicionar o valor passado por 
             * parâmetro ao atributo saldo. O método sacar deve reduzir o valor passado por parâmetro do saldo já existente Necessário verificar a condição de o valor do 
             * saldo ser insuficiente para o saque que se deseja fazer. O valor de retorno deve ser true (verdadeiro) quando for possível realizar o saque e false (falso) 
             * quando não for possível */

            ContaCorrente contaCorrente = new ContaCorrente();

            Console.WriteLine("Informe o saldo da conta: ");
            double saldo = double.Parse(Console.ReadLine());
            contaCorrente.definirSaldoInicial(saldo);
            Console.WriteLine("-------------------------");

            Console.WriteLine("Digite [1] para fazer um depósito\nDigite [2] para fazer um saque");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");

            if (opcao == 1)
            {
                Console.WriteLine("Informe o valor que deseja depositar: ");
                double deposito = double.Parse(Console.ReadLine());
                contaCorrente.depositar(deposito);
            }

            if (opcao == 2)
            {
                Console.WriteLine("Informe o valor que deseja sacar: ");
                double saque = double.Parse(Console.ReadLine());
                contaCorrente.sacar(saque);
            }



        }
    }
}