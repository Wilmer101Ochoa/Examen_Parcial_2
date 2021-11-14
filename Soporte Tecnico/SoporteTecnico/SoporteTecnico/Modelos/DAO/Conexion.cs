using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteTecnico.Modelos.DAO
{
    public class Conexion
    {




        protected SqlConnection Miconexion = new SqlConnection(ConfigurationManager.ConnectionStrings["FacturaConexion"].ConnectionString);









    }
}
