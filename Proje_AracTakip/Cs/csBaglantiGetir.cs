using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proje_AracTakip.Cs
{
	class csBaglantiGetir
	{
		static SqlConnection baglanti;
		public static SqlConnection BaglantiGetir()
		{
			if (baglanti == null)
				baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);

			if (baglanti.State == ConnectionState.Closed)
				baglanti.Open();

			return baglanti;
		}
	}
}
