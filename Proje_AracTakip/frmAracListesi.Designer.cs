namespace Proje_AracTakip
{
	partial class frmAracListesi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracListesi));
			this.gcListe = new DevExpress.XtraGrid.GridControl();
			this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
			this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gcListe
			// 
			this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcListe.Location = new System.Drawing.Point(0, 0);
			this.gcListe.MainView = this.gvListe;
			this.gcListe.Name = "gcListe";
			this.gcListe.Size = new System.Drawing.Size(694, 394);
			this.gcListe.TabIndex = 9;
			this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
			// 
			// gvListe
			// 
			this.gvListe.Appearance.FixedLine.BackColor = System.Drawing.Color.DimGray;
			this.gvListe.Appearance.FixedLine.BackColor2 = System.Drawing.Color.Gainsboro;
			this.gvListe.Appearance.FixedLine.BorderColor = System.Drawing.Color.Black;
			this.gvListe.Appearance.FixedLine.Options.UseBackColor = true;
			this.gvListe.Appearance.FixedLine.Options.UseBorderColor = true;
			this.gvListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gvListe.GridControl = this.gcListe;
			this.gvListe.Name = "gvListe";
			this.gvListe.OptionsBehavior.Editable = false;
			this.gvListe.OptionsSelection.MultiSelect = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnKapat);
			this.panel1.Controls.Add(this.btnGuncelle);
			this.panel1.Controls.Add(this.btnDegistir);
			this.panel1.Controls.Add(this.btnSil);
			this.panel1.Controls.Add(this.btnEkle);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 394);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(694, 44);
			this.panel1.TabIndex = 8;
			// 
			// btnKapat
			// 
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(196, 3);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(40, 38);
			this.btnKapat.TabIndex = 14;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
			this.btnGuncelle.Location = new System.Drawing.Point(150, 3);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(40, 38);
			this.btnGuncelle.TabIndex = 13;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnDegistir
			// 
			this.btnDegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.ImageOptions.Image")));
			this.btnDegistir.Location = new System.Drawing.Point(104, 3);
			this.btnDegistir.Name = "btnDegistir";
			this.btnDegistir.Size = new System.Drawing.Size(40, 38);
			this.btnDegistir.TabIndex = 12;
			this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
			// 
			// btnSil
			// 
			this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
			this.btnSil.Location = new System.Drawing.Point(58, 3);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(40, 38);
			this.btnSil.TabIndex = 11;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
			this.btnEkle.Location = new System.Drawing.Point(12, 3);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(40, 38);
			this.btnEkle.TabIndex = 10;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// frmAracListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 438);
			this.Controls.Add(this.gcListe);
			this.Controls.Add(this.panel1);
			this.Name = "frmAracListesi";
			this.Text = "Araç Listesi";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmAracListesi_Load);
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gcListe;
		private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.SimpleButton btnEkle;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnGuncelle;
		private DevExpress.XtraEditors.SimpleButton btnDegistir;
		private DevExpress.XtraEditors.SimpleButton btnSil;
	}
}