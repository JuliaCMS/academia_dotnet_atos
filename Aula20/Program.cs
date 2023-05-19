namespace Aula20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             --------------- Desafio/Exercício 1: pensando OO -----------------

                Um veículo entra num estacionamento e pode alugar o espaço por horas, dias ou meses. O valor da hora é 5 reais, do dia 50 reais e do mês 350 reais. O administrador do estacionamento pode querer visualizar os veículos presentes na
                garagem ou estacionamento, também pode querer saber os veículos que já passaram pelo estacionamento.
                Contudo, a garagem tem um espaço finito de vagas.

                Em geral, quando um veículo entra no estacionamento, são capturados os seguintes dados/informações:
                    - placa
                    - data de entrada
                    - hora de entrada
                    - cor veículo
                    - marca
                    - modelo

                    - data de saida
                    - hora de saida
                    - valorPago

                Ao final, quando o veículo sai do estacionamento, o manobrista realiza a cobrança, baseado na data e hora de saída em relação a data e hora de entrada.


                Serviços:
                    registrar a entrada do veiculo
                    registrar a saida do veiculo
                    calcular o valor da hospedagem

            ---------------------------------------------------------------------------------------------------------------------------------------

            Veiculo v1 = new Veiculo(); //assumindo que o objeto v1 está sendo instaciado pelo construtor vazio

            //em algum momento do código foi preciso colocar dados no objeto
            v1.placa = "IPL7154";
            v1.cor = "Branco";
            v1.marca = "Fiat";
            v1.modelo = "Palio Adventure";
            Console.WriteLine(v1.dataHoraEntrada);

            Veiculo v2 = new Veiculo("ITT7645", "preta", "fiat", "pulse");

            List<Veiculo> garagem = new List<Veiculo>();

            garagem.Add(v1);
            garagem.Add(v2);


            string placa, cor, marca, modelo;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite placa: ");
                placa = Console.ReadLine();

                Console.Write("Digite cor: ");
                cor = Console.ReadLine();

                Console.Write("Digite marca: ");
                marca = Console.ReadLine();

                Console.Write("Digite modelo: ");
                modelo = Console.ReadLine();

                garagem.Add(new Veiculo(placa, cor, marca, modelo));
            }

            */







            /*
            --------------- Desafio/Exercício 2: pensando OO -----------------
            Uma Unidade de Saúde, ao receber pessoas para consultas, realiza cadastro do paciente (nome, cpf, dataNascimento, email). Feito isso, o paciente cadastrado 
            participa de um processo de triagem (valida dados do paciente, peso, altura, pressão arterial e temperatura). Em cima desses dados o técnico ou enfermeiro 
            colocam a urgência de atendimento (verde, amarelo, vermelho). Feito isso, o paciente é chamado a consulta, em que são guardados:

                        -paciente
                        -triagem
                        -nome e crm do médico
                        -prescrição gerada
                        
            
                        UnidadeSaude

                        Paciente

                        Triagem

                        Consulta

                        ProfissionalSaude

             */

            UnidadeSaude us1 = new UnidadeSaude("Unidade São José", "USJ");

            us1.Responsavel.Nome = "Alexandre de Oliveira Zamberlan";
            us1.Responsavel.Tipo = "enfermEiro";
            us1.Responsavel.RegistroConselho = "TEC123";



            Paciente pac1 = new Paciente("Leandro Lazarin", "9884848848", DateOnly.Parse("08/09/1974"), "laza@ufn.edu.br");

            ProfissionalSaude resp1 = new ProfissionalSaude("Daniela Rodrigues", "Enfermeiro", "Enf1231");


            Triagem t1 = new Triagem(resp1, pac1, 88, 1.88, 122, 38, "amarelo");



        }
    }
}