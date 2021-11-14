using SoporteTecnico.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteTecnico.Modelos.DAO
{
   
    public class EstadoDAO:Conexion // heredamos de Conexion
    {

        SqlCommand comando = new SqlCommand();

        
        public bool InsertarNuevoEstado(Estado user)
        {
            bool insert = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ESTADOSTICK ");
                sql.Append(" VALUES (@Nombre, @Fecha, @Estado); ");

                comando.Connection = Miconexion;
                Miconexion.Open();   
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 80).Value = user.NombreCliente;
                comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = user.Fecha;
                comando.Parameters.Add("@Estado", SqlDbType.NVarChar, 90).Value = user.NombreEstado;
               
                comando.ExecuteNonQuery();
                insert= true;
                Miconexion.Close();
            }
            catch (Exception ex)
            {
                insert = false;
            }
            return insert;
        }

        

        public DataTable GetUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM ESTADOTICK ");

                comando.Connection = Miconexion;
                Miconexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                Miconexion.Close();
            }
            catch (Exception)
            {
            }
            return dt;
        }

       




    }
}
