namespace _14_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
            link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
            do arquivo usando este link (em minutos).
            */
            Console.WriteLine("Informe o tamanho do arquivo para download (MB):");
            double tamanhoArquivo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a velocidade do link (Mbps):");
            double velocidadeInternet = double.Parse(Console.ReadLine());

            double tempoDownloadSegundos = tamanhoArquivo / (velocidadeInternet / 8);

            double tempoDowloadMinutos = tempoDownloadSegundos / 60;

            Console.WriteLine($"Tempo aproximado de download: {tempoDowloadMinutos:N1} minutos.");
        }
    }
}