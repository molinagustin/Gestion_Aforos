using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CAccesoDatos.Repositorios
{
    //Heredamos desde repConexionSql para poder obtener la cadena de conexion y usarla sin instanciar
    public abstract class repMaestro : repConexionSql
    {
        //Lista de parametros que va a recibir la clase
        protected List<SqlParameter> parametros;

        //Metodos a utilizar
        //Para inserciones y actualizaciones
        protected int ExecuteNonQuery(string query)
        {   //Obtengo la conexion de la clase repConexionSql
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = query;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter param in parametros)
                    {
                        comando.Parameters.Add(param);
                    }
                    int resultado = comando.ExecuteNonQuery();
                    parametros.Clear();
                    return resultado;
                }
            }
        }
        
        //Para obtener registros o un registro sin parametros
        protected DataTable ExecuteReader(string query)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = query;
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lectorDatos = comando.ExecuteReader();
                    using (DataTable tabla = new DataTable())
                    {
                        tabla.Load(lectorDatos);
                        lectorDatos.Dispose();
                        return tabla;
                    }
                }
            }
        }

        //Para obtener registros o un registro con parametros
        protected DataTable ExecuteReaderWithParameters(string query)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = query;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter param in parametros)
                    {
                        comando.Parameters.Add(param);
                    }
                    SqlDataReader lectorDatos = comando.ExecuteReader();
                    using (DataTable tabla = new DataTable())
                    {
                        tabla.Load(lectorDatos);
                        lectorDatos.Dispose();
                        parametros.Clear();
                        return tabla;
                    }
                }
            }
        }

        //Para obtener un unico valor del registro (usualmente el ID)
        protected int ExecuteScalar(string query) 
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = query;
                    comando.CommandType = CommandType.Text;
                    int numId = Convert.ToInt32(comando.ExecuteScalar());
                    return numId;
                }
            }
        }

        protected int ExecuteScalarWithParameters(string query)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = query;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter param in parametros)
                    {
                        comando.Parameters.Add(param);
                    }
                    int numId = Convert.ToInt32(comando.ExecuteScalar());
                    parametros.Clear();
                    return numId;
                }
            }
        }
    }
}
