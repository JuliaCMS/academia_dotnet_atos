using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAlunosCursos.DataModels
{
    internal class Matricula
    {
        public int id { get; set; }
        public string matricula { get; set; }
        public virtual Aluno aluno { get; set; }
        public virtual Curso curso { get; set; }
    }
}
