using DevExpress.XtraEditors;
using LanguageWork.Classes;
using System;
using System.Windows.Forms;

namespace LanguageWork.Forms
{
    public partial class TextSpeechAddDeleteUpdate : DevExpress.XtraEditors.XtraForm
    {
        public TextSpeechAddDeleteUpdate()
        {
            InitializeComponent();
        }
        string id = default;
        private void Clear()
        {
            foreach (Control item in groupControl1.Controls)
            {
                if (item is RichTextBox)
                    item.Text = null;
            }
            id = null;
            Cmb_Language.Text = null;
        }
        private void Add()
        {
            if (DatabaseControl.sqliteTextSpeechDatabaseControl(Rch_LanguageText, Rch_TurkishText, Cmb_Language))
            {
                if (XtraMessageBox.Show("METİN EKLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "EKLEME İŞLEMİ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SQLITEDBBase.SqlLiteDatabaseAdd("insert into RandomTextSpeech (SpainOrEnglishText,TurkishText,Language) values ('" + Rch_LanguageText.Text.Trim() + "','" + Rch_TurkishText.Text.Trim() + "'," + Cmb_Language.SelectedIndex + ")"))
                    {
                        XtraMessageBox.Show("METİN EKLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                        gridControl1.DataSource =
                            SQLITEDBBase.QuestionGrid("select ID,SpainOrEnglishText as 'METIN',TurkishText AS 'TURKCEMETIN',Language from RandomTextSpeech");
                    }
                }
                else
                    XtraMessageBox.Show("METİN EKLEME İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void UpdateWord()
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (DatabaseControl.sqliteTextSpeechDatabaseControl(Rch_LanguageText, Rch_TurkishText, Cmb_Language))
                {
                    if (XtraMessageBox.Show("METİNİ GÜNCELLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "GÜNCELLEME İŞLEMİ",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (SQLITEDBBase.SqlLiteDatabaseAdd("update  RandomTextSpeech set SpainOrEnglishText='" + Rch_LanguageText.Text.Trim() + "',TurkishText='" + Rch_TurkishText.Text.Trim() + "',Language=" + Cmb_Language.SelectedIndex + " where ID=" + id + ""))
                        {
                            XtraMessageBox.Show("METİNİ GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Clear();
                            gridControl1.DataSource =
                                SQLITEDBBase.QuestionGrid("select ID,SpainOrEnglishText as 'METIN',TurkishText AS 'TURKCEMETIN',Language from RandomTextSpeech");
                        }
                    }
                    else
                        XtraMessageBox.Show("METİNİ GÜNCELLEME İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else
                XtraMessageBox.Show("METİNİ GÜNCELLEME İŞLEMİ HATALI LÜTFEN GÜNCELLENEK KAYDI LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void Delete()
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (XtraMessageBox.Show("METİNİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "SİLME İŞLEMİ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SQLITEDBBase.SqLiteDatabaseDelete("delete from RandomTextSpeech where ID=" + id + ""))
                    {
                        XtraMessageBox.Show("METİNİ SİLME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                        gridControl1.DataSource =
                            SQLITEDBBase.QuestionGrid("select ID,SpainOrEnglishText as 'METIN',TurkishText AS 'TURKCEMETIN',Language from RandomTextSpeech");
                    }
                }
                else
                    XtraMessageBox.Show("METİNİ SİLME İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("METİNİ SİLME İŞLEMİ HATALI LÜTFEN SİLİNECEK KAYDI LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void TextSpeechAddDeleteUpdate_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource =
                SQLITEDBBase.QuestionGrid("select ID,SpainOrEnglishText as 'METIN',TurkishText AS 'TURKCEMETIN',Language from RandomTextSpeech");
            try
            {
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[3].Visible = false;
            }
            catch (Exception)
            {
            }
        }
        private void Btn_Clear_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Btn_Clear, "METİN KUTULARINI TEMİZLE");
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = gridView1.GetFocusedRowCellValue("ID").ToString();
            Rch_LanguageText.Text = gridView1.GetFocusedRowCellValue("METIN").ToString();
            Rch_TurkishText.Text = gridView1.GetFocusedRowCellValue("TURKCEMETIN").ToString();
            Cmb_Language.SelectedIndex = gridView1.GetFocusedRowCellValue("Language").ToString() switch
            {
                "0" => 0,
                "1" => 1,
                _ => 0
            };
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UpdateWord();
        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void TextSpeechAddDeleteUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}