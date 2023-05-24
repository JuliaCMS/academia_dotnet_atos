using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula26
{
    internal class VeiculoEletrico : Veiculo // referencia de herança ao lado do nome da classe
    {
        public double _autonomia;

        public void Carregar()
        {
            this._autonomia += 10;
            Console.WriteLine("Carreguei 10%");
        }
    }
}
