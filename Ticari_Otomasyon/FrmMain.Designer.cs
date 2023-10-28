namespace Ticari_Otomasyon
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnProducts = new DevExpress.XtraBars.BarButtonItem();
            this.btnStocks = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.btnCompanies = new DevExpress.XtraBars.BarButtonItem();
            this.btnStaff = new DevExpress.XtraBars.BarButtonItem();
            this.btnExpenses = new DevExpress.XtraBars.BarButtonItem();
            this.btnCase = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotes = new DevExpress.XtraBars.BarButtonItem();
            this.btnBanks = new DevExpress.XtraBars.BarButtonItem();
            this.btnDirectory = new DevExpress.XtraBars.BarButtonItem();
            this.btnBills = new DevExpress.XtraBars.BarButtonItem();
            this.btnSettings = new DevExpress.XtraBars.BarButtonItem();
            this.btnMainPage = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnProducts,
            this.btnStocks,
            this.btnCustomers,
            this.btnCompanies,
            this.btnStaff,
            this.btnExpenses,
            this.btnCase,
            this.btnNotes,
            this.btnBanks,
            this.btnDirectory,
            this.btnBills,
            this.btnSettings,
            this.btnMainPage});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1002, 150);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnProducts
            // 
            this.btnProducts.Caption = "ÜRÜNLER";
            this.btnProducts.Id = 1;
            this.btnProducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProducts.ImageOptions.SvgImage")));
            this.btnProducts.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProducts.ItemAppearance.Normal.Options.UseFont = true;
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProducts_ItemClick);
            // 
            // btnStocks
            // 
            this.btnStocks.Caption = "STOKLAR";
            this.btnStocks.Id = 2;
            this.btnStocks.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStocks.ImageOptions.SvgImage")));
            this.btnStocks.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStocks.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStocks.Name = "btnStocks";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Caption = "MÜŞTERİLER";
            this.btnCustomers.Id = 3;
            this.btnCustomers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCustomers.ImageOptions.SvgImage")));
            this.btnCustomers.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomers.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomers_ItemClick);
            // 
            // btnCompanies
            // 
            this.btnCompanies.Caption = "FİRMALAR";
            this.btnCompanies.Id = 4;
            this.btnCompanies.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCompanies.ImageOptions.SvgImage")));
            this.btnCompanies.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompanies.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCompanies.Name = "btnCompanies";
            // 
            // btnStaff
            // 
            this.btnStaff.Caption = "PERSONELLER";
            this.btnStaff.Id = 5;
            this.btnStaff.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStaff.ImageOptions.SvgImage")));
            this.btnStaff.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStaff.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStaff.Name = "btnStaff";
            // 
            // btnExpenses
            // 
            this.btnExpenses.Caption = "GİDERLER";
            this.btnExpenses.Id = 6;
            this.btnExpenses.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExpenses.ImageOptions.SvgImage")));
            this.btnExpenses.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpenses.ItemAppearance.Normal.Options.UseFont = true;
            this.btnExpenses.Name = "btnExpenses";
            // 
            // btnCase
            // 
            this.btnCase.Caption = "KASA";
            this.btnCase.Id = 7;
            this.btnCase.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCase.ImageOptions.SvgImage")));
            this.btnCase.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCase.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCase.Name = "btnCase";
            // 
            // btnNotes
            // 
            this.btnNotes.Caption = "NOTLAR";
            this.btnNotes.Id = 8;
            this.btnNotes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNotes.ImageOptions.SvgImage")));
            this.btnNotes.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotes.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNotes.Name = "btnNotes";
            // 
            // btnBanks
            // 
            this.btnBanks.Caption = "BANKALAR";
            this.btnBanks.Id = 9;
            this.btnBanks.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBanks.ImageOptions.SvgImage")));
            this.btnBanks.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanks.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBanks.Name = "btnBanks";
            // 
            // btnDirectory
            // 
            this.btnDirectory.Caption = "REHBER";
            this.btnDirectory.Id = 10;
            this.btnDirectory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDirectory.ImageOptions.SvgImage")));
            this.btnDirectory.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDirectory.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDirectory.Name = "btnDirectory";
            // 
            // btnBills
            // 
            this.btnBills.Caption = "FATURALAR";
            this.btnBills.Id = 11;
            this.btnBills.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBills.ImageOptions.SvgImage")));
            this.btnBills.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBills.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBills.Name = "btnBills";
            // 
            // btnSettings
            // 
            this.btnSettings.Caption = "AYARLAR";
            this.btnSettings.Id = 12;
            this.btnSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSettings.ImageOptions.SvgImage")));
            this.btnSettings.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSettings.Name = "btnSettings";
            // 
            // btnMainPage
            // 
            this.btnMainPage.Caption = "ANA SAYFA";
            this.btnMainPage.Id = 13;
            this.btnMainPage.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMainPage.ImageOptions.SvgImage")));
            this.btnMainPage.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMainPage.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMainPage.Name = "btnMainPage";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ticari Otomasyon";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMainPage);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProducts);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStocks);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCustomers);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCompanies);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStaff);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExpenses);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCase);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotes);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBanks);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDirectory);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBills);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSettings);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 661);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TİCARİ OTOMASYON";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnProducts;
        private DevExpress.XtraBars.BarButtonItem btnStocks;
        private DevExpress.XtraBars.BarButtonItem btnCustomers;
        private DevExpress.XtraBars.BarButtonItem btnCompanies;
        private DevExpress.XtraBars.BarButtonItem btnStaff;
        private DevExpress.XtraBars.BarButtonItem btnExpenses;
        private DevExpress.XtraBars.BarButtonItem btnCase;
        private DevExpress.XtraBars.BarButtonItem btnNotes;
        private DevExpress.XtraBars.BarButtonItem btnBanks;
        private DevExpress.XtraBars.BarButtonItem btnDirectory;
        private DevExpress.XtraBars.BarButtonItem btnBills;
        private DevExpress.XtraBars.BarButtonItem btnSettings;
        private DevExpress.XtraBars.BarButtonItem btnMainPage;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

