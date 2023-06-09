using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAlunosCursos.DataModels
{
    internal class Aluno
    {
        public int id { get; set; }
        public string nome { get; set; }
        public virtual ICollection<Matricula> matriculas { get; set; }
    }
}
