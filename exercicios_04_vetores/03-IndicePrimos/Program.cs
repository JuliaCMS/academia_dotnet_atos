﻿namespace _03_IndicePrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3.	Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.

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
        }
    }
}