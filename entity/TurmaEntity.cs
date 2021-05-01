using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevaTest.entity
{
    public class TurmaEntity
    {
        public virtual int id_turma { get; set; }
        public virtual int id_escola { get; set; }
        public virtual string nome_turma { get; set; }

    }
}
