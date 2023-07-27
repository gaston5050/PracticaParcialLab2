using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
namespace Negocio
{
    public class ProvinciaNegocio
    {
        public List <Provincia> listar()
        {
            List<Provincia> listado = new List<Provincia> ();
            AccesoDatosManager acceso = new AccesoDatosManager ();

            try
            {
            acceso.setConsulta("Select idprovincia, provincia from Provincias");
            acceso.ejecutarLectura();

            while (acceso.Lector.Read()){

                Provincia reg = new Provincia();

                reg.idProvincia = (Int16)acceso.Lector["idProvincia"];
                reg.NombreProvincia = (string) acceso.Lector["Provincia"];

                listado.Add(reg);
            }




            return listado;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            acceso.CerrarConexion();
               
            }
        }






    }
}
