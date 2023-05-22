using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02
{
    internal class Aluno
    {
        public string nome;
        public string matricula;
        public string dataNascimento;
        public int anoIngressoFaculdade;

        public Aluno(string nome, string matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public Aluno(string dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        public Aluno(string nome, string dataNascimento, int anoIngressoFaculdade)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.anoIngressoFaculdade = anoIngressoFaculdade;
        }
    }
}
