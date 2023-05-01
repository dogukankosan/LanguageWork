using DevExpress.XtraEditors;
using LanguageWork.Classes;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LanguageWork.Forms
{
    public partial class Settings : DevExpress.XtraEditors.XtraForm
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void Btn_Update_Click(object sender, System.EventArgs e)
        {
            SQLITEDBBase.Db.Open();
            SQLiteCommand cmd = new("update Settings set QuestionTimer=" + numericUpDown1.Value + " where ID=1 ", SQLITEDBBase.Db);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "HATALI VERİTABANI İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SQLITEDBBase.Db.Close();
                return;
            }
            SQLITEDBBase.Db.Close();
            XtraMessageBox.Show("AYARLARI GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Settings_Load(object sender, System.EventArgs e)
        {
            SQLITEDBBase.Db.Open();
            SQLiteCommand cmd = new("select QuestionTimer from Settings where ID=1 ", SQLITEDBBase.Db);
            try
            {
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                    numericUpDown1.Value = int.Parse(rd[0].ToString());
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "HATALI VERİTABANI İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLITEDBBase.Db.Close();
        }
    }
}