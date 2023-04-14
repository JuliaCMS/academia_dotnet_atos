using System.Runtime.ConstrainedExecution;

namespace Aula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da
            //multiplicação sucessiva de N por 3 enquanto o produto for menor que 250
            //(N * 3; N * 3 * 3; N * 3 * 3 * 3; etc).
            /*
             
            int n;
            do
            {
                Console.WriteLine("informe um valor menor ou igual a 50");
                n = int.Parse(Console.ReadLine());

            } while (n > 50);

            while (n < 250)//tratar o zero tbm
            {
                n *= 3; //n = n*3;
            }

            Console.WriteLine(n);

            */


























            // VETORES  ||  ARRAY

            // declarações:

            //int[] vetor = new int[3];
            //vetor[0] = int.Parse(Console.ReadLine());

            //int[] vetor2 = { 9, 8, 7 };









            //int[] vetor = new int[3];

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.WriteLine("Informe um valor para a posição " + i + ":");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.WriteLine("O vetor possui na posição " + i + " o valor " + vetor[i]);
            //    Console.WriteLine("vetor[" + i + "] = " + vetor[i]);
            //}




















            // 1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

            /*
            int[] vetor = new int[10];
            int somaPar = 0;
            int somaImpar = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor para a posição {i + 1} do vetor: ");
                vetor[i] = int .Parse( Console.ReadLine() );

                if (vetor[i] % 2 ==0)
                {
                    somaPar += 1;
                }
                else
                {
                    somaImpar += 1;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {somaPar}\nQuantidade de números impares: {somaImpar}");
            */























            // 2.	Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição,
            // armazenando o resultado em um outro vetor.
            /*
            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];
            int[] somaVetores = new int[20];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine($"Digite o valor para a posição [{i}] do primeiro vetor: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < vetor2.Length; j++)
            {
                Console.WriteLine($"Digite o valor para a posição [{j}] do segundo vetor: ");
                vetor2[j] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < somaVetores.Length; k++)
            {
                somaVetores[k] = vetor1[k] + vetor2[k];
                Console.WriteLine($"Valor da posição [{k}] do vetor somaVetores: {somaVetores[k]}");
            }
            */






















            // 3.	Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.
            /*
            int[] vetor = new int[20];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor do indice [{i}] do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("### Índices que possuem valores com números primos: ###");


            for (int i = 0; i < vetor.Length; i++)
            {
                bool numeroPrimo = true;

                // verifica se o número é primo
                for (int j = 2; j < vetor[i]; j++) // inicia a partir do 2 pq todo nº é divisível por 1; j < vetor[i]  vai dividir até o valor na posição i
                {
                    if (vetor[i] % j == 0)
                    {
                        numeroPrimo = false;
                        break;
                    }
                }
                if (numeroPrimo)
                {
                    Console.WriteLine($"Índice {i} contém o número primo {vetor[i]}");
                }
            }
            */



























            // 4- Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
            /*
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] multiplicaVetores = new int[10];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine($"Digite o valor para a posição [{i}] do primeiro vetor: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < vetor2.Length; j++)
            {
                Console.WriteLine($"Digite o valor para a posição [{j}] do segundo vetor: ");
                vetor2[j] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < multiplicaVetores.Length; k++)
            {
                multiplicaVetores[k] = vetor1[k] * vetor2[k];
                Console.WriteLine($"Valor da posição [{k}] do vetor multiplicaVetores: {multiplicaVetores[k]}");
            }
            */



























            // 5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.
            /*
            int[] vetor = new int[80];
            int posicaoMenorElemento = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor para o indice [{i}] do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int menorElemento = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < menorElemento)
                {
                    menorElemento = vetor[i];
                    posicaoMenorElemento = i;
                }
            }

            Console.WriteLine($"O menor elemento é {menorElemento} e está na posição [{posicaoMenorElemento}] do vetor.");
                               
            */






















            //6. Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |
            /*
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite um valor para a posição [{i}] do array: ");
                vetor[i] = int.Parse( Console.ReadLine() );
            }

            Console.Write("O vetor na ordem contrária é: ");

            // inicia na ultima posição do array, sendo length -1 pois o índice do último elemento é n-1.
            // o laço vai iterar até o primeiro elemento (índice "0")
            // por ser na ordem decrescente terá o decremento i-- (de vetor.Length - 1 até 0)
            for (int i = vetor.Length - 1; i >= 0; i--) 
            {
                Console.Write($"{vetor[i]} ");
            }



            // USANDO O MÉTODO Array.Reverse();
            int[] vetor = new int[3];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor para o indice [{i}] do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

           Array.Reverse(vetor);
            for (int i = 0;i < vetor.Length;i++) 
            { 
                Console.Write(vetor[i] + " "); 
            }

            */























            // 7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |
            /*
            int[] vetor = new int[10];

            Console.WriteLine("Digite 10 valores");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números pares:  ");
            for (int i = 0;i < vetor.Length;i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write($"{vetor[i]} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Números impares:  ");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.Write($"{vetor[i]} ");
                }
            }
            */


        }
    }
}
