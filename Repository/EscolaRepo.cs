using NHibernate;
using System;
using System.Collections.Generic;
using ElevaTest.entity;
using ElevaTest.Infra.Escola.Repositorio;

namespace ElevaTest.Repository
{
    public class EscolaRepo:IEscolaRepo
    {
        private ISession session;

        public EscolaRepo(ISession session)
        {
            this.session = session;
        }

        public bool insert(EscolaEntity escola)
        {
            ITransaction transacao = session.BeginTransaction();
            var identifier = session.Save(escola);
            transacao.Commit();

            return identifier != null;
        }

        public IList<EscolaEntity> show()
        {
            return session.CreateCriteria<EscolaEntity>().List<EscolaEntity>();
        }

        public bool update(EscolaEntity escola)
        {
            try
            {
                ITransaction transacao = session.BeginTransaction();
                session.Update(escola);
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public bool delete(EscolaEntity escola)
        {
            try
            {
                ITransaction transacao = session.BeginTransaction();
                session.Delete(escola);
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

    }
}