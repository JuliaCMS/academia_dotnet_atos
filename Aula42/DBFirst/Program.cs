using Microsoft.EntityFrameworkCore;

namespace DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite:\n" +
                "1 para criar uma pessoa\n" +
                "2 para  alterar o nome da pessoa\n" +
                "3 para inserir o email\n" +
                "4 para excluir uma pessoa\n" +
                "5 para consultar TUDO\n" +
                "6 para consultar pelo ID");
            int op = int.Parse(Console.ReadLine());

            DbfirstContext contexto = new DbfirstContext();

            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Insira o nome da pessoa:");
                        Pessoa p = new Pessoa();
                        p.Nome = Console.ReadLine();

                        // modo 1
                        Console.WriteLine("Insira um email:");
                        string emailTemp = Console.ReadLine();
                        p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                Email1 = emailTemp
                            }
                        };

                        // modo 2
                        //Email e = new Email();
                        //Console.WriteLine("Insira um email:");
                        //e.email = Console.ReadLine();
                        //p.emails = new List<Email>();
                        //p.emails.Add(e);

                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();
                        Console.WriteLine("Pessoa inserida com sucesso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa: ");
                        int idPessoa = int.Parse(Console.ReadLine());
                        Pessoa? pAlt = contexto.Pessoas.Find(idPessoa);

                        Console.WriteLine("Informe o nome correto: ");
                        pAlt.Nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlt);
                        contexto.SaveChanges();

                        Console.WriteLine("Nome alterado com sucesso!");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Informe o id da pessoa: ");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Informe o novo email: ");
                        Email e = new Email();
                        e.Email1 = Console.ReadLine();

                        p.Emails.Add(e);

                        contexto.Pessoas.Update(p);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Informe o ID para exclusão: ");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Confirmar a exclusão de " + p.Nome + " e de seus e-mails?");
                        foreach (Email item in p.Emails)
                        {
                            Console.WriteLine("\t" + item.Email1);
                        }

                        Console.WriteLine("1 para sim e 2 para não");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine("Excluído com sucesso!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    List<Pessoa> pessoas = (from Pessoa p in contexto.Pessoas select p).Include(pes => pes.Emails).ToList<Pessoa>();
                    foreach (Pessoa item in pessoas)
                    {
                        Console.WriteLine(item.Id + " - " + item.Nome);

                        foreach (Email itemE in item.Emails)
                        {
                            Console.WriteLine("\t" + itemE.Email1);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 6:
                    Console.WriteLine("Informe o ID da Pessoa:");
                    int idP = int.Parse(Console.ReadLine());

                    //Pessoa pessoa = contexto.Pessoas.Include(p=> p.emails)
                    //    .Where(p => p.id == id).FirstOrDefault();

                    Pessoa pessoa = contexto.Pessoas.Include(p => p.Emails).FirstOrDefault(x => x.Id == idP);

                    Console.WriteLine(pessoa.Id + " - " + pessoa.Nome);

                    foreach (Email item in pessoa.Emails)
                    {
                        Console.WriteLine(item.Email1);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}