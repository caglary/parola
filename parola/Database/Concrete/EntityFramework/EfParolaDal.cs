using parola.Database.Abstract;
using parola.Entities.Concrete;

namespace parola.Database.Concrete.EntityFramework
{
    public class EfParolaDal : EfEntityRepositoryBase<Parola, ParolaContext>, IParolaDal
    {
        public string WhatIsTheConnectionString()
        {
            return @"Server: (localdb)\MSSQLLocalDB";
            //will code
        }
        public override int Update(Parola entity)
        {
            using (ParolaContext context = new ParolaContext())
            {
                var result = Get(p => p.isim == entity.isim);
                result.parolaid = entity.parolaid;
                result.parola_ = entity.parola_;
                result.kullaniciadi = entity.kullaniciadi;
                result.SeleniumMethod = entity.SeleniumMethod;
                result.aciklama = entity.aciklama;
                  
                return context.SaveChanges();
            }
        }
    }
}
