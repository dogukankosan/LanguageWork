using DevExpress.XtraEditors;
using LanguageWork.Classes;
using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace LanguageWork.Forms
{
    public partial class EnglishImageAddDeleteUpdate : DevExpress.XtraEditors.XtraForm
    {
        public EnglishImageAddDeleteUpdate()
        {
            InitializeComponent();
        }
        private void TrueAnswerSelect()
        {
            trueAnswer = Cmb_True.Text;
            switch (trueAnswer)
            {
                case "A":
                    trueAnswer = Txt_A.Text;
                    break;
                case "B":
                    trueAnswer = Txt_B.Text;
                    break;
                case "C":
                    trueAnswer = Txt_C.Text;
                    break;
                case "D":
                    trueAnswer = Txt_D.Text;
                    break;
            }
        }
        private string trueAnswer = default, id = default;
        private void Clear()
        {
            foreach (Control item in groupControl1.Controls)
            {
                if (item is TextEdit)
                    item.Text = null;
            }
            Cmb_True.Text = null;
            trueAnswer = null;
            Pct_Question.Image = null;
            id = null;
        }
        private void Add()
        {
            if (DatabaseControl.sqliteDatabaseControlImage(Pct_Question, Txt_A, Txt_B, Txt_C, Txt_D, Cmb_True))
            {
                if (XtraMessageBox.Show("SORU EKLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "EKLEME İŞLEMİ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SQLITEDBBase.SqlLiteDatabaseAdd("insert into EnglishImageQuestion(ImageQuestions,A,B,C,D,TrueAnswer) values('" + ImageConvert.ImageToBase64(Pct_Question.Image, ImageFormat.Jpeg) + "', '" + Txt_A.Text.Trim().ToUpper() + "', '" + Txt_B.Text.Trim().ToUpper() + "', '" + Txt_C.Text.Trim().ToUpper() + "', '" + Txt_D.Text.Trim().ToUpper() + "', '" + trueAnswer.Trim().ToUpper() + "')"))
                    {
                        XtraMessageBox.Show("SORU EKLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                        gridControl1.DataSource = SQLITEDBBase.QuestionGrid(
                            "select ID,ImageQuestions AS 'SORU',A,B,C,D,TrueAnswer as 'DOGRUCEVAP' from EnglishImageQuestion");
                    }
                }
                else
                    XtraMessageBox.Show("SORU EKLEME İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void UpdateWord()
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (DatabaseControl.sqliteDatabaseControlImage(Pct_Question, Txt_A, Txt_B, Txt_C, Txt_D, Cmb_True))
                {
                    if (XtraMessageBox.Show("SORU GÜNCELLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "GÜNCELLEME İŞLEMİ",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        TrueAnswerSelect();
                        if (SQLITEDBBase.SqlLiteDatabaseUpdate("update EnglishImageQuestion set ImageQuestions='" + ImageConvert.ImageToBase64(Pct_Question.Image, ImageFormat.Jpeg) + "',A='" + Txt_A.Text.Trim().ToUpper() + "',B='" + Txt_B.Text.Trim().ToUpper() + "',C='" + Txt_C.Text.Trim().ToUpper() + "',D='" + Txt_D.Text.Trim().ToUpper() + "',TrueAnswer='" + trueAnswer + "' where ID=" + id + ""))
                        {
                            XtraMessageBox.Show("SORU GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Clear();
                            gridControl1.DataSource = SQLITEDBBase.QuestionGrid(
                                "select ID,ImageQuestions AS 'SORU',A,B,C,D,TrueAnswer as 'DOGRUCEVAP' from EnglishImageQuestion");
                        }
                    }
                    else
                        XtraMessageBox.Show("SORU GÜNCELLEME İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else
                XtraMessageBox.Show("SORU GÜNCELLEME İŞLEMİ HATALI LÜTFEN GÜNCELLENEK KAYDI LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void Delete()
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (XtraMessageBox.Show("SORU SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "SİLME İŞLEMİ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SQLITEDBBase.SqLiteDatabaseDelete("delete from EnglishImageQuestion where ID=" + id + ""))
                    {
                        XtraMessageBox.Show("SORU SİLME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                        gridControl1.DataSource = SQLITEDBBase.QuestionGrid(
                            "select ID,ImageQuestions AS 'SORU',A,B,C,D,TrueAnswer as 'DOGRUCEVAP' from EnglishImageQuestion");
                    }
                }
                else
                    XtraMessageBox.Show("SORU SİLME İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("SORU SİLME İŞLEMİ HATALI LÜTFEN SİLİNECEK KAYDI LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void Btn_Save_Click(object sender, System.EventArgs e)
        {
            Add();
        }
        private void Btn_Update_Click(object sender, System.EventArgs e)
        {
            UpdateWord();
        }
        private void Btn_Delete_Click(object sender, System.EventArgs e)
        {
            Delete();
        }
        private void ImageAddDeleteUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void ImageAddDeleteUpdate_Load(object sender, System.EventArgs e)
        {
            gridControl1.DataSource = SQLITEDBBase.QuestionGrid(
                "select ID,ImageQuestions AS 'SORU',A,B,C,D,TrueAnswer as 'DOGRUCEVAP' from EnglishImageQuestion");
            try
            {
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[1].Visible = false;
            }
            catch (Exception)
            {
            }
        }
        private void Txt_A_TextChanged(object sender, System.EventArgs e)
        {
            Txt_A.Text = DatabaseControl.turkishCharterReplace(Txt_A);
        }
        private void Txt_B_TextChanged(object sender, System.EventArgs e)
        {
            Txt_B.Text = DatabaseControl.turkishCharterReplace(Txt_B);
        }
        private void Txt_C_TextChanged(object sender, System.EventArgs e)
        {
            Txt_C.Text = DatabaseControl.turkishCharterReplace(Txt_C);
        }
        private void Txt_D_TextChanged(object sender, System.EventArgs e)
        {
            Txt_D.Text = DatabaseControl.turkishCharterReplace(Txt_D);
        }
        private void Cmb_True_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            TrueAnswerSelect();
        }
        private void Txt_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void Btn_Clear_Click(object sender, System.EventArgs e)
        {
            Clear();
        }
        private void Btn_Clear_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Btn_Clear, "METİN KUTULARINI TEMİZLE");
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = gridView1.GetFocusedRowCellValue("ID").ToString();
            Pct_Question.Image = ImageConvert.Base64ToImage(gridView1.GetFocusedRowCellValue("SORU").ToString());
            Txt_A.Text = gridView1.GetFocusedRowCellValue("A").ToString();
            Txt_B.Text = gridView1.GetFocusedRowCellValue("B").ToString();
            Txt_C.Text = gridView1.GetFocusedRowCellValue("C").ToString();
            Txt_D.Text = gridView1.GetFocusedRowCellValue("D").ToString();
            if (gridView1.GetFocusedRowCellValue("DOGRUCEVAP").ToString() == Txt_A.Text)
                Cmb_True.Text = "A";
            else if (gridView1.GetFocusedRowCellValue("DOGRUCEVAP").ToString() == Txt_B.Text)
                Cmb_True.Text = "B";
            else if (gridView1.GetFocusedRowCellValue("DOGRUCEVAP").ToString() == Txt_C.Text)
                Cmb_True.Text = "C";
            else if (gridView1.GetFocusedRowCellValue("DOGRUCEVAP").ToString() == Txt_D.Text)
                Cmb_True.Text = "D";
        }
    }
}