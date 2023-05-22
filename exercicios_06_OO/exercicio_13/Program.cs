namespace exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             13 - Crie uma classe autor. Em seguida, crie uma classe "Livro" com os atributos "titulo" e "autor". O atributo autor, deve ser 
            uma instancia de uma classe Autor. Crie um método para exibir as informações do livro.
             */

            Autor autor1 = new Autor("J. R. R. Tolkien", "Inglaterra");
            Livro livro1 = new Livro("O Senhor dos Aneis", autor1);
            livro1.ExibirInformacoes();
        }
    }
}