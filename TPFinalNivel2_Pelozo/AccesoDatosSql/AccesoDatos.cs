﻿using System;
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
        private SqlConnection Conexion;

        private SqlCommand Comando;

        private SqlDataReader Lector;


        public SqlDataReader lector
        {

            get { return Lector; }


        }


        public AccesoDatos()
        {
            Conexion = new SqlConnection("server =.\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true ");


            Comando = new SqlCommand();

        }


        public void SetearConsulta(string Consulta)
        {

            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = Consulta;

        }

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


        public void setearparametros(string Nombre, object valor)
        {


            Comando.Parameters.AddWithValue(Nombre, valor);




        }


        public void CerrarConexion()
        {

            if (Lector != null) { Lector.Close(); }



            Conexion.Close();

        }





    }


}