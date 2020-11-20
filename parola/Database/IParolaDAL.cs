using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
