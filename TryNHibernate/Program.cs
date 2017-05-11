using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using TryNHibernate.Domain;

namespace TryNHibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadNHibernateCfg();

            CharacterRepository repository = new CharacterRepository();

            //Create
            var cerianth = new Character { Name = "Cerianth4", HealthPoints = 500, Mana = 100, Profession = "Hunter" };
            repository.Add(cerianth);

            //Read
            var character = repository.GetCharacterByName("Cerianth4");

            //Update
            character.Name = "Kaleid";
            repository.Update(character);

            Console.ReadKey();
        }

        public static void LoadNHibernateCfg()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Character).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }
    }
}
