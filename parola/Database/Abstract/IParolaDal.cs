namespace parola.Database.Abstract
{
    public interface IParolaDal : IEntityRepository<Entities.Concrete.Parola>
    {
        string WhatIsTheConnectionString();
    }
}
