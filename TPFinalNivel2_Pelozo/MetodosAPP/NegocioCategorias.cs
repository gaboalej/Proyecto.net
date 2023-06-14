using AccesoDatosSql;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioCategorias
    {
        // metodo  para listar las categorias.
        public List<Categoria> Listar()
        {

            List<Categoria> Lista = new List<Categoria>();
            AccesoDatos Datos = new AccesoDatos();


            try
            {


                Datos.SetearConsulta("select Id,Descripcion from CATEGORIAS");
                Datos.EjecutarLectura();


                while (Datos.lector.Read())
                {
                    Categoria aux = new Categoria();

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
