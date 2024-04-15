using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.conexion
{
    public class BdHotel
    {
        public static SqlConnection ObtenerConexion()
        {

            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Hotel;Data Source=LAB-J110-36");
            conexion.Open();
            return conexion;

        }
    }
}
