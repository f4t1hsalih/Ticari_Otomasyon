﻿namespace Ticari_Otomasyon
{
    partial class FrmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbDistrict = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTaxAdministration = new DevExpress.XtraEditors.TextEdit();
            this.cmbProvince = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.mskTel2 = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.mskTel1 = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.rchAddress = new System.Windows.Forms.RichTextBox();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAdministration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.cmbDistrict);
            this.groupControl1.Controls.Add(this.txtTaxAdministration);
            this.groupControl1.Controls.Add(this.cmbProvince);
            this.groupControl1.Controls.Add(this.mskTC);
            this.groupControl1.Controls.Add(this.mskTel2);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.mskTel1);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtMail);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtSurname);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.rchAddress);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(762, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(240, 549);
            this.groupControl1.TabIndex = 0;
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.Location = new System.Drawing.Point(92, 272);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDistrict.Properties.Appearance.Options.UseFont = true;
            this.cmbDistrict.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDistrict.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbDistrict.Size = new System.Drawing.Size(120, 24);
            this.cmbDistrict.TabIndex = 9;
            // 
            // txtTaxAdministration
            // 
            this.txtTaxAdministration.Location = new System.Drawing.Point(92, 302);
            this.txtTaxAdministration.Name = "txtTaxAdministration";
            this.txtTaxAdministration.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTaxAdministration.Properties.Appearance.Options.UseFont = true;
            this.txtTaxAdministration.Size = new System.Drawing.Size(120, 24);
            this.txtTaxAdministration.TabIndex = 10;
            // 
            // cmbProvince
            // 
            this.cmbProvince.Location = new System.Drawing.Point(92, 242);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProvince.Properties.Appearance.Options.UseFont = true;
            this.cmbProvince.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProvince.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbProvince.Size = new System.Drawing.Size(120, 24);
            this.cmbProvince.TabIndex = 8;
            this.cmbProvince.SelectedIndexChanged += new System.EventHandler(this.cmbProvince_SelectedIndexChanged);
            // 
            // mskTC
            // 
            this.mskTC.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTC.Location = new System.Drawing.Point(92, 180);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(120, 26);
            this.mskTC.TabIndex = 6;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // mskTel2
            // 
            this.mskTel2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel2.Location = new System.Drawing.Point(92, 148);
            this.mskTel2.Mask = "(999) 000-0000";
            this.mskTel2.Name = "mskTel2";
            this.mskTel2.Size = new System.Drawing.Size(120, 26);
            this.mskTel2.TabIndex = 5;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(39, 335);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(47, 18);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "Adres: ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(53, 275);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 18);
            this.labelControl10.TabIndex = 20;
            this.labelControl10.Text = "İlçe: ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(47, 477);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(174, 29);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(47, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 29);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mskTel1
            // 
            this.mskTel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel1.Location = new System.Drawing.Point(92, 116);
            this.mskTel1.Mask = "(999) 000-0000";
            this.mskTel1.Name = "mskTel1";
            this.mskTel1.Size = new System.Drawing.Size(120, 26);
            this.mskTel1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(47, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 29);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(29, 305);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(57, 18);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Vergi D.:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(68, 245);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 18);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "İl: ";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(92, 212);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Size = new System.Drawing.Size(120, 24);
            this.txtMail.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(52, 215);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 18);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Mail: ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(47, 183);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "T.C.: ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(48, 151);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 18);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Tel2: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(48, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 18);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Tel1: ";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(92, 86);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Properties.Appearance.Options.UseFont = true;
            this.txtSurname.Size = new System.Drawing.Size(120, 24);
            this.txtSurname.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(36, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 18);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Soyad: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 56);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(120, 24);
            this.txtName.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(59, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Ad: ";
            // 
            // rchAddress
            // 
            this.rchAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchAddress.Location = new System.Drawing.Point(92, 332);
            this.rchAddress.Name = "rchAddress";
            this.rchAddress.Size = new System.Drawing.Size(120, 69);
            this.rchAddress.TabIndex = 11;
            this.rchAddress.Text = "";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(92, 26);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(120, 24);
            this.txtID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(65, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(0, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(756, 549);
            this.gridControl1.TabIndex = 111;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClear.ImageOptions.SvgImage")));
            this.btnClear.Location = new System.Drawing.Point(47, 512);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(174, 29);
            this.btnClear.TabIndex = 111112;
            this.btnClear.Text = "Temizle";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmCustomers";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.FrmCutomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAdministration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.MaskedTextBox mskTel2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.MaskedTextBox mskTel1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSurname;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RichTextBox rchAddress;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtTaxAdministration;
        private DevExpress.XtraEditors.ComboBoxEdit cmbProvince;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDistrict;
        private DevExpress.XtraEditors.SimpleButton btnClear;
    }
}