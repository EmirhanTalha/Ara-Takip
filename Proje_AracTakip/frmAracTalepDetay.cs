using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Proje_AracTakip
{
	public partial class frmAracTalepDetay : DevExpress.XtraEditors.XtraForm
	{
		public frmAracTalepDetay(string AracTalepID)
		{
			InitializeComponent();
			_AracTalepID = AracTalepID;
		}
		string _AracTalepID = "-1";
		string plaka = "";

		private void frmAracTalepDetay_Load(object sender, EventArgs e)
		{
			try
			{
				#region lkpPlaka Doldurma
				using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT AracID, Plaka FROM dbo.Arac ", Cs.csBaglantiGetir.BaglantiGetir()))
				{
					DataTable dt = new DataTable();
					da.Fill(dt);

					lkpPlaka.Properties.DataSource = dt;
					lkpPlaka.Properties.PopulateColumns();
					lkpPlaka.Properties.ValueMember = "AracID";
					lkpPlaka.Properties.DisplayMember = "Plaka";
					lkpPlaka.Properties.Columns["AracID"].Visible = false;
					lkpPlaka.EditValue = -1;
				}
				#endregion

				if (_AracTalepID != "-1")
				{
					using (SqlCommand cmd = new SqlCommand(@"SELECT dbo.Arac.AracID, dbo.Arac.Plaka, dbo.Arac.MuayeneTarihi, dbo.Arac.AracDurum, dbo.AracTalep.PersonelAdSoyad, dbo.AracTalep.PersonelDepartmani, dbo.AracTalep.AlindigiTarih, dbo.AracTalep.AlinanKm, dbo.AracTalep.TalepAciklama FROM dbo.AracTalep INNER JOIN dbo.Arac ON dbo.AracTalep.AracID = dbo.Arac.AracID WHERE (dbo.AracTalep.AracTalepID = @AracTalepID)", Cs.csBaglantiGetir.BaglantiGetir()))
					{
						cmd.Parameters.Add("@AracTalepID", SqlDbType.Int).Value = _AracTalepID;
						using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
						{
							if (dr.Read())
							{
								//lkpPlaka.Text = dr["Plaka"].ToString();
								lkpPlaka.EditValue = (int)dr["AracID"];
								deMuayeneTarihi.DateTime = (DateTime)dr["MuayeneTarihi"];
								cmbAracDurum.Text = dr["AracDurum"].ToString();
								txtAdSoyad.Text = dr["PersonelAdSoyad"].ToString();
								cmbDepartman.Text = dr["PersonelDepartmani"].ToString();
								deAlindigiTarih.DateTime = (DateTime)dr["AlindigiTarih"];
								txtAlinanKm.Text = dr["AlinanKm"].ToString();
								meAciklama.Text = dr["TalepAciklama"].ToString();
							}
						}
					}
				}

			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				#region boş alan kontrolü
				if ((int)lkpPlaka.EditValue == -1)
				{
					XtraMessageBox.Show("Zorunlu Alan Boş geçilemez");
					lkpPlaka.Focus();
					return;
				}
				#endregion

				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = Cs.csBaglantiGetir.BaglantiGetir();

				if (_AracTalepID == "-1")
				{
					cmd.CommandText = @"Insert Into AracTalep values(@AracID, @PersonelAdSoyad, @PersonelDepartmani, @AlindigiTarih, @AlinanKm, @TalepAciklama)";
				}
				else
				{
					cmd.CommandText = @"Update AracTalep Set AracID=@AracID, PersonelAdSoyad=@PersonelAdSoyad, PersonelDepartmani=@PersonelDepartmani, AlindigiTarih=@AlindigiTarih, AlinanKm=@AlinanKm, TalepAciklama=@TalepAciklama Where AracTalepID=@AracTalepID";
					cmd.Parameters.Add("@AracTalepID", SqlDbType.Int).Value = _AracTalepID;
				}
				//cmd.Parameters.Add("@MuayeneTarihi", SqlDbType.DateTime).Value = deMuayeneTarihi.DateTime.ToShortDateString();
				//cmd.Parameters.Add("@AracDurum", SqlDbType.NVarChar).Value = cmbAracDurum.Text;

				cmd.Parameters.Add("@AracID", SqlDbType.Int).Value = lkpPlaka.EditValue.ToString();
				cmd.Parameters.Add("@PersonelAdSoyad", SqlDbType.NVarChar).Value = txtAdSoyad.Text;
				cmd.Parameters.Add("@PersonelDepartmani", SqlDbType.NVarChar).Value = cmbDepartman.Text;
				cmd.Parameters.Add("@AlindigiTarih", SqlDbType.DateTime).Value = deAlindigiTarih.DateTime.ToShortDateString();
				cmd.Parameters.Add("@AlinanKm", SqlDbType.Int).Value = txtAlinanKm.Text;
				cmd.Parameters.Add("@TalepAciklama", SqlDbType.NVarChar).Value = meAciklama.Text;

				cmd.ExecuteNonQuery();
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception hata)
			{
				//XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Araç Takip", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(hata.Message);
			}
		}

		private void btnIptal_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void lkpPlaka_EditValueChanged(object sender, EventArgs e)
		{
			plaka = lkpPlaka.Text;
		}

		//Form load içerisinde cmbPlaka içerisine arac veritabanından plaka çek ve diğer alanları ona göre doldur.
	}
}