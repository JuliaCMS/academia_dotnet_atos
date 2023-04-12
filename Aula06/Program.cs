namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exemplo 6 - Escreva um algoritmo que leia pelo teclado um valor inteiro chamado x, e então mostre na tela todos os
            // números de 0 a 100 que são divisiveis por x. 
            /*

            Console.WriteLine("Digite um valor inteiro: ");
            int x = int.Parse(Console.ReadLine());
                       
            if (x == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            else
            {
                Console.WriteLine($"Os números divisíveis por {x} são:");
                for (int i = 0; i <= 100; i++)
                {
                    if (i % x == 0)
                    {                        
                        Console.WriteLine(i);
                    }
                }
            }

            */














            // Exemplo 7 - Escreva um algoritmo que leia pelo teclado a quantidade de alunos de uma turma, e então, para cada
            // aluno, leia suas 3 notas do semestre e mostre na tela sua média final, e se está aprovado ou não.
            /*
             
            Console.WriteLine("Informe a quantidade de alunos da turma: ");
            int qtdAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1;  i <= qtdAlunos; i++)
            {
                Console.WriteLine($"Informe a primeira nota do aluno {i}");
                double nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Informe a segunda nota do aluno {i}");
                double nota2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Informe a terceira nota do aluno {i}");
                double nota3 = int.Parse(Console.ReadLine());
                double media = (nota1 + nota2 + nota3) / 3;
                         
                if (media >= 7)
                {
                    Console.WriteLine($"O aluno {i} está aprovado!\nMédia: {media:N2} \n");
                }
                else if (media >=3 && media < 7)
                {
                    Console.WriteLine($"O aluno {i} está de recuperação!\nMédia: {media:N2}\n");
                }
                else
                {
                    Console.WriteLine($"O aluno {i} está reprovado!\nMédia: {media:N2}\n");
                }
            }

            */
















            // RESOLUÇÃO EXERCICIO 2 - Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles.
            // Não usar vetor.
            /*
             
            int i, n, maior;
            Console.WriteLine("Digite um valor: ");
            maior = int.Parse(Console.ReadLine());
            for (i = 0; i < 9; i++)
            {
                Console.WriteLine("Digite um valor: ");
                n = int.Parse(Console.ReadLine());
                if (n > maior)
                {
                    maior = n;
                }
            }
            Console.WriteLine("O maior valor digitado foi: " + maior);

            */













            // RESOLUÇÃO EXERCICIO 6 - Escreva um algoritmo que leia o número de alunos de uma  turma e em seguida leia
            // a quantidade de avaliações aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e
            // mostre sua nota final (média das notas das avaliações).
            /*
             
            int alunos, qtdAva, i, j;
            double notaAluno, somaNota = 0, media = 0;
            Console.WriteLine("Digite a quantidade de alunos: ");
            alunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de avaliações: ");
            qtdAva = int.Parse(Console.ReadLine());
            for (i = 0; i < alunos; i++)
            {
                for (j = 0; j < qtdAva; j++)
                {
                    Console.WriteLine("Digite a nota " + (j + 1) + " do aluno " + (i + 1));
                    notaAluno = double.Parse(Console.ReadLine());
                    somaNota += notaAluno;
                }
                media = somaNota / qtdAva;
                Console.WriteLine("A média do aluno " + (i + 1) + " = " + media);
                somaNota = 0;
            }

            */













            // RESOLUÇÃO EXERCICIO 7 - Escreva um programa em C# leia 20 números e que conte a quantidade de números
            // pares e ímpares digitados por um usuário. Apresente o resultado.
            /*

            int n, i, par = 0, impar = 0, zero = 0;
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    zero++;
                }
                else if (n % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine("Foram digitados " + par + " pares");
            Console.WriteLine("E foram digitados " + impar + " ímpares");
            Console.WriteLine("E foram digitados " + zero + " zeros");

            */














            // FOR INFINITO E COMANDO BREAK
            /*
             
            for (; ; )  // FOR INFINITO
            {
                Console.WriteLine("Digite um número (digite 0 para sair): ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Número digitado: {0}", numero);
                }
            }

            Console.WriteLine("Laço for encerrado");

            */









            // COMANDO CONTINUE
            /*
             
            for (; ; )
            {
                Console.WriteLine("Digite um número entre 10 e 20: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 10 ||  numero > 20)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Número digitado: {numero}\n");
                }
                Console.WriteLine("Vamos ao próximo numero: "); // só sera executado se não cair no if - continue interrompe a iteração e vai para a proxima
            }
            
            */








            // EXEMPLO 8 - escreva um algoritmo que leia continuamente pelo teclado o valor de uma variavel inteira chamada op, 
            // e só finalize a execução do programa quando o valor lido para op seja zero.

            //for (; ; )  // for (i = 0; true; i++)
            //{
            //    Console.WriteLine("Digite um número (digite 0 para finalizar): ");
            //    int op = int.Parse(Console.ReadLine());

            //    if (op == 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Numero digitado: " +  op);
            //    }
            //}












            // algoritmo de contagem que pula o numero 3 e finaliza quando o numero for 7
            /*
             
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue; // ele desconsidera abaixo e sobre para o incremento
                }
                if (i == 7)
                {
                    break;
                }
                Console.WriteLine("i vale " + i);
            }

            */













            // EXEMPLO 9 - Escreva um algoritmo que leia pelo teclado o valor de uma variável inteira chamada opcao, porem,
            // o programa só pode seguir sua execução caso o valor de opcao seja entre 1 e 4. Se o valor não for entre 1 e 4,
            // a variavel opcao deverá ser lida novamente pelo teclado
            /*
             
            int opcao = 0;

            for(; ; )  // while (true)
            {
                Console.WriteLine("Digite um numero entre 1 e 4: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao > 4 || opcao < 1)
                {
                    Console.WriteLine("Digite um valor válido entre 1 e 4");
                    continue;
                }
                else
                {
                    Console.WriteLine("Opção " + opcao + " escolhida!");
                    break;
                 }
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Primeira opção!");
                    break;
                case 2:
                    Console.WriteLine("Segunda opção!");
                    break;
                case 3:
                    Console.WriteLine("Terceira opção!");
                    break;
                case 4:
                    Console.WriteLine("Quarta opção!");
                    break;
            }

            */










            //EXEMPLO 10 - media de notas da turma 

            //double media = 0;

            //Console.WriteLine("Cálculo da média de notas da turma em uma avaliação\n");
            //Console.WriteLine("Quantos alunos realizaram a avaliação?");
            //int alunos = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= alunos; i++)
            //{
            //    Console.WriteLine("Digite a nota do aluno {0}", i);
            //    double nota = int.Parse(Console.ReadLine());
            //    media += nota;
            //}
            //media = media / alunos;
            //Console.WriteLine("\nA média final da turma é de: {0}", media);












            // EXEMPLO 11 - for dentro de um for (nested loops)

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine("i: " + i);

            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine("       j: " + j);
            //    }
            //}




            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("i vale: " + i);

                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("       j vale: " + j);

                    for (int k = 1; k <= 3; k++)
                    {
                        Console.WriteLine("                   k vale: "+  k);
                    }
                }
            }
        }
    }
}