namespace Proje_AracTakip
{
	partial class frmAnaForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnAracListesi = new DevExpress.XtraBars.BarButtonItem();
			this.btnAracTalepListesi = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.btnAracTeslim = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnAracListesi,
            this.btnAracTalepListesi,
            this.btnAracTeslim});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 4;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.Size = new System.Drawing.Size(834, 141);
			// 
			// btnAracListesi
			// 
			this.btnAracListesi.Caption = "Araç Listesi";
			this.btnAracListesi.Id = 1;
			this.btnAracListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAracListesi.ImageOptions.Image")));
			this.btnAracListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAracListesi.ImageOptions.LargeImage")));
			this.btnAracListesi.LargeWidth = 100;
			this.btnAracListesi.Name = "btnAracListesi";
			this.btnAracListesi.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			this.btnAracListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAracListesi_ItemClick);
			// 
			// btnAracTalepListesi
			// 
			this.btnAracTalepListesi.Caption = "Araç Talep Listesi";
			this.btnAracTalepListesi.Id = 2;
			this.btnAracTalepListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAracTalepListesi.ImageOptions.Image")));
			this.btnAracTalepListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAracTalepListesi.ImageOptions.LargeImage")));
			this.btnAracTalepListesi.LargeWidth = 100;
			this.btnAracTalepListesi.Name = "btnAracTalepListesi";
			this.btnAracTalepListesi.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			this.btnAracTalepListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAracTalepListesi_ItemClick);
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "İşlemler";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.btnAracListesi);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.btnAracTalepListesi);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.btnAracTeslim);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			// 
			// btnAracTeslim
			// 
			this.btnAracTeslim.Caption = "Araç Teslim";
			this.btnAracTeslim.Id = 3;
			this.btnAracTeslim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAracTeslim.ImageOptions.Image")));
			this.btnAracTeslim.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAracTeslim.ImageOptions.LargeImage")));
			this.btnAracTeslim.LargeWidth = 100;
			this.btnAracTeslim.Name = "btnAracTeslim";
			this.btnAracTeslim.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			this.btnAracTeslim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAracTeslim_ItemClick);
			// 
			// frmAnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 461);
			this.Controls.Add(this.ribbonControl1);
			this.IsMdiContainer = true;
			this.Name = "frmAnaForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "     Araç Takip Programı";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.BarButtonItem btnAracListesi;
		private DevExpress.XtraBars.BarButtonItem btnAracTalepListesi;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.BarButtonItem btnAracTeslim;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
	}
}