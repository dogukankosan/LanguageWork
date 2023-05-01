
namespace LanguageWork.Forms
{
    partial class TextSpeechAddDeleteUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextSpeechAddDeleteUpdate));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Rch_TurkishText = new System.Windows.Forms.RichTextBox();
            this.Rch_LanguageText = new System.Windows.Forms.RichTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.Cmb_Language = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Language.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.Rch_TurkishText);
            this.groupControl1.Controls.Add(this.Rch_LanguageText);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.Btn_Clear);
            this.groupControl1.Controls.Add(this.Cmb_Language);
            this.groupControl1.Controls.Add(this.Btn_Delete);
            this.groupControl1.Controls.Add(this.Btn_Update);
            this.groupControl1.Controls.Add(this.Btn_Save);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(388, 378);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "METİN İŞLEMİ";
            // 
            // Rch_TurkishText
            // 
            this.Rch_TurkishText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Rch_TurkishText.Location = new System.Drawing.Point(133, 165);
            this.Rch_TurkishText.Name = "Rch_TurkishText";
            this.Rch_TurkishText.Size = new System.Drawing.Size(190, 98);
            this.Rch_TurkishText.TabIndex = 1;
            this.Rch_TurkishText.Text = "";
            // 
            // Rch_LanguageText
            // 
            this.Rch_LanguageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Rch_LanguageText.Location = new System.Drawing.Point(133, 53);
            this.Rch_LanguageText.Name = "Rch_LanguageText";
            this.Rch_LanguageText.Size = new System.Drawing.Size(190, 98);
            this.Rch_LanguageText.TabIndex = 0;
            this.Rch_LanguageText.Text = "";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 166);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(122, 20);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "TÜRKÇE METİN:";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.Btn_Clear.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Btn_Clear.Appearance.Options.UseBackColor = true;
            this.Btn_Clear.Appearance.Options.UseFont = true;
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Clear.ImageOptions.SvgImage")));
            this.Btn_Clear.Location = new System.Drawing.Point(344, 2);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btn_Clear.Size = new System.Drawing.Size(39, 31);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            this.Btn_Clear.MouseHover += new System.EventHandler(this.Btn_Clear_MouseHover);
            // 
            // Cmb_Language
            // 
            this.Cmb_Language.Location = new System.Drawing.Point(133, 296);
            this.Cmb_Language.Name = "Cmb_Language";
            this.Cmb_Language.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Cmb_Language.Properties.Appearance.Options.UseFont = true;
            this.Cmb_Language.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_Language.Properties.Items.AddRange(new object[] {
            "İNGİLİZCE",
            "İSPANYOLCA"});
            this.Cmb_Language.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.Cmb_Language.Size = new System.Drawing.Size(190, 26);
            this.Cmb_Language.TabIndex = 2;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.Btn_Delete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Btn_Delete.Appearance.Options.UseBackColor = true;
            this.Btn_Delete.Appearance.Options.UseFont = true;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Delete.ImageOptions.SvgImage")));
            this.Btn_Delete.Location = new System.Drawing.Point(275, 344);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(108, 28);
            this.Btn_Delete.TabIndex = 5;
            this.Btn_Delete.Text = "SİL";
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.Btn_Update.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Btn_Update.Appearance.Options.UseBackColor = true;
            this.Btn_Update.Appearance.Options.UseFont = true;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Update.ImageOptions.SvgImage")));
            this.Btn_Update.Location = new System.Drawing.Point(133, 344);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(129, 28);
            this.Btn_Update.TabIndex = 4;
            this.Btn_Update.Text = "GÜNCELLE";
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.Btn_Save.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Btn_Save.Appearance.Options.UseBackColor = true;
            this.Btn_Save.Appearance.Options.UseFont = true;
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Save.ImageOptions.SvgImage")));
            this.Btn_Save.Location = new System.Drawing.Point(5, 344);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(119, 28);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "EKLE";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 298);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(103, 20);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "DİLİ SEÇİNİZ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 20);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "METİN:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(538, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(550, 535);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // TextSpeechAddDeleteUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 535);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TextSpeechAddDeleteUpdate.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.Name = "TextSpeechAddDeleteUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soru Ekle-Sil-Güncelle";
            this.Load += new System.EventHandler(this.TextSpeechAddDeleteUpdate_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextSpeechAddDeleteUpdate_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Language.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Clear;
        private DevExpress.XtraEditors.ComboBoxEdit Cmb_Language;
        private DevExpress.XtraEditors.SimpleButton Btn_Delete;
        private DevExpress.XtraEditors.SimpleButton Btn_Update;
        private DevExpress.XtraEditors.SimpleButton Btn_Save;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RichTextBox Rch_TurkishText;
        private System.Windows.Forms.RichTextBox Rch_LanguageText;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}