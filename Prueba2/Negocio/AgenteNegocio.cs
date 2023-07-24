using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;
using Negocio;




namespace Negocio
{
    public class AgenteNegocio
    {
        public List<Agente> listar() { 
          List<Agente> listado = new List<Agente>();
          AccesoDatosManager acceso = new AccesoDatosManager();
            try
            {
                acceso.setConsulta("select idagente, nombres from agentes");
                acceso.ejecutarLectura();


                while (acceso.Lector.Read())
                {
                    Agente aux = new Agente();

                    aux.NombreAgente = (string)acceso.Lector["nombres"];
                    aux.IdAgente = (int)acceso.Lector["idagente"];
                    listado.Add(aux);


                }



                acceso.CerrarConexion();
               
            return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }




    }
}
