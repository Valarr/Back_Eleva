using NHibernate;
using System;
using System.Collections.Generic;
using ElevaTest.entity;

namespace ElevaTest.Repository
{
    public class TurmaRepo
    {
        private ISession session;

        public TurmaRepo(ISession session)
        {
            this.session = session;
        }

        public bool insert(TurmaEntity turma)
        {
            ITransaction transacao = session.BeginTransaction();
            var identifier = session.Save(turma);
            transacao.Commit();

            return identifier != null;
        }

        public IList<TurmaEntity> show()
        {
            return session.CreateCriteria<TurmaEntity>().List<TurmaEntity>();
        }

        public bool update(TurmaEntity turma)
        {
            try
            {
                ITransaction transacao = session.BeginTransaction();
                session.Update(turma);
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public bool delete(TurmaEntity turma)
        {
            try
            {
                ITransaction transacao = session.BeginTransaction();
                session.Delete(turma);
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