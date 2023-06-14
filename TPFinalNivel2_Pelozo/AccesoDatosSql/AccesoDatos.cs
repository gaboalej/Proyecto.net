using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace AccesoDatosSql
{
    
    public class AccesoDatos
    {
        //Declaracion de variables para conectar la base de datos.
        private SqlConnection Conexion;

        private SqlCommand Comando;

        private SqlDataReader Lector;


        //aplico un get para poder almacenar la lectura
        public SqlDataReader lector
        {

            get { return Lector; }


        }

        //constructor que muestra el server y a que base de datos se va a conectar ,y se conecta con el usuario y clave del sistema operativo.
        public AccesoDatos()
        {
            Conexion = new SqlConnection("server =.\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true ");


            Comando = new SqlCommand();

        }

        //metodo para poder aplicar el tipo de consulta , ya sea select ,update , delete ,insert.
        public void SetearConsulta(string Consulta)
        {

            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = Consulta;

        }

        //metodo para ejecutar la query dada .
        public void EjecutarLectura()
        {

            Comando.Connection = Conexion;

            try
            {
                Conexion.Open();

                Lector = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        // metodo para ejecutar una no query de lectura , ej insert update delete.
        public void ejecutarAccion()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // para poder concatenar @ a las consultas y que se puedan leer de mejor manera.
        public void setearparametros(string Nombre, object valor)
        {


            Comando.Parameters.AddWithValue(Nombre, valor);




        }

        // metodo para cerrar la conexion de la base de datos.
        public void CerrarConexion()
        {

            if (Lector != null) { Lector.Close(); }



            Conexion.Close();

        }





    }


}