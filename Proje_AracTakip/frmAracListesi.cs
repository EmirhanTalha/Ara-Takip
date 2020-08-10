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
using System.Configuration;

namespace Proje_AracTakip
{
	public partial class frmAracListesi : DevExpress.XtraEditors.XtraForm
	{
		public frmAracListesi()
		{
			InitializeComponent();
		}
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable();

		private void frmAracListesi_Load(object sender, EventArgs e)
		{
			try
			{
				using (da.SelectCommand=new SqlCommand(@"SELECT AracID, Plaka, MarkaTanim, ModelTanim, AracTanim, UretimYili, Renk, YakitTipi, MuayeneTarihi, AracDurum FROM dbo.Arac", Cs.csBaglantiGetir.BaglantiGetir()))
				{
					da.Fill(dt);
					gcListe.DataSource = dt;
				}
				gvListe.Columns["AracID"].Visible = false;
				gvListe.BestFitColumns();
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			frmAracDetay frmAracDetay = new frmAracDetay("-1");
			if (frmAracDetay.ShowDialog()==DialogResult.OK)
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

				using (var cmd = new SqlCommand(@"Delete From Arac Where AracID=@AracID",Cs.csBaglantiGetir.BaglantiGetir()))
				{
					cmd.Parameters.Add("@AracID",SqlDbType.Int).Value= gvListe.GetFocusedRowCellValue("AracID").ToString();
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
			int satir = gvListe.FocusedRowHandle;
			frmAracDetay frmAracDetay = new frmAracDetay(gvListe.GetFocusedRowCellDisplayText("AracID"));
			if (frmAracDetay.ShowDialog() == DialogResult.OK)
			{
				btnGuncelle_Click(null, null);
				gvListe.FocusedRowHandle = satir;
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