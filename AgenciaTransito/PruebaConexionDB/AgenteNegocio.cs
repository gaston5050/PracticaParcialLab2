using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PruebaConexionDB
{
    public class AgenteNegocio
    {

        public List<AgenteDominiio> Listar()
        {

            List<AgenteDominiio> lista = new List<AgenteDominiio>();   

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = AgenciaTransito; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select idagente, legajo, nombres, apellidos, activo from Agentes";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    AgenteDominiio aux = new AgenteDominiio();
                    aux.idAgente = lector.GetInt32(0);
                    aux.nombres = (string)lector["nombres"];
                    aux.apellidos = (string)lector["apellidos"];
                    aux.legajo = (string)lector["legajo"];

                    lista.Add(aux);
                    



                }


                conexion.Close();
            return lista;
            }

            catch (Exception ex)
            {

                throw ex;
            }






        }

    }
}
