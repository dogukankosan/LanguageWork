using DevExpress.XtraEditors;
using LanguageWork.Classes;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace LanguageWork.Forms
{
    public partial class EnglishQuestionImageExam : DevExpress.XtraEditors.XtraForm
    {
        public EnglishQuestionImageExam()
        {
            InitializeComponent();
        }
        private byte timerValue = default, timerSleep = 3;
        private bool formClosed = default;
        private void TimerVariable()
        {
            SQLITEDBBase.Db.Open();
            SQLiteCommand cmd = new("select QuestionTimer from Settings where ID=1 ", SQLITEDBBase.Db);
            try
            {
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                    timerValue = byte.Parse(rd[0].ToString());
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "HATALI VERİTABANI İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLITEDBBase.Db.Close();
        }
        private void BtnEnabled(bool values)
        {
            Btn_A.Enabled = values;
            Btn_B.Enabled = values;
            Btn_C.Enabled = values;
            Btn_D.Enabled = values;
        }
        private void BtnBGChange(Color color)
        {
            Btn_A.Appearance.BackColor = color;
            Btn_B.Appearance.BackColor = color;
            Btn_C.Appearance.BackColor = color;
            Btn_D.Appearance.BackColor = color;
        }
        private void NewQuestion(SimpleButton btn)
        {
            BtnBGChange(Color.Red);
            if (Lbl_TrueAnswer.Text == btn.Text)
            {
                btn.Appearance.BackColor = Color.Green;
                Lbl_TrueCount.Text = (byte.Parse(Lbl_TrueCount.Text) + 1).ToString();
                axWindowsMediaPlayer1.URL = Application.StartupPath + "\\Music\\Doğru ses efekti.mp3";
            }
            else
            {
                Lbl_FalseCount.Text = (byte.Parse(Lbl_FalseCount.Text) + 1).ToString();
                Lbl_TrueAnswer.Visible = true;
                Lbl_TrueLabel.Visible = true;
                axWindowsMediaPlayer1.URL = Application.StartupPath + "\\Music\\YANLIŞ CEVAP SESİ.mp3";
            }
            BtnEnabled(false);
            timer2.Enabled = true;
            timer1.Stop();
            timer2.Start();
        }
        private void Btn_A_Click(object sender, System.EventArgs e)
        {
            NewQuestion(Btn_A);
        }
        private void Btn_B_Click(object sender, System.EventArgs e)
        {
            NewQuestion(Btn_B);
        }
        private void Btn_C_Click(object sender, System.EventArgs e)
        {
            NewQuestion(Btn_C);
        }
        private void Btn_D_Click(object sender, System.EventArgs e)
        {
            NewQuestion(Btn_D);
        }
        private void Btn_Start_Click(object sender, System.EventArgs e)
        {
            if (SQLITEDBBase.QuestionImageGet(pictureBox1, Lbl_TrueAnswer, Btn_A, Btn_B, Btn_C, Btn_D, Lbl_QuestionCount, "select count(ID) from EnglishImageQuestion", "select ImageQuestions,TrueAnswer,A,B,C,D from EnglishImageQuestion where ID=0") == false)
                return;
            TimerVariable();
            formClosed = true;
            Btn_Start.Enabled = false;
            BtnEnabled(true);
            timer1.Enabled = true;
            timer1.Start();
            Lbl_TrueCount.Text = "0";
            Lbl_QuestionCount.Text = "0";
            Lbl_FalseCount.Text = "0";
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            Lbl_Time.Text = timerValue.ToString();
            if (timerValue == 0)
            {
                timer1.Stop();
                BtnEnabled(false);
                Btn_Start.Enabled = true;
                formClosed = false;
                timerValue = default;
                SQLITEDBBase.SqlLiteDatabaseAdd("insert into EnglishResultImage (TrueCount,FalseCount,_Date) values (" + Lbl_TrueCount.Text + "," + Lbl_FalseCount.Text + ",'" + DateTime.Now.ToString("d") + "') ");
                XtraMessageBox.Show("SÜRENİZ BİTMİŞTİR RESİM ÇALIŞMASI TAMAMLANMIŞTIR !!", "SÜRE TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            timerValue--;
        }
        private void timer2_Tick(object sender, System.EventArgs e)
        {
            timerSleep--;
            if (timerSleep == 0)
            {
                timer2.Stop();
                timerSleep = 3;
                BtnBGChange(Color.White);
                Lbl_TrueAnswer.Visible = false;
                Lbl_TrueLabel.Visible = false;
                BtnEnabled(true);
                SQLITEDBBase.QuestionImageGet(pictureBox1, Lbl_TrueAnswer, Btn_A, Btn_B, Btn_C, Btn_D, Lbl_QuestionCount, "select count(ID) from EnglishImageQuestion", "select ImageQuestions,TrueAnswer,A,B,C,D from EnglishImageQuestion where ID=0");
                timer1.Start();
            }
        }
        private void QuestionImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = formClosed;
        }
        private void QuestionImage_Load(object sender, System.EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            BtnEnabled(false);
            TimerVariable();
        }
    }
}