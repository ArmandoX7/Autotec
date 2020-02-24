using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallermecaanico
{
    class ClientesDAL
    {
        public static int Agregar(Cliente pCliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into  cliente values(null,'{0}','{1}','{2}',null)", pCliente.Nombre, pCliente.Apellido, pCliente.Telefono), BdComun.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;

        }
    }
}
