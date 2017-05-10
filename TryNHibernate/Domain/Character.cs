using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryNHibernate.Domain
{
    class Character
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int HealthPoints { get; set; }
        public virtual int Mana { get; set; }
        public virtual string Profession { get; set; }
        public virtual string Gender { get; set; }
    }

}
