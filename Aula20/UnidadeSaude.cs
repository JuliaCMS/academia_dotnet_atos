using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20
{
    internal class UnidadeSaude
    {
        //string nome; // selecionar os atributos -> ações rápidas -> encapsular campos e usar propriedades -> vai gerar os getters e setters ... mas não é assim que está se programando em C#
        //string sigla;
        //public string Nome { get => nome; set => nome = value; } // o lambda está apontando para a variavel idade (get irá ler o valor da variavel nome e set irá atribuir o valor ao nome)
        //public string Sigla { get => sigla; set => sigla = value; }

        public string Nome { get; set; } // atalho com prop tab tab // padrão da microsoft
        public string Sigla { get; set;}
        public ProfissionalSaude Responsavel { set; get; }

        public UnidadeSaude()
        {
            Responsavel = new ProfissionalSaude();
        }

        public UnidadeSaude (string nome, string sigla)
        {
            Nome = nome.ToUpper();
            Sigla = sigla.ToUpper();
            Responsavel = new ProfissionalSaude();
        }

        public UnidadeSaude (string nome)
        {
            Nome = nome.ToUpper();
            Responsavel = new ProfissionalSaude();
        }


    }
}
