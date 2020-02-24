using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallermecaanico
{
    public class BdComun
    {
        public static MySqlConnection ObtenerConexion()
        {

            MySqlConnection conectar = new MySqlConnection("server=localhost; database=autotec; Uid=root; pwd =jaai96;");

            conectar.Open();

            return conectar;
        }
    }
}
