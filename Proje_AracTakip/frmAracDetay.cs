using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Proje_AracTakip
{
	public partial class frmAracDetay : DevExpress.XtraEditors.XtraForm
	{
		public frmAracDetay(string AracID)
		{
			InitializeComponent();
			_AracID = AracID;
		}
		string _AracID = "-1";

		private void frmAracDetay_Load(object sender, EventArgs e)
		{
			try
			{
				if (_AracID != "-1")
				{
					using (SqlCommand cmd = new SqlCommand(@"SELECT dbo.Arac.Plaka, dbo.Arac.MarkaTanim, dbo.Arac.ModelTanim, dbo.Arac.AracTanim, dbo.Arac.UretimYili, dbo.Arac.Renk, dbo.Arac.YakitTipi, dbo.Arac.MuayeneTarihi, AracDurum FROM dbo.Arac WHERE (dbo.Arac.AracID = @AracID)", Cs.csBaglantiGetir.BaglantiGetir()))
					{
						cmd.Parameters.Add("@AracID", SqlDbType.Int).Value = _AracID;
						using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
						{
							if (dr.Read())
							{
								txtPlaka.Text = dr["Plaka"].ToString();
								txtMarka.Text = dr["MarkaTanim"].ToString();
								txtModel.Text = dr["ModelTanim"].ToString();
								txtAracTanim.Text = dr["AracTanim"].ToString();
								txtUretimYili.Text = dr["UretimYili"].ToString();
								cmbRenk.Text = dr["Renk"].ToString();
								//txtYakitTipi.Text = dr["YakitTipi"].ToString();
								cmbYakitTipi.Text = dr["YakitTipi"].ToString();
								deMuayeneTarihi.DateTime = (DateTime)dr["MuayeneTarihi"];
								cmbAracDurum.Text = dr["AracDurum"].ToString();
							}
						}
					}
				}
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				#region Boş Alam Kontrolü
				if (String.IsNullOrWhiteSpace(txtMarka.Text))
				{
					XtraMessageBox.Show("Zorunlu alan boş geçilemez.");
					txtMarka.Focus();
					return;
				}
				#endregion

				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = Cs.csBaglantiGetir.BaglantiGetir();
				if (_AracID == "-1")
				{
					cmd.CommandText = @"Insert into Arac values(@Plaka, @MarkaTanim, @ModelTanim, @AracTanim, @UretimYili, @Renk, @YakitTipi, @MuayeneTarihi, @AracDurum)";
				}
				else
				{
					cmd.CommandText = @"Update Arac SET Plaka=@Plaka, MarkaTanim=@MarkaTanim, ModelTanim=@ModelTanim, AracTanim=@AracTanim, UretimYili=@UretimYili, Renk=@Renk, YakitTipi=@YakitTipi, MuayeneTarihi=@MuayeneTarihi, AracDurum=@AracDurum WHERE AracID = @AracID";
					cmd.Parameters.Add("@AracID", SqlDbType.Int).Value = _AracID;
				}
				cmd.Parameters.Add("@Plaka", SqlDbType.NVarChar).Value = txtPlaka.Text;
				cmd.Parameters.Add("@MarkaTanim", SqlDbType.NVarChar).Value = txtMarka.Text;
				cmd.Parameters.Add("@ModelTanim", SqlDbType.NVarChar).Value = txtModel.Text;
				cmd.Parameters.Add("@AracTanim", SqlDbType.NVarChar).Value = txtAracTanim.Text;
				cmd.Parameters.Add("@UretimYili", SqlDbType.Int).Value = txtUretimYili.Text;
				cmd.Parameters.Add("@Renk", SqlDbType.NVarChar).Value = cmbRenk.Text;
				cmd.Parameters.Add("@YakitTipi", SqlDbType.NVarChar).Value = cmbYakitTipi.Text;
				cmd.Parameters.Add("@MuayeneTarihi", SqlDbType.DateTime).Value = deMuayeneTarihi.DateTime.ToShortDateString();
				cmd.Parameters.Add("@AracDurum", SqlDbType.NVarChar).Value = cmbAracDurum.Text;

				cmd.ExecuteNonQuery();
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Araç Takip", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnIptal_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}