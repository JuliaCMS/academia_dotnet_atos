﻿namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Criar uma classe Pessoa que contém as propriedades Nome e Idade. Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa.
            // A classe Aluno deve ter uma propriedade adicional Matricula, enquanto a classe Professor deve ter uma propriedade adicional Disciplina.
            // Criar um método Apresentar na classe Pessoa que imprime o nome e a idade da pessoa. Em seguida, criar um método Apresentar na classe
            // Aluno que imprime o nome, a idade e a matrícula do aluno, e um método Apresentar na classe Professor que imprime o nome, a idade e a
            // disciplina do professor.

            Aluno aluno = new Aluno();
            aluno.Nome = "Jessica Farias";
            aluno.Idade = 23;
            aluno.Matricula = "SP-56693";

            Professor professor = new Professor();
            professor.Nome = "Ricardo Frolich";
            professor.Idade = 34;
            professor.Disciplina = "Orientação a Objetos";

            aluno.Apresentar();
            professor.Apresentar();
        }
    }
}