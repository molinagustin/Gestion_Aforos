using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CAccesoDatos.Repositorios
{
    //La hacemos publica y abstracta para que solo la utilicen las clases que la hereden
    public abstract class repConexionSql
    {
        private readonly string cadenaConexion;

        public repConexionSql()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionSQL"].ToString();
        }

        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
