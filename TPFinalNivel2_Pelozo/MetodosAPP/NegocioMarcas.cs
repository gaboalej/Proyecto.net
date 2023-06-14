using AccesoDatosSql;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{   
    //metodo para listar las marcas.
    public class NegocioMarcas
    {
        public List<Marcas> Listar()
        {

            List<Marcas> Lista = new List<Marcas>();
            AccesoDatos Datos = new AccesoDatos();


            try
            {


                Datos.SetearConsulta("select Id,Descripcion from MARCAS");
                Datos.EjecutarLectura();


                while (Datos.lector.Read())
                {
                    Marcas aux = new Marcas();

                    aux.Id = (int)Datos.lector["Id"];
                    aux.Descripcion = (string)Datos.lector["Descripcion"];

                    Lista.Add(aux);


                }

                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

                Datos.CerrarConexion();


            }


        }





    }

}
