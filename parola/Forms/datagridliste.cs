using Microsoft.Office.Interop.Excel;
using parola.Business.Abstract;
using parola.Business.DependencyResolvers.Ninject;
using parola.Utilities;
using System;
using System.Windows.Forms;
namespace parola
{
    public partial class datagridliste : Form
    {
        IParolaService _bll;
        public datagridliste()
        {
            InitializeComponent();
            _bll = InstanceFactory.GetInstance<IParolaService>();
        }
        private void exceleaktar_Click(object sender, EventArgs e)
        {
            DialogResult soru = new DialogResult();
            soru = MessageBoxOperation.MessageBoxQuestion("Tablodaki veriler EXCEL'e aktarılacak . Devam etmek istiyor musunuz.");
            Hata.tryCatch(() =>
            {
                if (soru == DialogResult.Yes)
                {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = true;
                    object Missing = Type.Missing;
                    Workbook workbook = excel.Workbooks.Add(Missing);
                    Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                    int StartCol = 1;
                    int StartRow = 1;
                    for (int j = 0; j < dgwParolaListe.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                        myRange.Value2 = dgwParolaListe.Columns[j].HeaderText;
                    }
                    StartRow++;
                    for (int i = 0; i < dgwParolaListe.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgwParolaListe.Columns.Count; j++)
                        {
                            Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dgwParolaListe[j, i].Value == null ? "" : dgwParolaListe[j, i].Value;
                            myRange.Select();
                        }
                    }
                }
            });
        }
        private void datagridliste_Load(object sender, EventArgs e)
        {
            this.Text = "Database içerisindeki tüm kayıtlar";
            dgwParolaListe.DataSource = _bll.GetAll();
            dgwParolaListe.Columns["parolaid"].Visible = false;
            lblKayitSayisi.Text = dgwParolaListe.RowCount.ToString();
        }
    }
}
