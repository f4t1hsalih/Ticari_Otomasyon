namespace Ticari_Otomasyon
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.label1 = new System.Windows.Forms.Label();
            this.txtmail = new DevExpress.XtraEditors.TextEdit();
            this.txTitle = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rchMessageBody = new System.Windows.Forms.RichTextBox();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTitle.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi:";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(118, 136);
            this.txtmail.Name = "txtmail";
            this.txtmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Properties.Appearance.Options.UseFont = true;
            this.txtmail.Size = new System.Drawing.Size(215, 24);
            this.txtmail.TabIndex = 9;
            // 
            // txTitle
            // 
            this.txTitle.Location = new System.Drawing.Point(118, 166);
            this.txTitle.Name = "txTitle";
            this.txTitle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txTitle.Properties.Appearance.Options.UseFont = true;
            this.txTitle.Size = new System.Drawing.Size(215, 24);
            this.txTitle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlık:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Konu:";
            // 
            // rchMessageBody
            // 
            this.rchMessageBody.Location = new System.Drawing.Point(118, 199);
            this.rchMessageBody.Name = "rchMessageBody";
            this.rchMessageBody.Size = new System.Drawing.Size(215, 183);
            this.rchMessageBody.TabIndex = 1;
            this.rchMessageBody.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSend.Appearance.Options.UseFont = true;
            this.btnSend.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSend.ImageOptions.SvgImage")));
            this.btnSend.Location = new System.Drawing.Point(149, 400);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(144, 43);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Gönder";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 108);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(192, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mail Paneli";
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(371, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rchMessageBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTitle.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtmail;
        private DevExpress.XtraEditors.TextEdit txTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rchMessageBody;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}