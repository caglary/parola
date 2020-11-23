using Ninject.Modules;
using parola.Business.Abstract;
using parola.Business.Concrete;
using parola.Database;
using parola.Database.Abstract;
using parola.Database.Concrete.EntityFramework;
using parola.Database.Concrete.LiteDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parola.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IParolaService>().To<ParolaManager>().InSingletonScope();
            //Bind<IParolaDal>().To<EfParolaDal>().InSingletonScope();
            Bind<IParolaDal>().To<LiteDbParolaDal>().InSingletonScope();




        }
    }
}
