using parola.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace parola.Business.Abstract
{
    public interface IParolaService
    {
       
        List<Parola> GetAll();
        Parola Get(Expression<Func<Parola, bool>> filter);
        void Add(Parola entity);
        void Update(Parola entity);
        void Delete(Parola entity);
        string WhatIsTheConnectionString();
        string RestoreFromJsonToDatabase(Parola parola);
    }
}
