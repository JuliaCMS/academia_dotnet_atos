namespace _10_LeituraDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdPessoas = 50;
            int fem = 0;
            int masc = 0;
            int inf30 = 0;
            int sup60 = 0;
            int somaIdadeMulheres = 0;
            int qtdMulheres = 0;

            for (int i = 1; i <= qtdPessoas; i++)
            {
                Console.WriteLine($"Digite o nome da {i}ª pessoa: ");
                string nome = Console.ReadLine();

                Console.WriteLine($"Digite o sexo da {i}ª pessoa: [F/M]");
                char sexo = char.Parse(Console.ReadLine());
                
                // instruções caso o sexo seja feminino
                if ( sexo == 'F' || sexo == 'f')
                {
                    fem += 1;

                    Console.WriteLine($"Digite a idade da {i}ª pessoa: ");
                    int idade = int.Parse(Console.ReadLine());
                    if (idade < 30)
                    {
                        inf30 += 1;
                    }
                    else if (idade > 60)
                    {
                        sup60 += 1;
                    }
                    somaIdadeMulheres += idade;
                    qtdMulheres += 1;
                }

                // instruções caso o sexo seja masculino
                else if (sexo == 'M' || sexo == 'm')
                {
                    masc += 1;

                    Console.WriteLine($"Digite a idade da {i}ª pessoa: ");
                    int idade = int.Parse(Console.ReadLine());
                    if (idade < 30)
                    {
                        inf30 += 1;
                    }
                    else if (idade > 60)
                    {
                        sup60 += 1;
                    }
                }                
            }
            Console.WriteLine("Número de pessoas do sexo masculino: " + masc);
            Console.WriteLine("Número de pessoas do sexo feminino: " + fem);
            Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + inf30);
            Console.WriteLine("Número de pessoas com idade superior a 60 anos: " + sup60);
            double mediaIdadeMulheres = (double)somaIdadeMulheres / qtdMulheres;
            Console.WriteLine("Média de idade das mulheres: " + mediaIdadeMulheres);
        }
    }
}