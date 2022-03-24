using parola.Business.Abstract;
using parola.Business.DependencyResolvers.Ninject;
using parola.Entities.Concrete;
using parola.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace parola.Forms
{
    public partial class Anasayfa : Form
    {
        IParolaService _bll;
        ParolaEdit parolaEdit;
        static Parola parolaEntity;
        public Anasayfa()
        {
            InitializeComponent();
            parolaEntity = lblParolaListe.SelectedItem as Parola;
            _bll = InstanceFactory.GetInstance<IParolaService>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bool hardDiskFinded = false;
            //eğer programa başka bilgisayardan giriş yapılırsa
            HardDrive hd = new HardDrive();
            var list=hd.GetHDDInformation();
            foreach (var item in list)
            {
                if (item.SerialNo == "2J1720122823")
                {
                    //Lenovo
                    hardDiskFinded = true;
                }
            }
            if (hardDiskFinded) LoadingForm();
            else
            {
                Password password = new Password();
                password.ShowDialog();
                LoadingForm();
            }
           
            
        }
        public void LoadingForm()
        {
            this.Text = _bll.WhatIsTheConnectionString() + " içerindeki kayıtlar";
            Listele();
            parolaEntity = lblParolaListe.SelectedItem as Parola;
            if (parolaEntity == null)
            {
                Parola firstParola = new Parola();
                firstParola.isim = "-";
                firstParola.kullaniciadi = "-";
                firstParola.parola_ = "-";
                firstParola.aciklama = "-";
                firstParola.parolaid = 0;
                parolaEntity = firstParola;
            }
            WebButtonControl(parolaEntity);
            ParolaBilgileriShow(parolaEntity);
        }
        private void ParolaBilgileriShow(Parola parolaEntity)
        {
            lblIsim.Text = parolaEntity.isim;
            lblKullaniciAdi.Text = parolaEntity.kullaniciadi;
            lblParola.Text = parolaEntity.parola_;
            lblAciklama.Text = parolaEntity.aciklama;
            lblSeleniumInfo.Text = parolaEntity.SeleniumMethod;
        }
        public void Listele()
        {
            List<Parola> parolalar = _bll.GetAll();
            lblParolaListe.DataSource = parolalar;
            lblParolaListe.DisplayMember = "isim";
            lblToplamKayitSayisi.Text = parolalar.Count.ToString();
        }
        private void excel_Click(object sender, EventArgs e)
        {
            datagridliste exceleaktar = new datagridliste();
            exceleaktar.Show();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            parolaEntity = lblParolaListe.SelectedItem as Parola;
            WebButtonControl(parolaEntity);
            ParolaBilgileriShow(parolaEntity);
        }
        private void Arama(object sender, EventArgs e)
        {
            var liste = _bll.GetAll();
            lblParolaListe.DataSource = liste.Where(p => p.isim.ToLower().Contains(txtArama.Text.ToLower())).ToList(); ;
        }
        private void WebButtonControl(Parola parola)
        {
            /*id_ler dizininde id si belirtilen kayıtlar form ekranında geldiğinde web butonları aktif olacak . 
             * id_ler dizisinde kayıtlı olmayanlar id ler form ekranında gözüktüğünde web butonu pasif konumda olacak. 
             */
            void webBtnActive(bool ButonuAc = true)
            {
               
                BtnShow.Enabled = ButonuAc;
                if (ButonuAc) BtnShow.Text = "Chrome Aç";
                else BtnShow.Text = "Kapalı";
               
            }
            webBtnActive(false);
            if (!string.IsNullOrEmpty(parolaEntity.SeleniumMethod)) webBtnActive();
        }
        private void BtnJsonBackup_Click(object sender, EventArgs e)
        {
            string folderPath = FileOperation.FolderPath();
            if (!string.IsNullOrEmpty(folderPath))
            {
                var liste = _bll.GetAll();
                var mailParola = liste.Where(I => I.isim == "gmail").SingleOrDefault();
                string stringliste = JsonOperation.JsonSerialize(liste);
                string backupTime = DateTime.Now.ToShortDateString();
                string SavePath = folderPath + "\\" + backupTime+"_passwords.json";

                //Backup tarihini bir dosyaya kayıt ediyoruz. 



                System.IO.File.WriteAllText(SavePath, stringliste);
                MessageBoxOperation.MessageBoxInformation($"Yedekleme işlemi gerçekleşti.\n{SavePath} adresini kontrol ediniz.");
            }

        }
        private void BtnJsonRestore_Click(object sender, EventArgs e)
        {
            List<string> etkilenenKayitlar = new List<string>();
            List<Parola> Parolalar = null;
            string path = FileOperation.FilePath();
            if (!string.IsNullOrEmpty(path))
            {
                string JsonOkunanData = System.IO.File.ReadAllText(path);
                Parolalar = JsonOperation.JsonDeserialize<Parola>(JsonOkunanData);
            }
            if (Parolalar != null && !string.IsNullOrEmpty(Parolalar[0].kullaniciadi) &&
                !string.IsNullOrEmpty(Parolalar[0].isim) && !string.IsNullOrEmpty(Parolalar[0].parola_)
                && !string.IsNullOrEmpty(Parolalar[0].parola_))
            {
                foreach (var parola in Parolalar)
                {
                    //gelen koleksiyondaki verileri veritabanına kaydetmek için kod yazılabilir.
                    //ilgili değer kayıt ve update işlemleri yapılacaktır. 
                    //business tarafında metotlar oluşturulup eklenecek..
                    string etkilenenenKayit = _bll.RestoreFromJsonToDatabase(parola);
                    if (etkilenenenKayit != "")
                    {
                        etkilenenKayitlar.Add(etkilenenenKayit);
                    }
                }
                MessageBoxOperation.MessageBoxInformation("Restore işlemi bitmiştir...");
                RestoreKayitlar restoreKayitlar = new RestoreKayitlar(etkilenenKayitlar);
                restoreKayitlar.Show();
            }
            else
            {
                //koleksiyon null değerde geldiği için herhangi bir işlem yapmıyoruz.
                MessageBoxOperation.MessageBoxWarning("Koleksiyon null değer almıştır.İlgili json dosyasından herhangi bir değer AKTARILAMAMIŞTIR.");
            }
            Listele();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            //guncelleme işlemi
            Parola parola = lblParolaListe.SelectedItem as Parola;
            if (parola != null)
            {
                parolaEdit = new ParolaEdit(parola, Operations.Update);
                parolaEdit.ShowDialog();
            }
            else
            {
                MessageBoxOperation.MessageBoxWarning("Herhangi bir parola seçmediniz.İşleme devam edilemiyor.");
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            Parola parola = lblParolaListe.SelectedItem as Parola;
            if (parola != null)
            {
                ParolaEdit delete = new ParolaEdit(parola, Operations.Delete);
                delete.ShowDialog();
            }
            else
            {
                MessageBoxOperation.MessageBoxWarning("Herhangi bir parola seçmediniz.İşleme devam edilemiyor.");
            }
            LoadingForm();
        }
        private void BtnShow_Click(object sender, EventArgs e)
        {
            Hata.tryCatch(() =>
            {
                ReflectionSelenium reflectionSelenium = new ReflectionSelenium();
                var classControl = reflectionSelenium.classControl();
                var methodListesi = reflectionSelenium.methodInfos();
                bool methodControl = methodListesi.Contains(parolaEntity.SeleniumMethod);
                if (methodControl && classControl)
                    reflectionSelenium.InvokeMethod(parolaEntity.SeleniumMethod, parolaEntity.kullaniciadi, parolaEntity.parola_);
                else
                    throw new Exception("Metot bulunamadı.");
            });
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var item in Selenium.drivers)
            {
                item.Quit();
            }
            System.Windows.Forms.Application.Exit();
        }
        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblParola.Text);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //yeni kayıt işlemi
            parolaEdit = new ParolaEdit(null, Operations.Add);
            parolaEdit.ShowDialog();
        }
    }
}
