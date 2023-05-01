using DevExpress.XtraEditors;
using LanguageWork.Classes;
using System;
using System.Collections;
using System.Data.SQLite;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace LanguageWork.Forms
{
    public partial class TextLanguageSpeech : DevExpress.XtraEditors.XtraForm
    {
        public TextLanguageSpeech()
        {
            InitializeComponent();
        }
        SpeechSynthesizer ss = new()
        {
            Volume = 70
        };
        private void TextGet(string languageID)
        {
            ArrayList arrayID = new();
            Random random = new();
            byte timeOut = 0;
            SQLITEDBBase.Db.Open();
            SQLiteCommand cmd = new("select ID from RandomTextSpeech", SQLITEDBBase.Db);
            SQLiteDataReader rd2 = cmd.ExecuteReader();
            while (rd2.Read())
                arrayID.Add(rd2[0].ToString());
            try
            {
                do
                {
                    SQLiteCommand cmd2 = new("select SpainOrEnglishText,TurkishText from RandomTextSpeech where ID=" + arrayID[random.Next(0, arrayID.Count)] + " and Language=" + languageID + "", SQLITEDBBase.Db);
                    SQLiteDataReader rd = cmd2.ExecuteReader();
                    while (rd.Read())
                    {
                        Rch_TextSpeech.Text = rd[0] as string;
                        Rch_TurkeyText.Text = rd[1] as string;
                    }
                    timeOut++;
                } while (string.IsNullOrEmpty(Rch_TextSpeech.Text) && timeOut < 16);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "HATALI VERİTABANI İŞLEMİ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                SQLITEDBBase.Db.Close();
                return;
            }
            SQLITEDBBase.Db.Close();
        }
        private void TextLanguageSpeech_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void Btn_VoiceEnglish_MouseHover(object sender, System.EventArgs e)
        {
            toolTip1.SetToolTip(Btn_VoiceEnglish, "İNGİLİZCE OLARAK OKU");
        }
        private void Btn_VoiceSpain_MouseHover(object sender, System.EventArgs e)
        {
            toolTip1.SetToolTip(Btn_VoiceSpain, "İSPANYOLCA OLARAK OKU");
        }
        private void TextLanguageSpeech_Load(object sender, System.EventArgs e)
        {

        }
        private void Btn_RandomSpainText_Click(object sender, EventArgs e)
        {
            Rch_TextSpeech.Text = null;
            Rch_TurkeyText.Text = null;
            Lbl_Language.Text = "İSPANYOLCA";
            ss.SpeakAsyncCancelAll();
            TextGet("1");
        }
        private void Btn_RandomEnglishText_Click(object sender, EventArgs e)
        {
            Rch_TextSpeech.Text = null;
            Rch_TurkeyText.Text = null;
            Lbl_Language.Text = "İNGİLİZCE";
            ss.SpeakAsyncCancelAll();
            TextGet("0");
        }
        private void Btn_VoiceEnglish_Click(object sender, EventArgs e)
        {
            ss.SpeakAsyncCancelAll();
            ss.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen, 0, new System.Globalization.CultureInfo("en-US"));
            ss.SpeakAsync(Rch_TextSpeech.Text);
        }
        private void Btn_VoiceSpain_Click(object sender, EventArgs e)
        {
            ss.SpeakAsyncCancelAll();
            ss.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen, 0, new System.Globalization.CultureInfo("es-ES"));
            ss.SpeakAsync(Rch_TextSpeech.Text);
        }
        private void trackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
            ss.Rate = trackBarControl1.Value;
        }
        private void trackBarControl1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBarControl1, "OKUMA HIZI AYARLA");
        }
        private void Btn_SpeakClear_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Btn_SpeakClear, "SESLİ OKUMAYI KAPAT");
        }
        private void Btn_SpeakClear_Click(object sender, EventArgs e)
        {
            ss.SpeakAsyncCancelAll();
        }
    }
}