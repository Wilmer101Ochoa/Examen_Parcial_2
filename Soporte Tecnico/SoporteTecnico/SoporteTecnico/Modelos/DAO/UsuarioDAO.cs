using SoporteTecnico.Modelos.Entidades;
using SoporteTecnico.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteTecnico.Modelos.DAO
{
    public class UsuarioDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();


        public bool ValidarUsuario(Usuario user)
        {

            bool valido = false;

            try  // dentro del try se utiliza la clase stringbuilder
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT 1 FROM USUARIO WHERE  EMAIL= @Email AND CLAVE = @Clave;");// pasando las sentencia con el metodo appen

                comando.Connection = Miconexion; // accedemos a nuestro objeto comando y le pasamos la conexion de la cual heredamos de conexion
                Miconexion.Open(); // abrimos la  conexion a la base de datos con .open
                comando.CommandType = System.Data.CommandType.Text;                    // tipoo de sentencia que vamos a ejecutar
                comando.CommandText = sql.ToString(); // le pasamos la sentencia sql
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email; // le mandamos los parametros que se van a consumir
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 100).Value = user.Clave;


                valido = Convert.ToBoolean(comando.ExecuteScalar()); // captura lo que devuelve 
                Miconexion.Close();


            }
            catch (Exception)
            {


            }
            return valido;



        }
        












        public bool InsertarTipoSoporte(SoporteTipo uss)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO TIPO");// pasando las sentencia con el metodo appen
                sql.Append(" VALUES (@NombreCliente,@TipoSoporte,@Trabajo)");
                comando.Connection = Miconexion; // accedemos a nuestro objeto comando y le pasamos la conexion de la cual heredamos de conexion
                Miconexion.Open(); // abrimos la  conexion a la base de datos con .open
                comando.CommandType = System.Data.CommandType.Text;                    // tipoo de sentencia que vamos a ejecutar
                comando.CommandText = sql.ToString(); // le pasamos la sentencia sql

                comando.Parameters.Add("@NombreCliente", SqlDbType.NVarChar, 90).Value = uss.NombreCliente;
                comando.Parameters.Add("@TipoSoporte", SqlDbType.NVarChar, 110).Value = uss.tipo;
                comando.Parameters.Add("@Trabajo", SqlDbType.NVarChar, 90).Value = uss.Trabajo;
                
                comando.ExecuteNonQuery();
                return true;
                Miconexion.Close();
            }
            catch (Exception)
            {
                return false;
                throw;
            }





        }

       



      


    }

}
