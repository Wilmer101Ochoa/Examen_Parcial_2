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
    public class TickedDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();



        public bool InsertarTickedGenerado(Ticked user)
        {
            bool insert = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TICKED ");
                sql.Append(" VALUES ( @TickedGenerado); ");

                comando.Connection = Miconexion;
                Miconexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                
                comando.Parameters.Add("@TickedGenerado", SqlDbType.NVarChar, 60).Value = user.TickedGenerado;
               
                comando.ExecuteNonQuery();
                insert = true;
                //Miconexion.Close();
            }
            catch (Exception ex)
            {
                insert = false;
            }
            return insert;
        }



        public string ConsultNombre()
        {
            string query = "SELECT * FROM TIPO";
            comando.Connection = Miconexion;
            Miconexion.Close();
            Miconexion.Open();
            SqlCommand com = new SqlCommand(query,Miconexion);
            SqlDataReader reg = com.ExecuteReader();

            if (reg.Read())
            {
                return reg["NOMBRECLIENTE"].ToString();
            }
            else
            {
                return "NULL";
            }
            

        }

        public string ConsultSoporte()
        {
            string query = "SELECT * FROM TIPO";
            comando.Connection = Miconexion;
            Miconexion.Close();
            Miconexion.Open();
            SqlCommand com = new SqlCommand(query, Miconexion);
            SqlDataReader reg = com.ExecuteReader();

            if (reg.Read())
            {
                return reg["TIPOSOPORTE"].ToString();
            }
            else
            {
                return "NULL";
            }


        }











    }
}




