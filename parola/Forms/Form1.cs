using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace parola
{
    public partial class Form1 : Form
    {
        ParolaManager _bll;
        static IWebDriver driver;
        static parola parolaEntity;
        static string[] parolaIds = new string[] { "hepsiburada", "dropbox", "heibis", "happy.com.tr", "gm", "gittigidiyor", "github", "facebook", "PBYS", "tbs", "n11", "babam edevlet", "bahattin Babam E-devlet", "eda e-devlet.", "e nabız eda", "bebeklik.com", "halkbank", "hotmail-skype-microsoft account", "hotmail yeni", "kuveyt", "gmail", "gmail eda", "gthb mail / belgenet", "belgenet evrak kayıt", "garanti", "ziraat bankası", "babam halkbank", "bahattin babam ziraat", "annem halkbank", "e-nabız", "e-devlet", "Etimesgut Belediyesi", "turk telekom", "udemy", "kitap yurdu", "kuveyt cihan", "trendyol" };

        public Form1()
        {
            InitializeComponent();
            parolaEntity = lbxParolaListe.SelectedItem as parola;
            _bll = new ParolaManager();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Listele();

            parolaEntity = lbxParolaListe.SelectedItem as parola;
            WebButtonControl(parolaEntity);


            ParolaBilgileriShow(parolaEntity);
            int retunValue = _bll.ParolaGuncellemeKontrol();
            if (retunValue != 100)
            {
                MessageBox.Show("PBYS parolası ile Belgenet Parolanınız aynı olmak zorunda.\nSQL tarafında parolalar arasında uyuşmazlık tespit edildi.\nEn kısa zamanda parola guncellemenizi yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ParolaBilgileriShow(parola parolaEntity)
        {
            lblIsim.Text = parolaEntity.isim;
            lblKullaniciAdi.Text = parolaEntity.kullaniciadi;
            lblParola.Text = parolaEntity.parola_;
            lblAciklama.Text = parolaEntity.aciklama;
        }

        public void Listele()
        {
            List<parola> parolalar = _bll.GetAll();
            lbxParolaListe.DataSource = parolalar;
            lblToplamKayitSayisi.Text = parolalar.Count.ToString();

        }
        private void excel_Click(object sender, EventArgs e)
        {
            datagridliste exceleaktar = new datagridliste();
            exceleaktar.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            parolaEntity = lbxParolaListe.SelectedItem as parola;
            WebButtonControl(parolaEntity);

            ParolaBilgileriShow(parolaEntity);

        }
        private void Arama(object sender, EventArgs e)
        {
            lbxParolaListe.DataSource = _bll.Search(txtArama.Text);
        }


        private void TryCatch(System.Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void OpenWeb()
        {


            Selenium selenium = new Selenium();

            if (driver != null)
            {
                driver.Quit();
            }
            switch (parolaEntity.isim)
            {
                case "facebook":// Facebook
                    driver = selenium.facebook(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "hepsiburada":// HepsiBurada
                    driver = selenium.HepsiBurada(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "dropbox":// Dropbox
                    driver = selenium.Dropbox(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "heibis":// Heibis
                    driver = selenium.Heibis(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "happy.com.tr":// Happy.com.tr
                    driver = selenium.HappyComTr(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "gm":// General Mobile
                    driver = selenium.GeneralMobile(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "gittigidiyor":// GittiGidiyor
                    driver = selenium.GittiGidiyor(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "github":// Github
                    driver = selenium.Github(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "ziraat bankası":// ziraat bankası
                    driver = selenium.ZiraatBankasi(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "PBYS":// PBYS
                    driver = selenium.PBYS(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "tbs":// Tbs
                    driver = selenium.TbsGiris(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "halkbank"://Halkbank id
                    driver = selenium.Halkbank(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "babam halkbank"://Halkbank babam
                    driver = selenium.Halkbank(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "annem halkbank"://Halkbank annem
                    driver = selenium.Halkbank(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "hotmail-skype-microsoft account"://Hotmail extraord.... 
                    driver = selenium.Hotmail(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "hotmail yeni":// hotmail yeni adres : caglar.yurdakul60@hotmail.com 
                    driver = selenium.Hotmail(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "kuveyt":// kuvetyturk
                    driver = selenium.Kuveyt(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "kuveyt cihan":// kuvetyturk cihan
                    driver = selenium.Kuveyt(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "gmail":// gmail 
                    driver = selenium.Gmail(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                //case 6:// gmail appleID
                //    driver = selenium.Gmail(parolaEntity.kullaniciadi, parolaEntity.parola_);
                //    break;
                case "gmail eda":// gmail eda
                    driver = selenium.Gmail(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                //case 30:// gmail Bahattin Babam
                //    driver = selenium.Gmail(parolaEntity.kullaniciadi, parolaEntity.parola_);
                //    break;
                case "gthb mail / belgenet":// Belgenet benim
                    driver = selenium.Belgenet(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "belgenet evrak kayıt":// Belgenet Murat Abi
                    driver = selenium.Belgenet(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "garanti":// Garanti Bankası
                    driver = selenium.GarantiBank(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                
                case "udemy":// Udemy
                    driver = selenium.Udemy(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "e-nabız":// e-nabız benim
                    driver = selenium.E_Nabiz(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "e nabız eda":// e-nabız eda
                    driver = selenium.E_Nabiz(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "Etimesgut Belediyesi":// Etimesgut Belediyesi
                    driver = selenium.EtimesgutBelediyesi(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "e-devlet":// e-devlet
                    driver = selenium.E_Devlet(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "babam edevlet":// Babam e-devlet
                    driver = selenium.E_Devlet(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "bahattin Babam E-devlet":// Bahattin babam e-devlet
                    driver = selenium.E_Devlet(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "eda e-devlet.":// eda e-devlet
                    driver = selenium.E_Devlet(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "turk telekom":// Turk Telekom
                    driver = selenium.TTNet(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "kitap yurdu":// Kitap yurdu
                    driver = selenium.KitapYurdu(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "bebeklik.com":// bebeklik.com.tr
                    driver = selenium.BebeklikComTr(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "n11":// n11.com.tr
                    driver = selenium.N11(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "bahattin babam ziraat":
                    driver = selenium.ZiraatBankasi(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                case "trendyol":
                    driver = selenium.Trendyol(parolaEntity.kullaniciadi, parolaEntity.parola_);
                    break;
                default:

                    break;
            }
            this.Show();
        }

        private void WebButtonControl(parola parola)
        {
            //burada web butonlarının enabled durumlarının true ve false olması durumunda yapılacaklar yazıldı.
            /*id_ler dizininde id si belirtilen kayıtlar form ekranında geldiğinde web butonları aktif olacak . 
             * id_ler dizisinde kayıtlı olmayanlar id ler form ekranında gözüktüğünde web butonu pasif konumda olacak. 
             */
            int sayac = 0;
            void webBtn(bool ButonuAcYadaKapat)
            {
                BtnCloseWeb.Enabled = ButonuAcYadaKapat;
                BtnShow.Enabled = ButonuAcYadaKapat;
                //if (ButonuAcYadaKapat == true) BtnShow.Text = "Webte Aç";
                //else BtnShow.Text = "Kullanılamaz";

            }

            string selectOption = parola.isim;

            /* 34 Halkbank-ben
             * 39 Hotmail extra...
             * 73 Hotmail caglar...
             * 45 KuveytTurk
             * 28 Gmail
             * 29 Gmail Eda
             * 30 Bahattin Babam
             * 31 belgenet - 10 Belgenet(murat Abi)
             * 24 Garanti Bankası
             * 72 Ziraat Bankası
             * 68 Udemy (şu an için kullanamıyorum )
             * 8 halkbank babam
             * 5 halkbank annem
             */
            for (int i = 0; i < parolaIds.Length; i++)
            {
                if (selectOption == parolaIds[i])
                {
                    webBtn(true);
                    sayac = 1;

                }



            }
            switch (sayac)
            {
                case 0://sayac 0 geldiğinde buton enabled false değerini alacak.
                    webBtn(false);
                    break;
                case 1:
                    webBtn(true);
                    break;
                default:
                    break;
            }
        }

        private void BtnJsonBackup_Click(object sender, EventArgs e)
        {
            JsonDataOperation.BackupToJson();
        }
        private void BtnJsonRestore_Click(object sender, EventArgs e)
        {
            List<string> etkilenmeyenKayitlar = new List<string>();
            List<parola> parolas = JsonDataOperation.GetAllParolaFromJson();
            if (parolas != null)
            {
                //MessageBox.Show("Koleksiyon json içerisinden alınmıştır.");
                foreach (var parola in parolas)
                {
                    //gelen koleksiyondaki verileri veritabanına kaydetmek için kod yazılabilir.
                    //ilgili değer kayıt ve update işlemleri yapılacaktır. 
                    //business tarafında metotlar oluşturulup eklenecek..
                    string etkilenmeyenKayit=_bll.RestoreFromJsonToSql(parola);
                    if (etkilenmeyenKayit!="")
                    {
                        etkilenmeyenKayitlar.Add(etkilenmeyenKayit);
                    }
                   
                }
                MessageBox.Show("Restore işlemi bitmiştir...");
                RestoreKayitlar restoreKayitlar = new RestoreKayitlar(etkilenmeyenKayitlar);
                restoreKayitlar.Show();
            }
            else
            {
                //koleksiyon null değerde geldiği için herhangi bir işlem yapmıyoruz.
                MessageBox.Show("Koleksiyon null değer almıştır.İlgili json dosyasından herhangi bir değer AKTARILAMAMIŞTIR.");
            }
            Listele();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Güncelleme işlemi (Yes)\nYeni Kayıt (No)\nİptal (Cancel) ?", "İşlem Seçiniz.", MessageBoxButtons.YesNoCancel);
            ParolaEdit parolaEdit;
            if (dr == DialogResult.Yes)
            {
                //guncelleme işlemi
                parola parola = lbxParolaListe.SelectedItem as parola;
                parolaEdit = new ParolaEdit(parola, Operations.Update);
                parolaEdit.ShowDialog();
            }
            else if (dr == DialogResult.Cancel)
            {
                //iptal işlemi 
            }
            else
            {
                //yeni kayıt işlemi
                parolaEdit = new ParolaEdit(null, Operations.Save);
                parolaEdit.ShowDialog();
            }


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            parola parola = lbxParolaListe.SelectedItem as parola;
            ParolaEdit delete = new ParolaEdit(parola, Operations.Delete);
            delete.ShowDialog();

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                //metot içinde açık olan driver nesnesinin quit metodu çalışıyor.
                OpenWeb();
            }
            else if (dr == DialogResult.Cancel)
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

        }


        private void BtnCloseWeb_Click_1(object sender, EventArgs e)
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (driver != null)
            {
                driver.Quit();
            }
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblParola.Text);
        }
    }
}
