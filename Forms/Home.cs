using System;

namespace LanguageWork.Forms
{
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        public Home()
        {
            InitializeComponent();
        }
        private EnglishWordExam ex;
        private EnglishWordQuestionAddDeleteUpdate questionAdd;
        private ReportGrid reportGrid;
        private EnglishImageAddDeleteUpdate addDeleteUpdate;
        private EnglishQuestionImageExam questionImage;
        private GeneralChart chart;
        private SpainWordAddDeleteUpdate spainAddDeleteUpdate;
        private Settings settings;
        private SpainQuestionImageExam spainQuestionImageExam;
        private SpianImageAddDeleteUpdate spianImageAddDeleteUpdate;
        private SpainWordExam spainWordExam;
        private TextLanguageSpeech languageSpeech;
        private TextSpeechAddDeleteUpdate speechAddDeleteUpdate;
        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void Btn_Settings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (settings is null || settings.IsDisposed)
            {
                settings = new() { MdiParent = this };
                settings.Show();
            }
        }
        private void Btn_SpianImageAddDeleteUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (spianImageAddDeleteUpdate is null || spianImageAddDeleteUpdate.IsDisposed)
            {
                spianImageAddDeleteUpdate = new() { MdiParent = this };
                spianImageAddDeleteUpdate.Show();
            }
        }
        private void Btn_SpainWordReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (reportGrid is null || reportGrid.IsDisposed)
            {
                reportGrid = new() { MdiParent = this };
                reportGrid.Text = "Kelime Sınavı Raporu";
                reportGrid.sql = "select ID,SUM(TrueCount) as 'DOGRUSAYISI',SUM(FalseCount) as 'YANLISSAYISI',_Date as 'TARIH' from SpainResultWord group by _Date";
                reportGrid.Show();
            }
        }
        private void Btn_SpainImageReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (reportGrid is null || reportGrid.IsDisposed)
            {
                reportGrid = new() { MdiParent = this };
                reportGrid.sql = "select ID,SUM(TrueCount) as 'DOGRUSAYISI',SUM(FalseCount) as 'YANLISSAYISI',_Date as 'TARIH' from SpainResultImage group by _Date";
                reportGrid.Text = "Resim Sınavı Raporu";
                reportGrid.Show();
            }
        }
        private void Btn_SpainWordChart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chart is null || chart.IsDisposed)
            {
                chart = new() { MdiParent = this };
                chart.sql = "select 'DOĞRU SAYISI',SUM(TrueCount),'YANLIŞ SAYISI',SUM(FalseCount) from SpainResultWord";
                chart.Text = "Kelime Sınavı Raporu";
                chart.Show();
            }
        }
        private void Btn_SpainPictureChart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chart is null || chart.IsDisposed)
            {
                chart = new() { MdiParent = this };
                chart.sql = "select 'DOĞRU SAYISI',SUM(TrueCount),'YANLIŞ SAYISI',SUM(FalseCount) from SpainResultImage";
                chart.Text = "Resim Sınavı Raporu";
                chart.Show();
            }
        }
        private void Btn_EnglishPictureChart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chart is null || chart.IsDisposed)
            {
                chart = new() { MdiParent = this };
                chart.sql = "select 'DOĞRU SAYISI',SUM(TrueCount),'YANLIŞ SAYISI',SUM(FalseCount) from EnglishResultImage";
                chart.Text = "Resim Sınavı Raporu";
                chart.Show();
            }
        }
        private void Btn_EnglishWordChart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chart is null || chart.IsDisposed)
            {
                chart = new() { MdiParent = this };
                chart.sql = "select 'DOĞRU SAYISI',SUM(TrueCount),'YANLIŞ SAYISI',SUM(FalseCount) from EnglishResultWord";
                chart.Text = "Kelime Sınavı Raporu";
                chart.Show();
            }
        }
        private void Btn_EnglishImageReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (reportGrid is null || reportGrid.IsDisposed)
            {
                reportGrid = new() { MdiParent = this };
                reportGrid.sql = "select ID,SUM(TrueCount) as 'DOGRUSAYISI',SUM(FalseCount) as 'YANLISSAYISI',_Date as 'TARIH' from EnglishResultImage group by _Date";
                reportGrid.Text = "Resim Sınavı Raporu";
                reportGrid.Show();
            }
        }
        private void Btn_EnglishWordReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (reportGrid is null || reportGrid.IsDisposed)
            {
                reportGrid = new() { MdiParent = this };
                reportGrid.Text = "Kelime Sınavı Raporu";
                reportGrid.sql = "select ID,SUM(TrueCount) as 'DOGRUSAYISI',SUM(FalseCount) as 'YANLISSAYISI',_Date as 'TARIH' from EnglishResultWord group by _Date";
                reportGrid.Show();
            }
        }
        private void Btn_EnglishExam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ex is null || ex.IsDisposed)
            {
                ex = new() { MdiParent = this };
                ex.Show();
            }
        }
        private void Btn_EnglishWordQuestionAddDeleteUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (questionAdd is null || questionAdd.IsDisposed)
            {
                questionAdd = new() { MdiParent = this };
                questionAdd.Show();
            }
        }
        private void Btn_EnglishQuestionImageExam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (questionImage is null || questionImage.IsDisposed)
            {
                questionImage = new() { MdiParent = this };
                questionImage.Show();
            }
        }
        private void Btn_EnglishImageAddDeleteUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (addDeleteUpdate is null || addDeleteUpdate.IsDisposed)
            {
                addDeleteUpdate = new() { MdiParent = this };
                addDeleteUpdate.Show();
            }
        }
        private void Btn_SpainWordExam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (spainWordExam is null || spainWordExam.IsDisposed)
            {
                spainWordExam = new() { MdiParent = this };
                spainWordExam.Show();
            }
        }
        private void Btn_SpainWordQuestionAddDeleteUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (spainAddDeleteUpdate is null || spainAddDeleteUpdate.IsDisposed)
            {
                spainAddDeleteUpdate = new() { MdiParent = this };
                spainAddDeleteUpdate.Show();
            }
        }
        private void Btn_SpainImageExam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (spainQuestionImageExam is null || spainQuestionImageExam.IsDisposed)
            {
                spainQuestionImageExam = new() { MdiParent = this };
                spainQuestionImageExam.Show();
            }
        }
        private void Btn_TextSpeech_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (languageSpeech is null || languageSpeech.IsDisposed)
            {
                languageSpeech = new() { MdiParent = this };
                languageSpeech.Show();
            }
        }
        private void Btn_TextSpeechAddDeleteUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (speechAddDeleteUpdate is null || speechAddDeleteUpdate.IsDisposed)
            {
                speechAddDeleteUpdate = new() { MdiParent = this };
                speechAddDeleteUpdate.Show();
            }
        }
    }
}