using System.Collections.Generic;
namespace parola.Database
{
    public interface IParolaDAL
    {
        int Save(parola parola);
        int Update(parola _parola);
        int Delete(parola parola);
        List<parola> GetAll();
        string WhatIsTheConnectionString();
    }
}
