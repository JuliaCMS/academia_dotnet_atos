using System.Runtime.Intrinsics.X86;

namespace _16_OperacoesVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
            //•	A união de X com Y
            //•	A diferença entre X e Y
            //•	A interseção entre X e Y
            //Escreva o vetor resultado de cada uma das operações.

            // Declara o array x e y e lê os valores
            int[] x = new int[2];
            int[] y = new int[2];
            
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"Digite o {i +1}º valor do vetor X: ");
                x[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");

            for (int i = 0; i < y.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor do vetor Y: ");
                y[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("--------------------------------");

            // mostra os elementos inseridos no vetor X
            Console.WriteLine("Valores inseridos no vetor X:");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"{x[i]} ");
            }
            Console.WriteLine("\n");

            // mostra os elementos inseridos no vetor Y
            Console.WriteLine("Valores inseridos no vetor Y:");
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write($"{y[i]} ");
            }
            Console.WriteLine("\n");

            // Declara o array uniaoXeY e atribui a ele os elementos de X[] e Y[] utilizando o método Concat
            int[] uniaoXeY = x.Concat(y).ToArray();

            Console.WriteLine("A união de X com Y:");
            for (int i = 0; i < uniaoXeY.Length; i++)
            {
                Console.Write($"{uniaoXeY[i]} ");
            }
            Console.WriteLine("\n");

            // Verifica a diferença entre os arrays x e y utilizando o metodo Except e declara o array diferencaXeY unindo as diferenças com o Concat
            int[] temNoX = x.Except(y).ToArray();
            int[] temNoY = y.Except(x).ToArray();
            int[] diferencaXeY = temNoX.Concat(temNoY).ToArray();

            Console.WriteLine("A diferença entre X e Y:");
            for (int i = 0; i < diferencaXeY.Length; i++)
            {
                Console.Write($"{diferencaXeY[i]} ");
            }
            Console.WriteLine("\n");

            // Declara o array intersecaoXeY e atribui a ele os elementos contidos tanto em X[] quanto em Y[] utilizando o método Intersect
            int[] intersecaoXeY = x.Intersect(y).ToArray();

            Console.WriteLine("A interseção entre X e Y:");
            for (int i = 0; i < intersecaoXeY.Length; i++)
            {
                Console.Write($"{intersecaoXeY[i]} \n");
            }

        }
    }
}