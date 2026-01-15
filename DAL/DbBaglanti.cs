using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRMProjeyeni.DAL
{
    public class DbBaglanti
    {
            private static string cs =
                "Server=172.21.54.253;Database=26_132430026;Uid=26_132430026;Pwd=İnif123.;";

            public static MySqlConnection Getir()
            {
                return new MySqlConnection(cs);
            }
        
    }
   

}
