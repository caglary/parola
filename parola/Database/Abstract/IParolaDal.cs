using parola.Entities.Concrete;

namespace parola.Database.Abstract
{
    public interface IParolaDal : IEntityRepository<Parola>
    {
        string WhatIsTheConnectionString();
    }
}
