using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula26
{
    internal class Carro : Veiculo
    {
        public int _quantidadeDePortas;

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {_marca} {_modelo} com {_quantidadeDePortas} portas.");
        }
    }
}
