using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;




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
                acceso.








            return listado;
            }
            catch (Exception)
            {

                throw;
            }



        }




    }
}
