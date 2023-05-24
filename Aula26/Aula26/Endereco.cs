using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula26
{
    internal class Endereco
    {
        public string Rua;
        public string Cep;
        public int Numero;

        public Endereco(string rua, string cep, int numero)
        {
            Rua = rua;
            Cep = cep;
            Numero = numero;
        }
    }
}
