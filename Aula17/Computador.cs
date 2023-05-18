using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17
{
    internal class Computador
    {
        public string marca;
        public string modelo;
        public string tipo;
        public double preco;

        public Computador()
        {

        }
         
        public Computador(string marca, string modelo, string tipo, double preco)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.tipo = tipo;
            this.preco = preco;
        }

        public void exibeDadosComputador()
        {
            Console.WriteLine("Marca: " + this.marca);
            Console.WriteLine("Modelo: " + this.modelo);
            Console.WriteLine("Tipo: " + this.tipo);
            Console.WriteLine("Preço: " + this.preco);
            // poderia retornar uma string também
            //ex: return "Marca:  "  + this.marca + " Modelo: " + this.modelo + "\nTipo: " + this.tipo + " Preço: " + this.preco;
        }
    }
}
