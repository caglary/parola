using parola.Business.Abstract;
using parola.Database.Abstract;
using parola.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace parola.Business.Concrete
{
    public class ParolaManager : IParolaService
    {
        private IParolaDal _dll;
        public ParolaManager(IParolaDal parolaDal)
        {
            _dll = parolaDal;
        }

        public void Add(Parola entity)
        {
            _dll.Add(entity);
        }

        public void Delete(Parola entity)
        {
            _dll.Delete(entity);

        }

        public Parola Get(Expression<Func<Parola, bool>> filter)
        {
            return _dll.Get(filter);

        }

        public List<Parola> GetAll()
        {
            return _dll.GetAll();

        }

        public string RestoreFromJsonToDatabase(Parola parola)
        {

            string etkilenenKayit = string.Empty;
            var liste = GetAll();

            Parola gelenDeger = liste.Find(I => I.isim.ToLower() == parola.isim.ToLower());

            if (gelenDeger==null)
            {
                Add(parola);
                etkilenenKayit = $"Saved - {parola.isim}";

            }
            else
            {
                Update(parola);
                etkilenenKayit = $"Updated - {parola.isim}";

            }
           
            return etkilenenKayit;

        }

        public void Update(Parola entity)
        {
            _dll.Update(entity);

        }

        public string WhatIsTheConnectionString()
        {
            return _dll.WhatIsTheConnectionString();
        }
    }
}
