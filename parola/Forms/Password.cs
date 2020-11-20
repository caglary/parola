using System;
using System.Reflection;
using System.Windows.Forms;
namespace parola.Forms
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text=="4817")
            {
                this.Close();
              
                
            }
            else
            {
                StaticClass.MessageBoxOperation.MessageBoxError("Hatalı parola girdiniz.");
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }
        private void Password_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }
    }
}
