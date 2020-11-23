using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace parola
{
    public partial class RestoreKayitlar : Form
    {
        List<string> _liste;
        public RestoreKayitlar(List<string> liste)
        {
            InitializeComponent();
            _liste = liste;
        }
        private void RestoreKayitlar_Load(object sender, EventArgs e)
        {
            if (_liste != null)
            {
                listBox1.DataSource = _liste;
                this.Text = _liste.Count.ToString()+" Kayıt";
            }
        }
    }
}
