
namespace LanguageWork.Forms
{
    partial class TextLanguageSpeech
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
            DevExpress.XtraEditors.SimpleButton Btn_RandomEnglishText;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextLanguageSpeech));
            DevExpress.XtraEditors.SimpleButton Btn_RandomSpainText;
            this.Rch_TextSpeech = new System.Windows.Forms.RichTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_Language = new DevExpress.XtraEditors.LabelControl();
            this.Rch_TurkeyText = new System.Windows.Forms.RichTextBox();
            this.Btn_SpeakClear = new DevExpress.XtraEditors.SimpleButton();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.Btn_VoiceSpain = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_VoiceEnglish = new DevExpress.XtraEditors.SimpleButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            Btn_RandomEnglishText = new DevExpress.XtraEditors.SimpleButton();
            Btn_RandomSpainText = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_RandomEnglishText
            // 
            Btn_RandomEnglishText.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            Btn_RandomEnglishText.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            Btn_RandomEnglishText.Appearance.ForeColor = System.Drawing.Color.Black;
            Btn_RandomEnglishText.Appearance.Options.UseBackColor = true;
            Btn_RandomEnglishText.Appearance.Options.UseFont = true;
            Btn_RandomEnglishText.Appearance.Options.UseForeColor = true;
            Btn_RandomEnglishText.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_RandomEnglishText.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RandomEnglishText.ImageOptions.Image")));
            Btn_RandomEnglishText.Location = new System.Drawing.Point(602, 36);
            Btn_RandomEnglishText.Name = "Btn_RandomEnglishText";
            Btn_RandomEnglishText.Size = new System.Drawing.Size(278, 32);
            Btn_RandomEnglishText.TabIndex = 1;
            Btn_RandomEnglishText.Text = "RASTGELE İNGİLİZCE METİN GETİR";
            Btn_RandomEnglishText.Click += new System.EventHandler(this.Btn_RandomEnglishText_Click);
            // 
            // Btn_RandomSpainText
            // 
            Btn_RandomSpainText.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            Btn_RandomSpainText.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            Btn_RandomSpainText.Appearance.ForeColor = System.Drawing.Color.Black;
            Btn_RandomSpainText.Appearance.Options.UseBackColor = true;
            Btn_RandomSpainText.Appearance.Options.UseFont = true;
            Btn_RandomSpainText.Appearance.Options.UseForeColor = true;
            Btn_RandomSpainText.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_RandomSpainText.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RandomSpainText.ImageOptions.Image")));
            Btn_RandomSpainText.Location = new System.Drawing.Point(602, 74);
            Btn_RandomSpainText.Name = "Btn_RandomSpainText";
            Btn_RandomSpainText.Size = new System.Drawing.Size(278, 32);
            Btn_RandomSpainText.TabIndex = 3;
            Btn_RandomSpainText.Text = "RASTGELE İSPANYOLCA METİN GETİR";
            Btn_RandomSpainText.Click += new System.EventHandler(this.Btn_RandomSpainText_Click);
            // 
            // Rch_TextSpeech
            // 
            this.Rch_TextSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Rch_TextSpeech.Location = new System.Drawing.Point(2, 33);
            this.Rch_TextSpeech.Name = "Rch_TextSpeech";
            this.Rch_TextSpeech.Size = new System.Drawing.Size(259, 330);
            this.Rch_TextSpeech.TabIndex = 0;
            this.Rch_TextSpeech.Text = "";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.Lbl_Language);
            this.groupControl1.Controls.Add(this.Rch_TurkeyText);
            this.groupControl1.Controls.Add(this.Btn_SpeakClear);
            this.groupControl1.Controls.Add(this.trackBarControl1);
            this.groupControl1.Controls.Add(Btn_RandomSpainText);
            this.groupControl1.Controls.Add(Btn_RandomEnglishText);
            this.groupControl1.Controls.Add(this.Btn_VoiceSpain);
            this.groupControl1.Controls.Add(this.Btn_VoiceEnglish);
            this.groupControl1.Controls.Add(this.Rch_TextSpeech);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(931, 424);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "METİN DİNLEME";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(366, 382);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 24);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "TÜRKÇE";
            // 
            // Lbl_Language
            // 
            this.Lbl_Language.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Language.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Language.Appearance.Options.UseFont = true;
            this.Lbl_Language.Appearance.Options.UseForeColor = true;
            this.Lbl_Language.Location = new System.Drawing.Point(14, 382);
            this.Lbl_Language.Name = "Lbl_Language";
            this.Lbl_Language.Size = new System.Drawing.Size(233, 24);
            this.Lbl_Language.TabIndex = 8;
            this.Lbl_Language.Text = "İNGİLİZCE-İSPANYOLCA";
            // 
            // Rch_TurkeyText
            // 
            this.Rch_TurkeyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Rch_TurkeyText.Location = new System.Drawing.Point(282, 33);
            this.Rch_TurkeyText.Name = "Rch_TurkeyText";
            this.Rch_TurkeyText.ReadOnly = true;
            this.Rch_TurkeyText.Size = new System.Drawing.Size(259, 330);
            this.Rch_TurkeyText.TabIndex = 7;
            this.Rch_TurkeyText.Text = "";
            // 
            // Btn_SpeakClear
            // 
            this.Btn_SpeakClear.Appearance.Font = new System.Drawing.Font("Tahoma", 28.25F);
            this.Btn_SpeakClear.Appearance.Options.UseFont = true;
            this.Btn_SpeakClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SpeakClear.Location = new System.Drawing.Point(886, 115);
            this.Btn_SpeakClear.Name = "Btn_SpeakClear";
            this.Btn_SpeakClear.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btn_SpeakClear.Size = new System.Drawing.Size(40, 35);
            this.Btn_SpeakClear.TabIndex = 6;
            this.Btn_SpeakClear.Click += new System.EventHandler(this.Btn_SpeakClear_Click);
            this.Btn_SpeakClear.MouseHover += new System.EventHandler(this.Btn_SpeakClear_MouseHover);
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.Location = new System.Drawing.Point(602, 323);
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trackBarControl1.Properties.Minimum = -10;
            this.trackBarControl1.Size = new System.Drawing.Size(324, 45);
            this.trackBarControl1.TabIndex = 5;
            this.trackBarControl1.Value = 0;
            this.trackBarControl1.EditValueChanged += new System.EventHandler(this.trackBarControl1_EditValueChanged);
            this.trackBarControl1.MouseHover += new System.EventHandler(this.trackBarControl1_MouseHover);
            // 
            // Btn_VoiceSpain
            // 
            this.Btn_VoiceSpain.Appearance.Font = new System.Drawing.Font("Tahoma", 28.25F);
            this.Btn_VoiceSpain.Appearance.Options.UseFont = true;
            this.Btn_VoiceSpain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_VoiceSpain.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_VoiceSpain.ImageOptions.SvgImage")));
            this.Btn_VoiceSpain.Location = new System.Drawing.Point(886, 74);
            this.Btn_VoiceSpain.Name = "Btn_VoiceSpain";
            this.Btn_VoiceSpain.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btn_VoiceSpain.Size = new System.Drawing.Size(40, 35);
            this.Btn_VoiceSpain.TabIndex = 4;
            this.Btn_VoiceSpain.Click += new System.EventHandler(this.Btn_VoiceSpain_Click);
            this.Btn_VoiceSpain.MouseHover += new System.EventHandler(this.Btn_VoiceSpain_MouseHover);
            // 
            // Btn_VoiceEnglish
            // 
            this.Btn_VoiceEnglish.Appearance.Font = new System.Drawing.Font("Tahoma", 28.25F);
            this.Btn_VoiceEnglish.Appearance.Options.UseFont = true;
            this.Btn_VoiceEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_VoiceEnglish.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_VoiceEnglish.ImageOptions.SvgImage")));
            this.Btn_VoiceEnglish.Location = new System.Drawing.Point(886, 36);
            this.Btn_VoiceEnglish.Name = "Btn_VoiceEnglish";
            this.Btn_VoiceEnglish.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btn_VoiceEnglish.Size = new System.Drawing.Size(40, 35);
            this.Btn_VoiceEnglish.TabIndex = 2;
            this.Btn_VoiceEnglish.Click += new System.EventHandler(this.Btn_VoiceEnglish_Click);
            this.Btn_VoiceEnglish.MouseHover += new System.EventHandler(this.Btn_VoiceEnglish_MouseHover);
            // 
            // TextLanguageSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 524);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TextLanguageSpeech.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TextLanguageSpeech";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metin Dinleme Çalışması";
            this.Load += new System.EventHandler(this.TextLanguageSpeech_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextLanguageSpeech_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rch_TextSpeech;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_VoiceSpain;
        private DevExpress.XtraEditors.SimpleButton Btn_VoiceEnglish;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_SpeakClear;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl Lbl_Language;
        private System.Windows.Forms.RichTextBox Rch_TurkeyText;
    }
}