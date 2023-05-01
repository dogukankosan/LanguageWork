using DevExpress.XtraEditors;
using LanguageWork.Classes;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LanguageWork.Forms
{
    public partial class GeneralChart : DevExpress.XtraEditors.XtraForm
    {
        public GeneralChart()
        {
            InitializeComponent();
        }
        internal string sql = default;
        private FolderBrowserDialog fr = new();
        private void Chart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void Chart_Load(object sender, System.EventArgs e)
        {
            SQLITEDBBase.Db.Open();
            SQLiteCommand cmd = new(sql, SQLITEDBBase.Db);
            try
            {
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    chartControl1.Series[0].Points.AddPoint(rd[0].ToString(), int.Parse(rd[1].ToString()));
                    chartControl1.Series[0].Points.AddPoint(rd[2].ToString(), int.Parse(rd[3].ToString()));
                }
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "HATALI VERİTABANI İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLITEDBBase.Db.Close();
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.ChartExport(chartControl1, fr.SelectedPath, "Chart.xlsx");
        }
        private void pdfAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.ChartExport(chartControl1, fr.SelectedPath, "Chart.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.ChartExport(chartControl1, fr.SelectedPath, "Chart.html");
        }
    }
}