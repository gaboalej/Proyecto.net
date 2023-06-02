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

        public void Agregar(MetodosGetSet Agregar)
        {
            AccesoDatos Datos = new AccesoDatos();


            try
            {
                Datos.SetearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)");
                Datos.setearparametros("@Codigo", Agregar.Codigo);
                Datos.setearparametros("@Nombre",Agregar.Nombre);
                Datos.setearparametros("@Descripcion", Agregar.Descripcion);
                Datos.setearparametros("@IdMarca", Agregar.IdMarca);
                Datos.setearparametros("@IdCategoria", Agregar.IdCategoria);
               Datos.setearparametros("@ImagenUrl", Agregar.ImagenUrl);
                Datos.setearparametros("@Precio", Agregar.Precio);

                Datos.ejecutarAccion();





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

        public void Modificar (MetodosGetSet Modificar)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearConsulta("update ARTICULOS set Codigo = @Codigo,Nombre = @Nombre,Descripcion = @Descripcion,IdMarca = @IdMarca,IdCategoria = @IdCategoria,ImagenUrl = @ImagenUrl,Precio = @Precio Where Id = @Id");
                Datos.setearparametros("@Codigo", Modificar.Codigo);
                Datos.setearparametros("@Nombre",Modificar.Nombre);
                Datos.setearparametros("@Descripcion",Modificar.Descripcion);
                Datos.setearparametros("@IdMarca",Modificar.IdMarca);
                Datos.setearparametros("@IdCategoria",Modificar.IdCategoria);
                Datos.setearparametros("@ImagenUrl",Modificar.ImagenUrl);
                Datos.setearparametros("@Precio",Modificar.Precio);
                Datos.setearparametros("@Id",Modificar.Id);

                Datos.ejecutarAccion();


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
