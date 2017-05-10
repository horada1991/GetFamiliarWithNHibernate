using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using TryNHibernate.Domain;

namespace TryNHibernate
{
    class CharacterRepository
    {
        public void Add(Character newCharacter)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(newCharacter);
                    transaction.Commit();
                }
            }
        }
    }
}
