using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-7E9QC34;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            baglan.Open();
            return baglan;
        }
    }
}
