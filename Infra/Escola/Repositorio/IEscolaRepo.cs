using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevaTest.entity;

namespace ElevaTest.Infra.Escola.Repositorio
{
    interface IEscolaRepo
    {
        public bool insert(EscolaEntity escola);
        public bool update(EscolaEntity escola);
        public bool delete(EscolaEntity escola);
        public IList<EscolaEntity> show();
        //assinaturas insert coisa
    }
}
