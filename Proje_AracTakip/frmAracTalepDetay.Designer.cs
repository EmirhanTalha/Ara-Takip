namespace Proje_AracTakip
{
	partial class frmAracTalepDetay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracTalepDetay));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.lkpPlaka = new DevExpress.XtraEditors.LookUpEdit();
			this.deMuayeneTarihi = new DevExpress.XtraEditors.DateEdit();
			this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
			this.cmbDepartman = new DevExpress.XtraEditors.ComboBoxEdit();
			this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
			this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
			this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
			this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
			this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
			this.meAciklama = new DevExpress.XtraEditors.MemoEdit();
			this.txtAlinanKm = new DevExpress.XtraEditors.TextEdit();
			this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
			this.deAlindigiTarih = new DevExpress.XtraEditors.DateEdit();
			this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
			this.cmbAracDurum = new DevExpress.XtraEditors.ComboBoxEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lkpPlaka.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deMuayeneTarihi.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deMuayeneTarihi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
			this.groupControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbDepartman.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
			this.groupControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.meAciklama.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAlinanKm.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deAlindigiTarih.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deAlindigiTarih.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbAracDurum.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(17, 35);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(25, 13);
			this.labelControl1.TabIndex = 8;
			this.labelControl1.Text = "Plaka";
			// 
			// labelControl8
			// 
			this.labelControl8.Location = new System.Drawing.Point(307, 35);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(73, 13);
			this.labelControl8.TabIndex = 19;
			this.labelControl8.Text = "Muayene Tarihi";
			// 
			// labelControl9
			// 
			this.labelControl9.Location = new System.Drawing.Point(103, 35);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(4, 13);
			this.labelControl9.TabIndex = 12;
			this.labelControl9.Text = ":";
			// 
			// labelControl16
			// 
			this.labelControl16.Location = new System.Drawing.Point(393, 35);
			this.labelControl16.Name = "labelControl16";
			this.labelControl16.Size = new System.Drawing.Size(4, 13);
			this.labelControl16.TabIndex = 23;
			this.labelControl16.Text = ":";
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.cmbAracDurum);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.lkpPlaka);
			this.groupControl1.Controls.Add(this.labelControl16);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Controls.Add(this.labelControl9);
			this.groupControl1.Controls.Add(this.deMuayeneTarihi);
			this.groupControl1.Controls.Add(this.labelControl8);
			this.groupControl1.Location = new System.Drawing.Point(12, 12);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(551, 86);
			this.groupControl1.TabIndex = 0;
			this.groupControl1.Text = "Araç Bilgileri";
			// 
			// lkpPlaka
			// 
			this.lkpPlaka.Location = new System.Drawing.Point(113, 32);
			this.lkpPlaka.Name = "lkpPlaka";
			this.lkpPlaka.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
			this.lkpPlaka.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lkpPlaka.Properties.NullText = "";
			this.lkpPlaka.Size = new System.Drawing.Size(126, 20);
			this.lkpPlaka.TabIndex = 0;
			this.lkpPlaka.EditValueChanged += new System.EventHandler(this.lkpPlaka_EditValueChanged);
			// 
			// deMuayeneTarihi
			// 
			this.deMuayeneTarihi.EditValue = new System.DateTime(2019, 7, 15, 15, 36, 28, 734);
			this.deMuayeneTarihi.Location = new System.Drawing.Point(403, 32);
			this.deMuayeneTarihi.Name = "deMuayeneTarihi";
			this.deMuayeneTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deMuayeneTarihi.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
			this.deMuayeneTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deMuayeneTarihi.Size = new System.Drawing.Size(126, 20);
			this.deMuayeneTarihi.TabIndex = 7;
			// 
			// groupControl2
			// 
			this.groupControl2.Controls.Add(this.cmbDepartman);
			this.groupControl2.Controls.Add(this.labelControl19);
			this.groupControl2.Controls.Add(this.labelControl20);
			this.groupControl2.Controls.Add(this.labelControl17);
			this.groupControl2.Controls.Add(this.txtAdSoyad);
			this.groupControl2.Controls.Add(this.labelControl18);
			this.groupControl2.Location = new System.Drawing.Point(12, 104);
			this.groupControl2.Name = "groupControl2";
			this.groupControl2.Size = new System.Drawing.Size(551, 65);
			this.groupControl2.TabIndex = 1;
			this.groupControl2.Text = "Personel Bilgileri";
			// 
			// cmbDepartman
			// 
			this.cmbDepartman.Location = new System.Drawing.Point(403, 32);
			this.cmbDepartman.Name = "cmbDepartman";
			this.cmbDepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbDepartman.Properties.Items.AddRange(new object[] {
            "Muhasebe",
            "Satış",
            "Pazarlama",
            "Bilgi İşlem"});
			this.cmbDepartman.Size = new System.Drawing.Size(126, 20);
			this.cmbDepartman.TabIndex = 24;
			// 
			// labelControl19
			// 
			this.labelControl19.Location = new System.Drawing.Point(393, 35);
			this.labelControl19.Name = "labelControl19";
			this.labelControl19.Size = new System.Drawing.Size(4, 13);
			this.labelControl19.TabIndex = 5;
			this.labelControl19.Text = ":";
			// 
			// labelControl20
			// 
			this.labelControl20.Location = new System.Drawing.Point(307, 35);
			this.labelControl20.Name = "labelControl20";
			this.labelControl20.Size = new System.Drawing.Size(53, 13);
			this.labelControl20.TabIndex = 3;
			this.labelControl20.Text = "Departman";
			// 
			// labelControl17
			// 
			this.labelControl17.Location = new System.Drawing.Point(103, 35);
			this.labelControl17.Name = "labelControl17";
			this.labelControl17.Size = new System.Drawing.Size(4, 13);
			this.labelControl17.TabIndex = 4;
			this.labelControl17.Text = ":";
			// 
			// txtAdSoyad
			// 
			this.txtAdSoyad.Location = new System.Drawing.Point(113, 32);
			this.txtAdSoyad.Name = "txtAdSoyad";
			this.txtAdSoyad.Size = new System.Drawing.Size(126, 20);
			this.txtAdSoyad.TabIndex = 0;
			// 
			// labelControl18
			// 
			this.labelControl18.Location = new System.Drawing.Point(17, 35);
			this.labelControl18.Name = "labelControl18";
			this.labelControl18.Size = new System.Drawing.Size(46, 13);
			this.labelControl18.TabIndex = 2;
			this.labelControl18.Text = "Ad Soyad";
			// 
			// groupControl3
			// 
			this.groupControl3.Controls.Add(this.labelControl25);
			this.groupControl3.Controls.Add(this.labelControl26);
			this.groupControl3.Controls.Add(this.meAciklama);
			this.groupControl3.Controls.Add(this.txtAlinanKm);
			this.groupControl3.Controls.Add(this.labelControl21);
			this.groupControl3.Controls.Add(this.labelControl22);
			this.groupControl3.Controls.Add(this.deAlindigiTarih);
			this.groupControl3.Controls.Add(this.labelControl23);
			this.groupControl3.Controls.Add(this.labelControl24);
			this.groupControl3.Location = new System.Drawing.Point(12, 175);
			this.groupControl3.Name = "groupControl3";
			this.groupControl3.Size = new System.Drawing.Size(551, 161);
			this.groupControl3.TabIndex = 2;
			this.groupControl3.Text = "Talep Detayı";
			// 
			// labelControl25
			// 
			this.labelControl25.Location = new System.Drawing.Point(103, 60);
			this.labelControl25.Name = "labelControl25";
			this.labelControl25.Size = new System.Drawing.Size(4, 13);
			this.labelControl25.TabIndex = 6;
			this.labelControl25.Text = ":";
			// 
			// labelControl26
			// 
			this.labelControl26.Location = new System.Drawing.Point(17, 60);
			this.labelControl26.Name = "labelControl26";
			this.labelControl26.Size = new System.Drawing.Size(41, 13);
			this.labelControl26.TabIndex = 4;
			this.labelControl26.Text = "Açıklama";
			// 
			// meAciklama
			// 
			this.meAciklama.Location = new System.Drawing.Point(113, 58);
			this.meAciklama.Name = "meAciklama";
			this.meAciklama.Size = new System.Drawing.Size(416, 98);
			this.meAciklama.TabIndex = 2;
			// 
			// txtAlinanKm
			// 
			this.txtAlinanKm.Location = new System.Drawing.Point(403, 32);
			this.txtAlinanKm.Name = "txtAlinanKm";
			this.txtAlinanKm.Size = new System.Drawing.Size(126, 20);
			this.txtAlinanKm.TabIndex = 1;
			// 
			// labelControl21
			// 
			this.labelControl21.Location = new System.Drawing.Point(393, 35);
			this.labelControl21.Name = "labelControl21";
			this.labelControl21.Size = new System.Drawing.Size(4, 13);
			this.labelControl21.TabIndex = 8;
			this.labelControl21.Text = ":";
			// 
			// labelControl22
			// 
			this.labelControl22.Location = new System.Drawing.Point(307, 35);
			this.labelControl22.Name = "labelControl22";
			this.labelControl22.Size = new System.Drawing.Size(50, 13);
			this.labelControl22.TabIndex = 7;
			this.labelControl22.Text = "Alındığı KM";
			// 
			// deAlindigiTarih
			// 
			this.deAlindigiTarih.EditValue = new System.DateTime(2019, 7, 15, 15, 30, 14, 83);
			this.deAlindigiTarih.Location = new System.Drawing.Point(113, 32);
			this.deAlindigiTarih.Name = "deAlindigiTarih";
			this.deAlindigiTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deAlindigiTarih.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
			this.deAlindigiTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deAlindigiTarih.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
			this.deAlindigiTarih.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
			this.deAlindigiTarih.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.deAlindigiTarih.Size = new System.Drawing.Size(126, 20);
			this.deAlindigiTarih.TabIndex = 0;
			// 
			// labelControl23
			// 
			this.labelControl23.Location = new System.Drawing.Point(103, 35);
			this.labelControl23.Name = "labelControl23";
			this.labelControl23.Size = new System.Drawing.Size(4, 13);
			this.labelControl23.TabIndex = 5;
			this.labelControl23.Text = ":";
			// 
			// labelControl24
			// 
			this.labelControl24.Location = new System.Drawing.Point(17, 35);
			this.labelControl24.Name = "labelControl24";
			this.labelControl24.Size = new System.Drawing.Size(60, 13);
			this.labelControl24.TabIndex = 3;
			this.labelControl24.Text = "Alındığı Tarih";
			// 
			// btnKaydet
			// 
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(523, 342);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(40, 35);
			this.btnKaydet.TabIndex = 3;
			this.btnKaydet.Text = "simpleButton5";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnIptal
			// 
			this.btnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.ImageOptions.Image")));
			this.btnIptal.Location = new System.Drawing.Point(477, 342);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(40, 35);
			this.btnIptal.TabIndex = 4;
			this.btnIptal.Text = "simpleButton4";
			this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
			// 
			// cmbAracDurum
			// 
			this.cmbAracDurum.EditValue = "";
			this.cmbAracDurum.Location = new System.Drawing.Point(113, 58);
			this.cmbAracDurum.Name = "cmbAracDurum";
			this.cmbAracDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbAracDurum.Properties.Items.AddRange(new object[] {
            "Beklemede",
            "Zimmette"});
			this.cmbAracDurum.Size = new System.Drawing.Size(126, 20);
			this.cmbAracDurum.TabIndex = 24;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(103, 61);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(4, 13);
			this.labelControl2.TabIndex = 26;
			this.labelControl2.Text = ":";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(17, 61);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(56, 13);
			this.labelControl3.TabIndex = 25;
			this.labelControl3.Text = "Araç Durum";
			// 
			// frmAracTalepDetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 384);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.groupControl3);
			this.Controls.Add(this.groupControl2);
			this.Controls.Add(this.groupControl1);
			this.Name = "frmAracTalepDetay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Araç Talep Detayı";
			this.Load += new System.EventHandler(this.frmAracTalepDetay_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lkpPlaka.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deMuayeneTarihi.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deMuayeneTarihi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
			this.groupControl2.ResumeLayout(false);
			this.groupControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbDepartman.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
			this.groupControl3.ResumeLayout(false);
			this.groupControl3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.meAciklama.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAlinanKm.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deAlindigiTarih.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deAlindigiTarih.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbAracDurum.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.LabelControl labelControl16;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.GroupControl groupControl2;
		private DevExpress.XtraEditors.LabelControl labelControl19;
		private DevExpress.XtraEditors.LabelControl labelControl20;
		private DevExpress.XtraEditors.LabelControl labelControl17;
		private DevExpress.XtraEditors.TextEdit txtAdSoyad;
		private DevExpress.XtraEditors.LabelControl labelControl18;
		private DevExpress.XtraEditors.DateEdit deMuayeneTarihi;
		private DevExpress.XtraEditors.GroupControl groupControl3;
		private DevExpress.XtraEditors.DateEdit deAlindigiTarih;
		private DevExpress.XtraEditors.LabelControl labelControl23;
		private DevExpress.XtraEditors.LabelControl labelControl24;
		private DevExpress.XtraEditors.LabelControl labelControl25;
		private DevExpress.XtraEditors.LabelControl labelControl26;
		private DevExpress.XtraEditors.MemoEdit meAciklama;
		private DevExpress.XtraEditors.TextEdit txtAlinanKm;
		private DevExpress.XtraEditors.LabelControl labelControl21;
		private DevExpress.XtraEditors.LabelControl labelControl22;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraEditors.SimpleButton btnIptal;
		private DevExpress.XtraEditors.ComboBoxEdit cmbDepartman;
		private DevExpress.XtraEditors.LookUpEdit lkpPlaka;
		private DevExpress.XtraEditors.ComboBoxEdit cmbAracDurum;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
	}
}