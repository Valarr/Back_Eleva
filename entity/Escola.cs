using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevaTest.entity
{
    public class Escola
    {
        public virtual int id_escola { get; set; }
        public virtual int nome_escola { get; set; }
        public virtual int telefone { get; set; }
        public virtual int endereco { get; set; }


    }
}
