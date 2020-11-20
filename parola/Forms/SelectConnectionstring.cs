using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parola
{
    public partial class SelectConnectionstring : Form
    {

        public SelectConnectionstring()
        {
            InitializeComponent();
        }

        private void BtnLenovo_Click(object sender, EventArgs e)
        {
            ParolaDB.baglantiAdi = "name=ParolaDB";
            DBTarim_kullanicilar.connectionString = "name=DBTarim";
            try
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();

            }
            catch (Exception exception)
            {
                Hata.Logging(exception);
            }

        }


        private void BtnWork_Click(object sender, EventArgs e)
        {

            ParolaDB.baglantiAdi = "Data Source=192.168.1.145; Initial Catalog=parola;User Id=sa;Password=1;";
            DBTarim_kullanicilar.connectionString = "Data Source = 192.168.1.145,1433; Initial Catalog = Db_Tarim; User Id = sa; Password = 1; ";
            try
            {
            
                bool hata = ParolaManager.connectionControl();
                if (!hata)
                {
                    giris giris = new giris();
                    giris.Show();
                    this.Hide();
                }
            }
            catch (Exception exception)
            {
                Hata.Logging(exception);
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
        private void sendmail(string baglantiAdresi)
        {
            try
            {
                string datetime = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                string Icerik = $"{datetime} tarihinde Parola programına giriş yapılmıştır. " + baglantiAdresi + " adresinden bağlantı sağlanmaktadır.";
                SendEmail.emailGonder("caglar.yurdakul60@gmail.com", "merhaba", Icerik);
            }
            catch (Exception exception)
            {

                Hata.Logging(exception);

            }


        }
    }
}
