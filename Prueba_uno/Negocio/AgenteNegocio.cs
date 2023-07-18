using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class AgenteNegocio
    {
       public List<Agente> listar()
        {
            List<Agente> lista = new List<Agente>();
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();

            SqlDataReader lector;
            try
            {
                Conexion.ConnectionString = "server = .\\SQLEXPRESS; database = AgenciaTransito; integrated security = true ";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "select idAgente, nombres, urlImagen from agentes";

                Comando.Connection = Conexion;
                Conexion.Open();

                lector = Comando.ExecuteReader();

                while (lector.Read())
                {

                    Agente aux = new Agente();

                    aux.IdAgente = (int)lector["idAgente"];
                    aux.Nombre = (string)lector["Nombres"];
                    aux.UrlImagen = Convert.IsDBNull(lector["urlImagen"]) == true? "" : (string)lector["urlImagen"];
                   
                    lista.Add(aux);
                }

            return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                Conexion.Close();

            }
        }


    }
}
