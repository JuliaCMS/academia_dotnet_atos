using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21
{
    internal class Carro
    {
        private string marca;
        private string modelo;
        private int ano;
        private Motor m;

        public String Marca
        {
            get
            {
                return marca;
            }
            set 
            { 
                marca = value; 
            }
        }

        public String Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }

        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                if (value > 0)
                {
                    ano = value;
                }
            }
        }

        public Motor Motor
        {
            get { return m; }
            set { m = value; }
        }

        public void LigarCarro()
        {
            if (!m.Ligado)
            {
                m.LigarMotor();
                Console.WriteLine("O carro ligou");
            }
            else
            {
                Console.WriteLine("O carro já está ligado!");
            }
        }

        public void DesligarCarro()
        {
            if (m.Ligado)
            {
                m.DesligarMotor();
                Console.WriteLine("O carro desligou");
            }
            else
            {
                Console.WriteLine("O carro já está desligado!");
            }
        }

            
    }
}
