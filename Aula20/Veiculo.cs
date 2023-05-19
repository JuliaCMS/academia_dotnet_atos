using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20
{
    internal class Veiculo
    {
        public string placa;
        public DateTime dataHoraEntrada;
        public string cor;
        public string marca;
        public string modelo;
        public DateTime dataHoraSaida;
        public double valorPago;

        //construtor vazio
        public Veiculo()
        {
            this.dataHoraEntrada = DateTime.Now;
        }

        //construtor
        public Veiculo(string placa, string cor, string marca, string modelo)
        {
            this.placa = placa.ToUpper().Trim();
            this.cor = cor.ToUpper().Trim();
            this.marca = marca.ToUpper().Trim();
            this.modelo = modelo.ToUpper().Trim();
            this.dataHoraEntrada = DateTime.Now;

        }

        //reescrever o método Equals()
    }
}
