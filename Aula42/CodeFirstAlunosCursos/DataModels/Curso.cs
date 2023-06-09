using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAlunosCursos.DataModels
{
    internal class Curso
    {
        public int id { get; set; }
        public string curso { get; set; }
        public virtual ICollection<Matricula> matriculas { get; set; }
    }
}
