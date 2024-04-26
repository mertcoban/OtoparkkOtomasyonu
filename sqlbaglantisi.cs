using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtoparkOtomasyonu
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = OtoparkProje; Integrated Security = True");
            baglan.Open();
            return baglan;
        }




    }
}
