using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LanguageWork.Classes
{
    internal class SQLITEDBBase
    {
        internal static readonly SQLiteConnection Db = new($"Data source={Application.StartupPath}\\Database\\Language.db;Versiyon=3");
        internal static bool QuestionGet(LabelControl question, LabelControl Lbl_trueAnswer, SimpleButton btn1, SimpleButton btn2, SimpleButton btn3, SimpleButton btn4, LabelControl questionCount, string sqlCountValues, string sqlCommand)
        {
            byte i = 0;
            int oldRandomID = 0;
            bool questionGet = default;
            while (i < 10)
            {
                string value = default;
                Random random1 = new();
                Db.Open();
                SQLiteCommand countValues = new(sqlCountValues, Db);
                try
                {
                    SQLiteDataReader rdCount = countValues.ExecuteReader();
                    while (rdCount.Read())
                        value = rdCount[0].ToString();
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message, "HATALI VERİTABANI İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SQLITEDBBase.Db.Close();
                    return false;
                }
                int randomID = (random1.Next(1, (int.Parse(value)) + 1));
                sqlCommand = sqlCommand.Replace("0", randomID.ToString());
                sqlCommand = sqlCommand.Replace(oldRandomID.ToString(), randomID.ToString());
                oldRandomID = randomID;
                SQLiteCommand cmd = new(sqlCommand, Db);
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    questionGet = true;
                    question.Text = rd[0].ToString();
                    Lbl_trueAnswer.Text = rd[1].ToString();
                    btn1.Text = rd[2].ToString();
                    btn2.Text = rd[3].ToString();
                    btn3.Text = rd[4].ToString();
                    btn4.Text = rd[5].ToString();
                }
                Db.Close();
                if (!questionGet)
                {
                    i++;
                    continue;
                }
                questionCount.Text = (byte.Parse(questionCount.Text) + 1).ToString();
                return true;
            }
            return false;
        }
        internal static bool QuestionImageGet(PictureBox image, LabelControl Lbl_trueAnswer, SimpleButton btn1, SimpleButton btn2, SimpleButton btn3, SimpleButton btn4, LabelControl questionCount, string sqlCountValues, string sqlCommand)
        {
            byte i = 0;
            int oldRandomID = 0;
            while (i < 10)
            {
                string value = default;
                Random random1 = new();
                Db.Open();
                SQLiteCommand countValues = new(sqlCountValues, Db);
                try
                {
                    SQLiteDataReader rdCount = countValues.ExecuteReader();
                    while (rdCount.Read())
                        value = rdCount[0].ToString();
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message, "HATALI VERİTABANI İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SQLITEDBBase.Db.Close();
                    return false;
                }
                int randomID = (random1.Next(1, (int.Parse(value)) + 1));
                sqlCommand = sqlCommand.Replace("0", randomID.ToString());
                sqlCommand = sqlCommand.Replace(oldRandomID.ToString(), randomID.ToString());
                oldRandomID = randomID;
                SQLiteCommand cmd = new(sqlCommand, Db);
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    image.Image = ImageConvert.Base64ToImage(rd[0].ToString());
                    Lbl_trueAnswer.Text = rd[1].ToString();
                    btn1.Text = rd[2].ToString();
                    btn2.Text = rd[3].ToString();
                    btn3.Text = rd[4].ToString();
                    btn4.Text = rd[5].ToString();
                }
                Db.Close();
                if (image.Image is null)
                {
                    i++;
                    continue;
                }
                questionCount.Text = (byte.Parse(questionCount.Text) + 1).ToString();
                return true;
            }
            return false;
        }
        internal static bool SqlLiteDatabaseAdd(string sql)
        {
            Db.Open();
            SQLiteCommand cmd = new(sql, Db);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "HATALI EKLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Db.Close();
                return false;
            }
            Db.Close();
            return true;
        }
        internal static DataTable QuestionGrid(string sql)
        {
            SQLiteDataAdapter da = new(sql, Db);
            DataSet ds = new();
            try
            {
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "HATALI LİSTELEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        internal static bool SqLiteDatabaseDelete(string sql)
        {
            Db.Open();
            SQLiteCommand cmd = new(sql, Db);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "HATALI SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Db.Close();
                return false;
            }
            Db.Close();
            return true;
        }
        internal static bool SqlLiteDatabaseUpdate(string sql)
        {
            Db.Open();
            SQLiteCommand cmd = new(sql, Db);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "HATALI GÜNCELLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Db.Close();
                return false;
            }
            Db.Close();
            return true;
        }
    }
}