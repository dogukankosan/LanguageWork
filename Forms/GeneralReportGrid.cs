using LanguageWork.Classes;
using System;
using System.Windows.Forms;

namespace LanguageWork.Forms
{
    public partial class ReportGrid : DevExpress.XtraEditors.XtraForm
    {
        public ReportGrid()
        {
            InitializeComponent();
        }
        internal string sql = default;
        private void WordReport_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = SQLITEDBBase.QuestionGrid(
                sql);
            try
            {
                gridView1.Columns[0].Visible = false;
            }
            catch (Exception)
            {
            }
        }
        private void ReportGrid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private FolderBrowserDialog fr = new();
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "Grid.xlsx");
        }
        private void pdfAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "Grid.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "Grid.html");
        }
    }
}