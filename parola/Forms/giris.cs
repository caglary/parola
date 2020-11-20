using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parola
{
    public partial class giris : Form
    {
        ParolaManager _bll;
        public giris()
        {
            InitializeComponent();
            _bll = new ParolaManager();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void giris_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnGiris;
           

        }

        private void butoncikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string parola = _bll.GetParola("parola");
            if (parola == textBox1.Text)
            {
                Form1 frm = new Form1();
                this.Hide();
                frm.Show();
            }
        }
    }
}
