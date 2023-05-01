
namespace LanguageWork.Forms
{
    partial class EnglishImageAddDeleteUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnglishImageAddDeleteUpdate));
            this.Cmb_True = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.Pct_Question = new DevExpress.XtraEditors.PictureEdit();
            this.Btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_A = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_B = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_C = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_D = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_True.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_Question.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_A.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_B.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_C.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_D.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_True
            // 
            this.Cmb_True.Location = new System.Drawing.Point(135, 259);
            this.Cmb_True.Name = "Cmb_True";
            this.Cmb_True.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Cmb_True.Properties.Appearance.Options.UseFont = true;
            this.Cmb_True.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_True.Properties.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.Cmb_True.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.Cmb_True.Size = new System.Drawing.Size(190, 26);
            this.Cmb_True.TabIndex = 5;
            this.Cmb_True.SelectedIndexChanged += new System.EventHandler(this.Cmb_True_SelectedIndexChanged);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.Btn_Update.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Btn_Update.Appearance.Options.UseBackColor = true;
            this.Btn_Update.Appearance.Options.UseFont = true;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Update.ImageOptions.SvgImage")));
            this.Btn_Update.Location = new System.Drawing.Point(133, 300);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(129, 28);
            this.Btn_Update.TabIndex = 7;
            this.Btn_Update.Text = "GÜNCELLE";
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.Btn_Clear);
            this.groupControl1.Controls.Add(this.Pct_Question);
            this.groupControl1.Controls.Add(this.Cmb_True);
            this.groupControl1.Controls.Add(this.Btn_Delete);
            this.groupControl1.Controls.Add(this.Btn_Update);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.Btn_Save);
            this.groupControl1.Controls.Add(this.Txt_A);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.Txt_B);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.Txt_C);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.Txt_D);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(5, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(388, 332);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "SORU İŞLEMİ";
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
            this.Btn_Clear.TabIndex = 17;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            this.Btn_Clear.MouseHover += new System.EventHandler(this.Btn_Clear_MouseHover);
            // 
            // Pct_Question
            // 
            this.Pct_Question.Location = new System.Drawing.Point(133, 36);
            this.Pct_Question.Name = "Pct_Question";
            this.Pct_Question.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Pct_Question.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.Pct_Question.Size = new System.Drawing.Size(192, 88);
            this.Pct_Question.TabIndex = 0;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.Btn_Delete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Btn_Delete.Appearance.Options.UseBackColor = true;
            this.Btn_Delete.Appearance.Options.UseFont = true;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Delete.ImageOptions.SvgImage")));
            this.Btn_Delete.Location = new System.Drawing.Point(275, 300);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(108, 28);
            this.Btn_Delete.TabIndex = 8;
            this.Btn_Delete.Text = "SİL";
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 20);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "SORU:";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.Btn_Save.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Btn_Save.Appearance.Options.UseBackColor = true;
            this.Btn_Save.Appearance.Options.UseFont = true;
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Save.ImageOptions.SvgImage")));
            this.Btn_Save.Location = new System.Drawing.Point(5, 300);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(119, 28);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "EKLE";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Txt_A
            // 
            this.Txt_A.Location = new System.Drawing.Point(135, 130);
            this.Txt_A.Name = "Txt_A";
            this.Txt_A.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Txt_A.Properties.Appearance.Options.UseFont = true;
            this.Txt_A.Properties.MaxLength = 30;
            this.Txt_A.Size = new System.Drawing.Size(190, 26);
            this.Txt_A.TabIndex = 1;
            this.Txt_A.TextChanged += new System.EventHandler(this.Txt_A_TextChanged);
            this.Txt_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_A_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(7, 261);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(123, 20);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "DOĞRU CEVAP:";
            // 
            // Txt_B
            // 
            this.Txt_B.Location = new System.Drawing.Point(135, 162);
            this.Txt_B.Name = "Txt_B";
            this.Txt_B.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Txt_B.Properties.Appearance.Options.UseFont = true;
            this.Txt_B.Properties.MaxLength = 30;
            this.Txt_B.Size = new System.Drawing.Size(190, 26);
            this.Txt_B.TabIndex = 2;
            this.Txt_B.TextChanged += new System.EventHandler(this.Txt_B_TextChanged);
            this.Txt_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_A_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(7, 227);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(12, 20);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "D";
            // 
            // Txt_C
            // 
            this.Txt_C.Location = new System.Drawing.Point(135, 194);
            this.Txt_C.Name = "Txt_C";
            this.Txt_C.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Txt_C.Properties.Appearance.Options.UseFont = true;
            this.Txt_C.Properties.MaxLength = 30;
            this.Txt_C.Size = new System.Drawing.Size(190, 26);
            this.Txt_C.TabIndex = 3;
            this.Txt_C.TextChanged += new System.EventHandler(this.Txt_C_TextChanged);
            this.Txt_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_A_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(7, 195);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(11, 20);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "C";
            // 
            // Txt_D
            // 
            this.Txt_D.Location = new System.Drawing.Point(135, 226);
            this.Txt_D.Name = "Txt_D";
            this.Txt_D.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Txt_D.Properties.Appearance.Options.UseFont = true;
            this.Txt_D.Properties.MaxLength = 30;
            this.Txt_D.Size = new System.Drawing.Size(190, 26);
            this.Txt_D.TabIndex = 4;
            this.Txt_D.TextChanged += new System.EventHandler(this.Txt_D_TextChanged);
            this.Txt_D.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_A_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(7, 163);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(11, 20);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "B";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 132);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 20);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "A";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(615, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(550, 575);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // EnglishImageAddDeleteUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 575);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EnglishImageAddDeleteUpdate.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EnglishImageAddDeleteUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soru Ekle-Sil-Güncelle";
            this.Load += new System.EventHandler(this.ImageAddDeleteUpdate_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageAddDeleteUpdate_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_True.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_Question.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_A.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_B.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_C.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_D.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit Cmb_True;
        private DevExpress.XtraEditors.SimpleButton Btn_Update;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Delete;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Save;
        private DevExpress.XtraEditors.TextEdit Txt_A;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit Txt_B;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit Txt_C;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Txt_D;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.PictureEdit Pct_Question;
        private DevExpress.XtraEditors.SimpleButton Btn_Clear;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}