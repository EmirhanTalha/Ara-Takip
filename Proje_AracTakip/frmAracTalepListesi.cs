using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Proje_AracTakip
{
	public partial class frmAracTalepListesi : DevExpress.XtraEditors.XtraForm
	{
		public frmAracTalepListesi()
		{
			InitializeComponent();
		}
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable();

		private void frmAracTalepListesi_Load(object sender, EventArgs e)
		{
			try
			{
				using (da.SelectCommand = new SqlCommand(@"SELECT dbo.Arac.AracID, dbo.Arac.Plaka, dbo.Arac.MarkaTanim, dbo.Arac.ModelTanim, dbo.Arac.AracTanim, dbo.AracTalep.AracTalepID, dbo.AracTalep.PersonelAdSoyad, dbo.AracTalep.PersonelDepartmani, dbo.AracTalep.AlindigiTarih, dbo.AracTalep.AlinanKm, dbo.AracTalep.TalepAciklama, dbo.Arac.MuayeneTarihi, dbo.Arac.AracDurum FROM dbo.AracTalep INNER JOIN dbo.Arac ON dbo.AracTalep.AracID = dbo.Arac.AracID", Cs.csBaglantiGetir.BaglantiGetir()))
				{
					da.Fill(dt);
					gcListe.DataSource = dt;
				}
				gvListe.Columns["AracTalepID"].Visible = false;
				gvListe.Columns["AracID"].Visible = false;
				gvListe.Columns["MarkaTanim"].Caption = "Markası";
				gvListe.BestFitColumns();
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			//frmAracTalepDetay frmAracTalepDetay = new frmAracTalepDetay("-1");
			//if (frmAracTalepDetay.ShowDialog() == DialogResult.OK)
			//{
			//	btnGuncelle_Click(null, null);
			//}
			frmAracTalepDetay frmAracTalepDetay = new frmAracTalepDetay("-1");
			if (frmAracTalepDetay.ShowDialog()==DialogResult.OK)
			{
				btnGuncelle_Click(null, null);
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			try
			{
				if (gvListe.FocusedRowHandle < 0) return;
				int seciliSatirNo = gvListe.FocusedRowHandle;
				if (XtraMessageBox.Show("Seçili Kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

				using (var cmd = new SqlCommand(@"Delete From Arac Where AracTalepID=@AracTalepID", Cs.csBaglantiGetir.BaglantiGetir()))
				{
					cmd.Parameters.Add("@AracTalepID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("AracTalepID").ToString();
					cmd.ExecuteNonQuery();
				}
				btnGuncelle_Click(null, null);
				gvListe.FocusedRowHandle = seciliSatirNo - 1;
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void btnDegistir_Click(object sender, EventArgs e)
		{
			try
			{
				int satir = gvListe.FocusedRowHandle;
				frmAracTalepDetay frmAracTalepDetay = new frmAracTalepDetay(gvListe.GetFocusedRowCellDisplayText("AracID"));
				if (frmAracTalepDetay.ShowDialog() == DialogResult.OK)
				{
					btnGuncelle_Click(null, null);
					gvListe.FocusedRowHandle = satir;
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			dt.Clear();
			da.Fill(dt);
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}