using FluentValidation;
using parola.Database;
using parola.Utilities;
using parola.ValidatonRules.FluentValidation;
using StaticClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace parola
{
    public class ParolaManager
    {
        #region Fields Of The Class
        ParolaValidator _parolaValidator;
        IParolaDAL _dll;
        int ReturnValue;
        
        #endregion
        #region Constructors
        public ParolaManager()
        {
            _dll = new LiteDbParolaDal();
            //_dll = new SqliteParolaDal();
            _parolaValidator = new ParolaValidator();
            
        }
        #endregion
        #region CRUD Operations
        public List<parola> GetAll()
        {
            return _dll.GetAll();
        }
        public void Save(parola parola)
        {
            ValidationTool.Validate(new ParolaValidator(), parola);
            ReturnValue = _dll.Save(parola);
            if (ReturnValue > 0)
            {
                MessageBoxOperation.MessageBoxInformation("Kayıt işlemi başarılı.");
            }
            else
            {
                MessageBoxOperation.MessageBoxError("Kayıt yapılamadı.");
            }
        }
        private void SendMail(parola parola, string konu, string emailParola)
        {
            string icerik = $"isim :{parola.isim}   " +
                $"Kullanıcı Adı:{parola.kullaniciadi}    " +
                $"Parola :{parola.parola_}    " +
                $"Acıklama :{parola.aciklama}    " +
                $"ID:{parola.parolaid}    ";
            StaticClass.SendEmail.SendMailToGmail(konu, icerik, "Parola Uygulaması", emailParola);
        }
        public void Delete(parola parola)
        {
            ValidationTool.Validate(new ParolaValidator(), parola);
            if (soru())
            {
                ReturnValue = _dll.Delete(parola);
                if (ReturnValue >= 0)
                {
                    MessageBoxOperation.MessageBoxInformation("Silme işlemi başarılı.");
                    //SendMail(parola,"Parola Silme İşlemi");
                }
            }
        }
        public void Update(parola parola)
        {
            ValidationTool.Validate(new ParolaValidator(), parola);
            if (soru())
            {
                
                //burada bir işlem daha var.Eğer belgenet tarimmail veya pbys parolarından biri değiştiğinde diğer paroladarda otomatik güncellenmeli...
                
                var pbys = _dll.GetAll().Where(I => I.isim == "PBYS Çağlar").SingleOrDefault();
                var tarimmail = _dll.GetAll().Where(I => I.isim == "tarimmail.gov.tr").SingleOrDefault();
                var belgenet = _dll.GetAll().Where(I => I.isim == "Belgenet Çağlar").SingleOrDefault();
                if (parola.parolaid == pbys.parolaid || parola.parolaid == tarimmail.parolaid || parola.parolaid == belgenet.parolaid)
                {
                    if (parola.parolaid== pbys.parolaid)
                    {
                        //pbys ile ilgili güncelleme işlemi
                       
                        pbys.kullaniciadi = parola.kullaniciadi;
                        pbys.aciklama = parola.aciklama;
                        pbys.SeleniumMethod = parola.SeleniumMethod;
                    }
                    if (parola.parolaid == tarimmail.parolaid)
                    {
                        //tarim mail ile ilgili güncelleme işlemi
                        
                        tarimmail.kullaniciadi = parola.kullaniciadi;
                        tarimmail.aciklama = parola.aciklama;
                        tarimmail.SeleniumMethod = parola.SeleniumMethod;
                    }
                    if (parola.parolaid == belgenet.parolaid)
                    {
                        // belgenet ile ilgili güncelleme işlemi
                      
                        belgenet.kullaniciadi = parola.kullaniciadi;
                        belgenet.aciklama = parola.aciklama;
                        belgenet.SeleniumMethod = parola.SeleniumMethod;
                    }
                    //parola güncellemeleri ortak
                    pbys.parola_ = parola.parola_;
                    tarimmail.parola_ = parola.parola_;
                    belgenet.parola_ = parola.parola_;
                    var ReturnValue1 = _dll.Update(pbys);
                    var ReturnValue2 = _dll.Update(tarimmail);
                    var ReturnValue3 = _dll.Update(belgenet);
                    ReturnValue = ReturnValue1 * ReturnValue2 * ReturnValue3;
                    if (ReturnValue==1)
                    {
                        MessageBoxOperation.MessageBoxInformation("Tarımmail, Pbys ve Belgenet şifreleri güncellendi.");
                    }
                }
                else
                {
                    ReturnValue = _dll.Update(parola);
                    if (ReturnValue > 0)
                    {
                        MessageBoxOperation.MessageBoxInformation("Güncelleme işlemi başarılı.");
                    }
                }
            }
        }
        #endregion
        private bool soru()
        {
            bool cevap = false;
            DialogResult soru = new DialogResult();
            soru = MessageBoxOperation.MessageBoxQuestion($"Devam etmek istiyor musunuz?");
            if (soru == DialogResult.Yes)
            {
                cevap = true;
            }
            return cevap;
        }
        public List<parola> Search(string AranacakMetin)
        {
            return _dll.GetAll().Where(I => I.isim.ToLower().Contains(AranacakMetin.ToLower())).ToList();
        }
        public string RestoreFromJsonToSql(parola parola)
        {
            ReturnValue = 0;
            string etkilenenKayit = string.Empty;
            string etkilenenKayitReturn = string.Empty;
            // json uzantılı dosyadan okuduğum dataları sql tarafına kayıt veya update yapıyorum.
            ValidationTool.Validate(new ParolaValidator(), parola);
            parola gelenDeger = GetAll().Where(I => I.isim == parola.isim).SingleOrDefault();
            if (gelenDeger == null)
            {
                ReturnValue = _dll.Save(parola);
                if (ReturnValue > 0)
                {
                    etkilenenKayit = $"Saved - {parola.isim}";
                }
            }
            else
            {
                ReturnValue = _dll.Update(parola);
                if (ReturnValue > 0)
                {
                    etkilenenKayit = $"Updated - {parola.isim}";
                }
            }
            if (ReturnValue > 0)//kayıt yapılamamıştır. 
            {
                if (etkilenenKayit != "" && !string.IsNullOrEmpty(etkilenenKayit))
                {
                    etkilenenKayitReturn = etkilenenKayit;
                }
            }
            return etkilenenKayitReturn;
        }
        public string WhatIsTheConnectionString()
        {
            try
            {
                return _dll.WhatIsTheConnectionString();
            }
            catch (Exception exception)
            {
                StaticClass.Hata.Logging(exception);
                return null;
            }
        }
    }
}
