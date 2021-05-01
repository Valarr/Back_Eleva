using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevaTest.entity
{
    public class EscolaEntity
    {
        public virtual int id_escola { get; set; }
        public virtual string nome_escola { get; set; }
        public virtual string telefone { get; set; }
        public virtual string endereco { get; set; }


    }
}
