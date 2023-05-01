using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace LanguageWork.Classes
{
    internal class DatabaseControl
    {
        private static readonly char[] turkishCharter = new char[6] { 'İ', 'Ğ', 'Ü', 'Ö', 'Ş', 'Ç' };
        internal static string turkishCharterReplace(TextEdit txt)
        {
            return txt.Text.ToUpper().Trim().Replace('İ', 'I').Replace('Ü', 'U').Replace('Ö', 'O').Replace('Ş', 'S')
                .Replace('Ğ', 'G').Replace('Ç', 'C');
        }
        internal static bool sqliteDatabaseControl(TextEdit question, TextEdit a, TextEdit b, TextEdit c, TextEdit d, ComboBoxEdit trueAnswer)
        {
            #region QUESTION
            // NULL OR EMPTY CONTROL
            if (string.IsNullOrEmpty(question.Text))
            {
                XtraMessageBox.Show("SORU METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                question.Focus();
                return false;
            }
            // LENGTH CONTROL
            if (question.Text.Length > 30 || question.Text.Length < 2)
            {
                XtraMessageBox.Show("SORU METİN KUTUSU 30 KARAKTERDEN FAZLA OLAMAZ VEYA 3 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                question.Focus();
                return false;
            }
            // TURKISH CHARTER CONTROL
            for (byte i = 0; i < turkishCharter.Length; i++)
            {
                if (question.Text.ToUpper().Contains(turkishCharter[i].ToString()))
                {
                    XtraMessageBox.Show("SORU METİN KUTUSUNDA TÜRKÇE KARAKTER OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    question.Focus();
                    return false;
                }
            }
            // CHAR IS NUMBER CONTROL
            for (byte i = 0; i < question.Text.Length; i++)
            {
                if (char.IsNumber(question.Text[i]))
                {
                    XtraMessageBox.Show("SORU METİN KUTUSUNDA RAKAM KARAKTERİ OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    question.Focus();
                    return false;
                }
            }
            #endregion
            #region A
            // NULL OR EMPTY CONTROL
            if (string.IsNullOrEmpty(a.Text))
            {
                XtraMessageBox.Show("A METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                a.Focus();
                return false;
            }
            // LENGTH CONTROL
            if (a.Text.Length > 30 || a.Text.Length < 2)
            {
                XtraMessageBox.Show("A METİN KUTUSU 30 KARAKTERDEN FAZLA OLAMAZ VEYA 3 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                a.Focus();
                return false;
            }
            // CHAR IS NUMBER CONTROL
            for (byte i = 0; i < a.Text.Length; i++)
            {
                if (char.IsNumber(a.Text[i]))
                {
                    XtraMessageBox.Show("A METİN KUTUSUNDA RAKAM KARAKTERİ OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    a.Focus();
                    return false;
                }
            }
            #endregion
            #region B
            // NULL OR EMPTY CONTROL
            if (string.IsNullOrEmpty(b.Text))
            {
                XtraMessageBox.Show("B METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                b.Focus();
                return false;
            }
            // LENGTH CONTROL
            if (b.Text.Length > 30 || b.Text.Length < 2)
            {
                XtraMessageBox.Show("B METİN KUTUSU 30 KARAKTERDEN FAZLA OLAMAZ VEYA 3 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                b.Focus();
                return false;
            }
            // CHAR IS NUMBER CONTROL
            for (byte i = 0; i < b.Text.Length; i++)
            {
                if (char.IsNumber(b.Text[i]))
                {
                    XtraMessageBox.Show("B METİN KUTUSUNDA RAKAM KARAKTERİ OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    b.Focus();
                    return false;
                }
            }
            #endregion
            #region C
            // NULL OR EMPTY CONTROL
            if (string.IsNullOrEmpty(c.Text))
            {
                XtraMessageBox.Show("C METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                c.Focus();
                return false;
            }
            // LENGTH CONTROL
            if (c.Text.Length > 30 || c.Text.Length < 2)
            {
                XtraMessageBox.Show("C METİN KUTUSU 30 KARAKTERDEN FAZLA OLAMAZ VEYA 3 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                c.Focus();
                return false;
            }
            // CHAR IS NUMBER CONTROL
            for (byte i = 0; i < c.Text.Length; i++)
            {
                if (char.IsNumber(c.Text[i]))
                {
                    XtraMessageBox.Show("C METİN KUTUSUNDA RAKAM KARAKTERİ OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    c.Focus();
                    return false;
                }
            }
            #endregion
            #region D
            // NULL OR EMPTY CONTROL
            if (string.IsNullOrEmpty(d.Text))
            {
                XtraMessageBox.Show("D METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                d.Focus();
                return false;
            }
            // LENGTH CONTROL
            if (d.Text.Length > 30 || d.Text.Length < 2)
            {
                XtraMessageBox.Show("D METİN KUTUSU 30 KARAKTERDEN FAZLA OLAMAZ VEYA 3 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                d.Focus();
                return false;
            }
            // CHAR IS NUMBER CONTROL
            for (byte i = 0; i < d.Text.Length; i++)
            {
                if (char.IsNumber(d.Text[i]))
                {
                    XtraMessageBox.Show("D METİN KUTUSUNDA RAKAM KARAKTERİ OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    d.Focus();
                    return false;
                }
            }
            #endregion
            #region TRUEANSWER
            if (string.IsNullOrEmpty(trueAnswer.Text))
            {
                XtraMessageBox.Show("DOĞRU CEVAP SEÇİM KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                trueAnswer.Focus();
                return false;
            }
            #endregion
            return true;
        }
        internal static bool sqliteDatabaseControlImage(PictureEdit img, TextEdit a, TextEdit b, TextEdit c, TextEdit d, ComboBoxEdit trueAnswer)
        {
            #region QUESTIONIMAGE
            // NULL OR EMPTY CONTROL
            if (img.Image is null)
            {
                XtraMessageBox.Show("RESİM SORUSU KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                img.Focus();
                return false;
            }
            #endregion
            #region A
            // NULL OR EMPTY CONTROL
            if (string.IsNullOrEmpty(a.Text))
            {
                XtraMessageBox.Show("A METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                a.Focus();
                return false;
            }
            // LENGTH CONTROL
            if (a.Text.Length > 30 || a.Text.Length < 2)
            {
                XtraMessageBox.Show("A METİN KUTUSU 30 KARAKTERDEN FAZLA OLAMAZ VEYA 3 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                a.Focus();
                return false;
            }
            // CHAR IS NUMBER CONTROL
            for (byte i = 0; i < a.Text.Length; i++)
            {
                if (char.IsNumber(a.Text[i]))
                {
                    XtraMessageBox.Show("A METİN KUTUSUNDA RAKAM KARAKTERİ OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    a.Focus();
                    return false;
                }
            }
            #endregion
            #region B
            // NULL OR EMPTY CONTROL
            if (string.IsNullOrEmpty(b.Text))
            {
                XtraMessageBox.Show("B METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                b.Focus();
                return false;
            }
            // LENGTH CONTROL
            if (b.Text.Length > 30 || b.Text.Length < 2)
            {
                XtraMessageBox.Show("B METİN KUTUSU 30 KARAKTERDEN FAZLA OLAMAZ VEYA 3 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                b.Focus();
                return false;
            }
            // CHAR IS NUMBER CONTROL
            for (byte i = 0; i < b.Text.Length; i++)
            {
                if (char.IsNumber(b.Text[i]))
                {
                    XtraMessageBox.Show("B METİN KUTUSUNDA RAKAM KARAKTERİ OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    b.Focus();
                    return false;
                }
            }
            #endregion
            #region C
            // NULL OR EMPTY CONTROL
            if (string.IsNullOrEmpty(c.Text))
            {
                XtraMessageBox.Show("C METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                c.Focus();
                return false;
            }
            // LENGTH CONTROL
            if (c.Text.Length > 30 || c.Text.Length < 2)
            {
                XtraMessageBox.Show("C METİN KUTUSU 30 KARAKTERDEN FAZLA OLAMAZ VEYA 3 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                c.Focus();
                return false;
            }
            // CHAR IS NUMBER CONTROL
            for (byte i = 0; i < c.Text.Length; i++)
            {
                if (char.IsNumber(c.Text[i]))
                {
                    XtraMessageBox.Show("C METİN KUTUSUNDA RAKAM KARAKTERİ OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    c.Focus();
                    return false;
                }
            }
            #endregion
            #region D
            // NULL OR EMPTY CONTROL
            if (string.IsNullOrEmpty(d.Text))
            {
                XtraMessageBox.Show("D METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                d.Focus();
                return false;
            }
            // LENGTH CONTROL
            if (d.Text.Length > 30 || d.Text.Length < 2)
            {
                XtraMessageBox.Show("D METİN KUTUSU 30 KARAKTERDEN FAZLA OLAMAZ VEYA 3 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                d.Focus();
                return false;
            }
            // CHAR IS NUMBER CONTROL
            for (byte i = 0; i < d.Text.Length; i++)
            {
                if (char.IsNumber(d.Text[i]))
                {
                    XtraMessageBox.Show("D METİN KUTUSUNDA RAKAM KARAKTERİ OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    d.Focus();
                    return false;
                }
            }
            #endregion
            #region TRUEANSWER
            if (string.IsNullOrEmpty(trueAnswer.Text))
            {
                XtraMessageBox.Show("DOĞRU CEVAP SEÇİM KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                trueAnswer.Focus();
                return false;
            }
            #endregion
            return true;
        }
        internal static bool sqliteTextSpeechDatabaseControl(RichTextBox language, RichTextBox turkishBox, ComboBoxEdit languageChoose)
        {
            #region LANGUAGE
            // NULL OR EMPTY CONTROL
            if (string.IsNullOrEmpty(language.Text))
            {
                XtraMessageBox.Show("METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                language.Focus();
                return false;
            }
            // LENGTH CONTROL
            if (language.Text.Length < 2)
            {
                XtraMessageBox.Show("METİN KUTUSU 2 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                language.Focus();
                return false;
            }
            #endregion
            #region TURKISHLANGUAGE
            // NULL OR EMPTY CONTROL
            if (string.IsNullOrEmpty(turkishBox.Text))
            {
                XtraMessageBox.Show("METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                turkishBox.Focus();
                return false;
            }
            // LENGTH CONTROL
            if (turkishBox.Text.Length < 2)
            {
                XtraMessageBox.Show("METİN KUTUSU 2 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                turkishBox.Focus();
                return false;
            }
            #endregion
            #region LANGUAGECHOOSE
            if (string.IsNullOrEmpty(languageChoose.Text))
            {
                XtraMessageBox.Show("DİL SEÇİM KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                languageChoose.Focus();
                return false;
            }
            #endregion
            return true;
        }
    }
}