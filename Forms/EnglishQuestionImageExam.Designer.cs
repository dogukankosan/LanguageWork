
namespace LanguageWork.Forms
{
    partial class EnglishQuestionImageExam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnglishQuestionImageExam));
            this.Lbl_TrueLabel = new DevExpress.XtraEditors.LabelControl();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Time = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lbl_FalseCount = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TrueCount = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_QuestionCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TrueAnswer = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_Start = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_D = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_C = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_B = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_A = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_TrueLabel
            // 
            this.Lbl_TrueLabel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_TrueLabel.Appearance.Options.UseFont = true;
            this.Lbl_TrueLabel.Location = new System.Drawing.Point(304, 157);
            this.Lbl_TrueLabel.Name = "Lbl_TrueLabel";
            this.Lbl_TrueLabel.Size = new System.Drawing.Size(154, 24);
            this.Lbl_TrueLabel.TabIndex = 25;
            this.Lbl_TrueLabel.Text = "DOĞRU CEVAP:";
            this.Lbl_TrueLabel.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Time.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Time.Appearance.Options.UseFont = true;
            this.Lbl_Time.Appearance.Options.UseForeColor = true;
            this.Lbl_Time.Location = new System.Drawing.Point(77, 157);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(9, 17);
            this.Lbl_Time.TabIndex = 22;
            this.Lbl_Time.Text = "0";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(25, 156);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 18);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "SÜRE:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lbl_FalseCount
            // 
            this.Lbl_FalseCount.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_FalseCount.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Lbl_FalseCount.Appearance.Options.UseFont = true;
            this.Lbl_FalseCount.Appearance.Options.UseForeColor = true;
            this.Lbl_FalseCount.Location = new System.Drawing.Point(126, 93);
            this.Lbl_FalseCount.Name = "Lbl_FalseCount";
            this.Lbl_FalseCount.Size = new System.Drawing.Size(9, 17);
            this.Lbl_FalseCount.TabIndex = 7;
            this.Lbl_FalseCount.Text = "0";
            // 
            // Lbl_TrueCount
            // 
            this.Lbl_TrueCount.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_TrueCount.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Lbl_TrueCount.Appearance.Options.UseFont = true;
            this.Lbl_TrueCount.Appearance.Options.UseForeColor = true;
            this.Lbl_TrueCount.Location = new System.Drawing.Point(126, 63);
            this.Lbl_TrueCount.Name = "Lbl_TrueCount";
            this.Lbl_TrueCount.Size = new System.Drawing.Size(9, 17);
            this.Lbl_TrueCount.TabIndex = 6;
            this.Lbl_TrueCount.Text = "0";
            // 
            // Lbl_QuestionCount
            // 
            this.Lbl_QuestionCount.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_QuestionCount.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Lbl_QuestionCount.Appearance.Options.UseFont = true;
            this.Lbl_QuestionCount.Appearance.Options.UseForeColor = true;
            this.Lbl_QuestionCount.Location = new System.Drawing.Point(126, 36);
            this.Lbl_QuestionCount.Name = "Lbl_QuestionCount";
            this.Lbl_QuestionCount.Size = new System.Drawing.Size(9, 17);
            this.Lbl_QuestionCount.TabIndex = 5;
            this.Lbl_QuestionCount.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "DOĞRU SAYISI:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "SORU SAYISI:";
            // 
            // Lbl_TrueAnswer
            // 
            this.Lbl_TrueAnswer.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_TrueAnswer.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Lbl_TrueAnswer.Appearance.Options.UseFont = true;
            this.Lbl_TrueAnswer.Appearance.Options.UseForeColor = true;
            this.Lbl_TrueAnswer.Location = new System.Drawing.Point(471, 159);
            this.Lbl_TrueAnswer.Name = "Lbl_TrueAnswer";
            this.Lbl_TrueAnswer.Size = new System.Drawing.Size(0, 20);
            this.Lbl_TrueAnswer.TabIndex = 24;
            this.Lbl_TrueAnswer.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.Lbl_FalseCount);
            this.groupControl1.Controls.Add(this.Lbl_TrueCount);
            this.groupControl1.Controls.Add(this.Lbl_QuestionCount);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(860, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(212, 123);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "SONUÇLAR";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "YANLIŞ SAYISI:";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.Btn_Start.Appearance.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.Btn_Start.Appearance.Options.UseBackColor = true;
            this.Btn_Start.Appearance.Options.UseFont = true;
            this.Btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Start.Location = new System.Drawing.Point(25, 95);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(178, 40);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "SINAVI BAŞLAT";
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_D
            // 
            this.Btn_D.Appearance.BackColor = System.Drawing.Color.White;
            this.Btn_D.Appearance.Font = new System.Drawing.Font("Tahoma", 28.25F);
            this.Btn_D.Appearance.Options.UseBackColor = true;
            this.Btn_D.Appearance.Options.UseFont = true;
            this.Btn_D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_D.Location = new System.Drawing.Point(702, 429);
            this.Btn_D.Name = "Btn_D";
            this.Btn_D.Size = new System.Drawing.Size(287, 85);
            this.Btn_D.TabIndex = 4;
            this.Btn_D.Text = "D";
            this.Btn_D.Click += new System.EventHandler(this.Btn_D_Click);
            // 
            // Btn_C
            // 
            this.Btn_C.Appearance.BackColor = System.Drawing.Color.White;
            this.Btn_C.Appearance.Font = new System.Drawing.Font("Tahoma", 28.25F);
            this.Btn_C.Appearance.Options.UseBackColor = true;
            this.Btn_C.Appearance.Options.UseFont = true;
            this.Btn_C.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_C.Location = new System.Drawing.Point(93, 429);
            this.Btn_C.Name = "Btn_C";
            this.Btn_C.Size = new System.Drawing.Size(287, 85);
            this.Btn_C.TabIndex = 3;
            this.Btn_C.Text = "C";
            this.Btn_C.Click += new System.EventHandler(this.Btn_C_Click);
            // 
            // Btn_B
            // 
            this.Btn_B.Appearance.BackColor = System.Drawing.Color.White;
            this.Btn_B.Appearance.Font = new System.Drawing.Font("Tahoma", 28.25F);
            this.Btn_B.Appearance.Options.UseBackColor = true;
            this.Btn_B.Appearance.Options.UseFont = true;
            this.Btn_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_B.Location = new System.Drawing.Point(702, 272);
            this.Btn_B.Name = "Btn_B";
            this.Btn_B.Size = new System.Drawing.Size(287, 85);
            this.Btn_B.TabIndex = 2;
            this.Btn_B.Text = "B";
            this.Btn_B.Click += new System.EventHandler(this.Btn_B_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 28.25F);
            this.label3.Location = new System.Drawing.Point(17, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1070, 46);
            this.label3.TabIndex = 17;
            this.label3.Text = "---------------------------------------------------------------------------";
            // 
            // Btn_A
            // 
            this.Btn_A.Appearance.BackColor = System.Drawing.Color.White;
            this.Btn_A.Appearance.Font = new System.Drawing.Font("Tahoma", 28.25F);
            this.Btn_A.Appearance.Options.UseBackColor = true;
            this.Btn_A.Appearance.Options.UseFont = true;
            this.Btn_A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_A.Location = new System.Drawing.Point(93, 272);
            this.Btn_A.Name = "Btn_A";
            this.Btn_A.Size = new System.Drawing.Size(287, 85);
            this.Btn_A.TabIndex = 1;
            this.Btn_A.Text = "A";
            this.Btn_A.Click += new System.EventHandler(this.Btn_A_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(366, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(35, 31);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 27;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // EnglishQuestionImageExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 569);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_TrueLabel);
            this.Controls.Add(this.Lbl_Time);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.Lbl_TrueAnswer);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Btn_D);
            this.Controls.Add(this.Btn_C);
            this.Controls.Add(this.Btn_B);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_A);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("EnglishQuestionImageExam.IconOptions.LargeImage")));
            this.KeyPreview = true;
            this.Name = "EnglishQuestionImageExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resim Sınavı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionImage_FormClosing);
            this.Load += new System.EventHandler(this.QuestionImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Lbl_TrueLabel;
        private System.Windows.Forms.Timer timer2;
        private DevExpress.XtraEditors.LabelControl Lbl_Time;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl Lbl_FalseCount;
        private DevExpress.XtraEditors.LabelControl Lbl_TrueCount;
        private DevExpress.XtraEditors.LabelControl Lbl_QuestionCount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl Lbl_TrueAnswer;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Btn_Start;
        private DevExpress.XtraEditors.SimpleButton Btn_D;
        private DevExpress.XtraEditors.SimpleButton Btn_C;
        private DevExpress.XtraEditors.SimpleButton Btn_B;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton Btn_A;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}