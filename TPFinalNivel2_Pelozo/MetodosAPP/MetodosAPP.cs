using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatosSql;
namespace FuncionesAPP
{
    public class Funciones
    {

        public List<MetodosGetSet> Listar()
        {

        List<MetodosGetSet>Lista = new List<MetodosGetSet>();
        AccesoDatos Datos = new AccesoDatos();


            try
            {


                Datos.SetearConsulta("select Id,Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio  from ARTICULOS");
                Datos.EjecutarLectura();


                while (Datos.lector.Read())
                {
                    MetodosGetSet aux = new MetodosGetSet();

                    aux.Id = (int)Datos.lector["Id"];
                    aux.Codigo = (string)Datos.lector["Codigo"];
                    aux.Nombre = (String)Datos.lector["Nombre"];
                    aux.Descripcion = (String)Datos.lector["Descripcion"];
                    aux.IdMarca = (int)Datos.lector["IdMarca"];
                    aux.IdCategoria = (int)Datos.lector["IdCategoria"];
                    aux.ImagenUrl = (string)Datos.lector["ImagenUrl"];
                   aux.Precio = (decimal)Datos.lector["Precio"];

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
