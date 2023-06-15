﻿using AulaEntityAtos.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AulaEntityAtos
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

            Contexto contexto = new Contexto();

            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Insira o nome da pessoa:");
                        Pessoa p = new Pessoa();
                        p.nome = Console.ReadLine();

                        // modo 1
                        Console.WriteLine("Insira um email:");
                        string emailTemp = Console.ReadLine();
                        p.emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
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
                        pAlt.nome = Console.ReadLine();

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
                        // modo 1
                        Email e = new Email();
                        e.email = Console.ReadLine();

                        p.emails.Add(e);

                        contexto.Pessoas.Update(p);
                        contexto.SaveChanges();

                        Console.WriteLine("E-mail inserido com sucesso!");

                        // modo 2
                        //string emailTemp = Console.ReadLine();

                        //p.emails.Add(new Email()
                        //{
                        //    email = emailTemp
                        //}
                        //);
                        //contexto.Pessoas.Update(p);
                        //contexto.SaveChanges();
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

                        Console.WriteLine("Confirmar a exclusão de " + p.nome + " e de seus e-mails?");
                        foreach (Email item in p.emails)
                        {
                            Console.WriteLine("\t" + item.email);
                        }

                        Console.WriteLine("1 para sim e 2 para não");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine("Excluído com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Exclusão cancelada.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    List<Pessoa> pessoas = (from Pessoa p in contexto.Pessoas select p).Include(pes => pes.emails).ToList<Pessoa>(); //Linq
                    foreach(Pessoa item in pessoas)
                    {
                        Console.WriteLine(item.id + " - " + item.nome);

                        foreach (Email itemE in item.emails)
                        {
                            Console.WriteLine("\t" + itemE.email);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 6:
                    Console.WriteLine("Informe o ID da Pessoa:");
                    int idP = int.Parse(Console.ReadLine());

                    //Pessoa pessoa = contexto.Pessoas.Include(p=> p.emails).Where(p => p.id == id).FirstOrDefault();
                    
                    Pessoa pessoa = contexto.Pessoas.Include(p => p.emails).FirstOrDefault(x => x.id == idP);

                    Console.WriteLine(pessoa.id + " - " + pessoa.nome);

                    foreach (Email item in pessoa.emails)
                    {
                        Console.WriteLine(item.email);
                    }
                    break;
            default:
                    break;
            }
        }
    }
}