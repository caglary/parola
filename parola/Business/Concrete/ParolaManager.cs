using parola.Business.Abstract;
using parola.Business.FluentValidation;
using parola.Database.Abstract;
using parola.Entities.Concrete;
using parola.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

namespace parola.Business.Concrete
{
    public class ParolaManager : IParolaService
    {
        private IParolaDal _dll;
        private int returnValue;

        public ParolaManager(IParolaDal parolaDal)
        {

            _dll = parolaDal;

        }

        public void Add(Parola entity)
        {
            ValidationTool.Validate(new ParolaValidator(), entity);
            returnValue = _dll.Add(entity);
            List<Parola> parolalar = new List<Parola>();
            parolalar.Add(entity);
            if (returnValue > 0) Log(parolalar, Operations.Add);
        }

        public void Delete(Parola entity)
        {

            returnValue = _dll.Delete(entity);
            List<Parola> parolalar = new List<Parola>();
            parolalar.Add(entity);
            if (returnValue > 0) Log(parolalar, Operations.Delete);

        }

        public Parola Get(Expression<Func<Parola, bool>> filter)
        {
            return _dll.Get(filter);

        }

        public List<Parola> GetAll()
        {
            return _dll.GetAll();

        }
        public void Update(Parola entity)
        {
            ValidationTool.Validate(new ParolaValidator(), entity);
            Parola oldParola = Get(I => I.parolaid == entity.parolaid);
            returnValue = _dll.Update(entity);
            if (returnValue > 0)
            {
                List<Parola> parolalar = new List<Parola>();
                parolalar.Add(entity);
                parolalar.Add(oldParola);

                Log(parolalar, Operations.Update);


            }
        }

        public void Log(List<Parola> parolalar, Operations nameOfOperation)
        {
            //gelen parola değişmiş parola 
            string path = Directory.GetCurrentDirectory();
            path = path + "\\log.txt";
            string content = "";

            if (nameOfOperation == Operations.Add)
            {
                content = $"Tarih:{DateTime.Now} --EKLEME\nİsim: {parolalar[0].isim} Kullanıcı Adı: {parolalar[0].kullaniciadi} Parola: {parolalar[0].parola_}";
            }
            else if (nameOfOperation == Operations.Delete)
            {
                content = $"Tarih:{DateTime.Now} --SİLME\nİsim: {parolalar[0].isim} Kullanıcı Adı: {parolalar[0].kullaniciadi} Parola: {parolalar[0].parola_}";
            }
            else if (nameOfOperation == Operations.Update)
            {

                content = $"Tarih:{DateTime.Now} --GÜNCELLEME\nEski Kullanıcı Adı: {parolalar[1].kullaniciadi} Eski Parola: {parolalar[1].parola_}\nYeni Kullanıcı Adı: {parolalar[0].kullaniciadi} Yeni Parola: {parolalar[0].parola_}";
            }


            string oldContent = File.ReadAllText(path);
            string newContent = $"{oldContent}\n{content}";
            File.WriteAllText(path, newContent);

        }



        public string RestoreFromJsonToDatabase(Parola parola)
        {
            string etkilenenKayit = string.Empty;

            try
            {

                var gelenDeger = Get(p => p.isim.ToLower() == parola.isim.ToLower());

                if (gelenDeger == null)
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
            catch (Exception)
            {
                return etkilenenKayit;


            }


        }



        public string WhatIsTheConnectionString()
        {
            return _dll.WhatIsTheConnectionString();
        }
    }

}
