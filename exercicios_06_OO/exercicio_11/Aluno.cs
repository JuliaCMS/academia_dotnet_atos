using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace exercicio_11
{
    internal class Aluno
    {
        private string _nome;
        private double _nota1;
        private double _nota2;
        private double _nota3;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double Nota1
        {
            get { return _nota1; }
            set { _nota1 = value; }
        }

        public double Nota2
        {
            get { return _nota2; }
            set { _nota2 = value; }
        }

        public double Nota3
        {
            get { return _nota3; }
            set { _nota3 = value; }
        }

        public void Media(double nota1, double nota2, double nota3)
        {
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;

            double calculoMedia = (Nota1 + Nota2 + nota3) / 3;

            if (calculoMedia >= 6)
            {
                Console.WriteLine($"\nO aluno {_nome} está aprovado!\nMédia: " + calculoMedia.ToString("F2"));
            }
            else
            {
                Console.WriteLine($"\nO aluno {_nome} está reprovado!\nMédia: " + calculoMedia.ToString("F2"));
            }

        }
    }
}
