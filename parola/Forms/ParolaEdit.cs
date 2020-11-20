using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace parola
{
    public partial class ParolaEdit : Form
    {
        parola _parola;
        Operations _enumOperationName;
        ParolaManager bll;
        public ParolaEdit(parola parola, Operations enumOperationName)
        {
            InitializeComponent();
            _parola = parola;
            _enumOperationName = enumOperationName;
            bll = new ParolaManager();
            CreateSimpleButton(_enumOperationName);
        }
        private void parolaToTextbox()
        {
            //parolaid ataması yapılmadı. parolaid _parola nesnesi içerisinde bulunmakta. 
            //parola nesnesi yapıcı metodun içinde tanımlanmakta . 
            StaticClass.Hata.tryCatch(() =>
            {
                if (_parola == null)
                {
                    throw new Exception("Herhangi bir parola seçimi yapılmadı.");
                }
                txtIsim.Text = _parola.isim;
                txtKullaniciAdi.Text = _parola.kullaniciadi;
                txtParola.Text = _parola.parola_;
                txtAciklama.Text = _parola.aciklama;
                cmbSelenium.Text = _parola.SeleniumMethod;
            });
        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private parola NewParola()
        {
            //eğer true değeri parametre olarak gnderilirse return edilen newparola nesnesi içerine parolaid ataması yapılmakta. 
            if (_enumOperationName == Operations.Save)
            {
                _parola = new parola();
                _parola.aciklama = txtAciklama.Text;
                _parola.isim = txtIsim.Text;
                _parola.kullaniciadi = txtKullaniciAdi.Text;
                _parola.parola_ = txtParola.Text;
                _parola.SeleniumMethod = cmbSelenium.Text;
            }
            else if (_enumOperationName == Operations.Update || _enumOperationName == Operations.Delete)
            {
                _parola.aciklama = txtAciklama.Text;
                _parola.isim = txtIsim.Text;
                _parola.kullaniciadi = txtKullaniciAdi.Text;
                _parola.parola_ = txtParola.Text;
                _parola.parolaid = _parola.parolaid;
                _parola.SeleniumMethod = cmbSelenium.Text;
            }
            return _parola;
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            //Guncelleme işlemi
            StaticClass.Hata.tryCatch(() =>
            {
                parola newParola = NewParola();
                if (_enumOperationName == Operations.Update) bll.Update(newParola);
                else if (_enumOperationName == Operations.Save) bll.Save(newParola);
                else if (_enumOperationName == Operations.Delete) bll.Delete(newParola);
                if (_enumOperationName != Operations.Delete)
                {
                    Form form1 = Application.OpenForms["Anasayfa"];
                    ((TextBox)form1.Controls["txtArama"]).Text = " ";
                    ((TextBox)form1.Controls["txtArama"]).Text = newParola.isim;
                    List<parola> parolalar = bll.GetAll();
                    GroupBox liste = form1.Controls["grpbxListe"] as GroupBox;
                    Label kayitSayisi = liste.Controls["lblToplamKayitSayisi"] as Label;
                    kayitSayisi.Text = parolalar.Count.ToString();
                }
                else
                {
                    Form frm = Application.OpenForms["Anasayfa"];
                    bll = new ParolaManager();
                    GroupBox grpbx = frm.Controls["grpbxListe"] as GroupBox;
                    ListBox lstbox = grpbx.Controls["lblParolaListe"] as ListBox;
                    List<parola> parolalar = bll.GetAll();
                    lstbox.DataSource = parolalar;
                    Label kayitSayisi = grpbx.Controls["lblToplamKayitSayisi"] as Label;
                    kayitSayisi.Text = parolalar.Count.ToString();
                }
                this.Close();
            });
        }
        private void CreateSimpleButton(Operations _enumOperationName)
        {
            ReflectionSelenium reflectionSelenium = new ReflectionSelenium();
            var liste = reflectionSelenium.methodInfos();
            foreach (var item in liste)
            {
                cmbSelenium.Items.Add(item);
            }
            if (_enumOperationName == Operations.Update)
            {
                parolaToTextbox();
                btn_Update.Text = "Güncelle".ToUpper();
                lblMesaj.Text = "Güncellemek istediğiniz kayıt bilgileri".ToUpper();
            }
            else if (_enumOperationName == Operations.Save)
            {
                btn_Update.Text = "kaydet".ToUpper();
                lblMesaj.Text = "Kaydetmek istediğiniz kayıt bilgileri".ToUpper();
            }
            else if (_enumOperationName == Operations.Delete)
            {
                parolaToTextbox();
                btn_Update.Text = "sil".ToUpper();
                lblMesaj.Text = "Silmek istediğiniz kayıt bilgileri".ToUpper();
            }
        }
    }
}
