using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace AccesoDatos
{
    public class AccesoDatosManager
    {

        public static string cadenaConexion = "server = .\\SQLEXPRESS; database = AgenciaTransito; integrated security = true";
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlDataReader lector; 

        public AccesoDatosManager()
        {
            conexion = new SqlConnection (cadenaConexion);

        }


        public SqlDataReader Lector
        {
             get { return lector; }  
        }
          
        public  SqlCommand Comando
        {
            get { return comando; } 
        }

        public void setConsulta( string consulta)
        {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;


        }




        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }




        }

        public void AbrirConexion()
        {
            try
            {
                conexion.Open ();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        


        }
        public void ejecutarLectura()
        {

                comando.Connection = conexion;
            try
            {
                conexion.Open();

                lector = comando.ExecuteReader ();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void ejecutarAccion()
        {
          
            comando.Connection = conexion;
            try
            {

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /*
        public void seterConsulta( string storedProcedure)
        {

            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text; 
           // comando.Connection = conexion;
            comando.CommandText = storedProcedure;
        }
        */


        public void setearSP (string sp)
        {
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = sp;   
        }

    }
}
