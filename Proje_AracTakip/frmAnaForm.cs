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

namespace Proje_AracTakip
{
	public partial class frmAnaForm : DevExpress.XtraEditors.XtraForm
	{
		public frmAnaForm()
		{
			InitializeComponent();
		}

		void FormuAc(Form gelenForm)
		{
			bool formBulundu = false;
			foreach (var item in this.MdiChildren)
			{
				if (gelenForm.Name == item.Name)
				{
					formBulundu = true;
					item.Activate();
					break;
				}
			}
			if (!formBulundu)
			{
				gelenForm.MdiParent = this;
				gelenForm.Show();
			}
		}

		private void btnAracListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmAracListesi frmAracListesi = new frmAracListesi();
			FormuAc(frmAracListesi);
		}

		private void btnAracTalepListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmAracTalepListesi frmAracTalepListesi = new frmAracTalepListesi();
			FormuAc(frmAracTalepListesi);
		}

		private void btnAracTeslim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmAracTeslim frmAracTeslim = new frmAracTeslim();
			FormuAc(frmAracTeslim);
		}
	}
}