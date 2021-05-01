using System;
using System.Configuration;
using ElevaTest.Infra;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using ElevaTest.Repository;
using ElevaTest.entity;
using NHibernate;
using ElevaTest.Infra.Escola.Repositorio;
using Newtonsoft.Json;

namespace ElevaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria a tabela
            //NHibernateHelper.GeraSchema();

            //cria sessão unica compartilhada com o banco de dados
            ISession session = NHibernateHelper.AbreSession();

            //inicia os repositorios
            IEscolaRepo escolaRepo = new EscolaRepo(session);

            //entidade do banco, um modelo
            //cria um obj escola
            EscolaEntity escola = new EscolaEntity();
            escola.nome_escola = "Godofoda";
            escola.telefone = "982524601";
            escola.endereco = "tititititi";

            //salva o obj escola criado
            //rota api de inserção
            //escolaRepo.insert(escola);

            //recupera os dados do BD
            //rota de api pincipal
            IList<EscolaEntity> escolaList = escolaRepo.show();

            //imprime como Json
            Console.WriteLine(JsonConvert.SerializeObject(escolaList));
            /*foreach (EscolaEntity obj in escolaList)
            {
                Console.WriteLine(
                    "{0}\t{1}\t{2}\t{3}\t",
                    obj.id_escola,
                    obj.nome_escola,
                    obj.telefone,
                    obj.endereco
                    );
            }*/


            Console.Read();
        }

    }
}
