using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatosSql;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;

namespace Negocio

{
    public class NegocioArticulo
{

    public List<Articulos> Listar()
    {

        List<Articulos> Lista = new List<Articulos>();
        AccesoDatos Datos = new AccesoDatos();


        try
        {


            Datos.SetearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, A.IdMarca, M.Descripcion AS Marca, A.IdCategoria, C.Descripcion as Categoria, ImagenUrl, Precio FROM ARTICULOS A, MARCAS M,CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id");
            Datos.EjecutarLectura();


            while (Datos.lector.Read())
            {
                Articulos aux = new Articulos();

                aux.Id = (int)Datos.lector["Id"];
                aux.Codigo = (string)Datos.lector["Codigo"];
                aux.Nombre = (String)Datos.lector["Nombre"];
                aux.Descripcion = (String)Datos.lector["Descripcion"];
                aux.IdMarca = (int)Datos.lector["IdMarca"];
                aux.Marca = new Marcas();
                aux.Marca.Descripcion = (string)Datos.lector["Marca"];
                aux.categoria = new Categoria();
                aux.categoria.Descripcion = (string)Datos.lector["Categoria"];
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

    public void Agregar(Articulos Agregar)
    {
        AccesoDatos Datos = new AccesoDatos();


        try
        {
            Datos.SetearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)");
            Datos.setearparametros("@Codigo", Agregar.Codigo);
            Datos.setearparametros("@Nombre", Agregar.Nombre);
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

    public void Modificar(Articulos Modificar)
    {
        AccesoDatos Datos = new AccesoDatos();

        try
        {
            Datos.SetearConsulta("update ARTICULOS set Codigo = @Codigo,Nombre = @Nombre,Descripcion = @Descripcion,IdMarca = @IdMarca,IdCategoria = @IdCategoria,ImagenUrl = @ImagenUrl,Precio = @Precio Where Id = @Id");
            Datos.setearparametros("@Codigo", Modificar.Codigo);
            Datos.setearparametros("@Nombre", Modificar.Nombre);
            Datos.setearparametros("@Descripcion", Modificar.Descripcion);
            Datos.setearparametros("@IdMarca", Modificar.IdMarca);
            Datos.setearparametros("@IdCategoria", Modificar.IdCategoria);
            Datos.setearparametros("@ImagenUrl", Modificar.ImagenUrl);
            Datos.setearparametros("@Precio", Modificar.Precio);
            Datos.setearparametros("@Id", Modificar.Id);

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

    public void Eliminar(int id)
    {
        try
        {
            AccesoDatos datos = new AccesoDatos();

            datos.SetearConsulta("delete from ARTICULOS where Id = @Id");

            datos.setearparametros("@Id", id);

            datos.ejecutarAccion();

        }
        catch (Exception ex)
        {

            throw ex;
        }




    }

    public List<Articulos> Filtrar(string campo, string criterio, string filtro)
        {
            List<Articulos> ListaFiltroAvanzado = new List<Articulos>();
            AccesoDatos datosFiltro = new AccesoDatos();
            try
            {
                string consultaFiltro = "SELECT A.Id, Codigo, Nombre, A.Descripcion, A.IdMarca, M.Descripcion AS Marca, A.IdCategoria, C.Descripcion as Categoria, ImagenUrl, Precio FROM ARTICULOS A, MARCAS M,CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id and ";
                if (campo == "Codigo")
                {
                    
                    switch (criterio)
                    {
                        case "Comienza con":
                            consultaFiltro += " Codigo like '" + filtro + "%'";
                           
                            break;
                        case "Termina con":
                            consultaFiltro += "Codigo like '%" + filtro +"'";
                          

                            break;


                        default:
                            consultaFiltro += " Codigo like '%"+ filtro +"%'  ";
                            break;
                    }
                }
                else if (campo == "Nombre")
                {

                    switch (criterio)
                    {
                        case "Comienza con":
                            consultaFiltro += " Nombre like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consultaFiltro += "Nombre like '%" + filtro + "'";
                            break;


                        default:
                            consultaFiltro += " Nombre like '%" + filtro + "%'  ";
                            break;
                    }
                }
                else if(campo == "Id")
                {
                    

                  switch (criterio)
                    {

                        case "Mayor a":
                           
                           
                            if (string.IsNullOrEmpty(filtro))
                            {
                                consultaFiltro += " " + filtro;
                                consultaFiltro = "SELECT A.Id, Codigo, Nombre, A.Descripcion, A.IdMarca, M.Descripcion AS Marca, A.IdCategoria, C.Descripcion as Categoria, ImagenUrl, Precio FROM ARTICULOS A, MARCAS M,CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id ";
                            }
                            else
                            {

                                consultaFiltro += " A.Id  > " + filtro;
                            }
                            break;

                            
                        case "Menor a":
                            if (string.IsNullOrEmpty(filtro))
                            {
                                consultaFiltro += " " + filtro;
                                consultaFiltro = "SELECT A.Id, Codigo, Nombre, A.Descripcion, A.IdMarca, M.Descripcion AS Marca, A.IdCategoria, C.Descripcion as Categoria, ImagenUrl, Precio FROM ARTICULOS A, MARCAS M,CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id ";
                            }
                            else { 
                            
                            consultaFiltro += " A.Id  < " + filtro;
                                }
                            break;
                        

                        default:
                            
                            if (string.IsNullOrEmpty(filtro))
                            {
                                consultaFiltro += " " + filtro;
                                consultaFiltro = "SELECT A.Id, Codigo, Nombre, A.Descripcion, A.IdMarca, M.Descripcion AS Marca, A.IdCategoria, C.Descripcion as Categoria, ImagenUrl, Precio FROM ARTICULOS A, MARCAS M,CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id ";
                            }
                            else
                            {

                                consultaFiltro += " A.Id  =" + filtro;
                            }
                            break;

                           
                    }

                }

                datosFiltro.SetearConsulta(consultaFiltro);
                datosFiltro.EjecutarLectura();

                while (datosFiltro.lector.Read())
                {
                    Articulos aux = new Articulos();

                    aux.Id = (int)datosFiltro.lector["Id"];
                    aux.Codigo = (string)datosFiltro.lector["Codigo"];
                    aux.Nombre = (String)datosFiltro.lector["Nombre"];
                    aux.Descripcion = (String)datosFiltro.lector["Descripcion"];
                    aux.IdMarca = (int)datosFiltro.lector["IdMarca"];
                    aux.Marca = new Marcas();
                    aux.Marca.Descripcion = (string)datosFiltro.lector["Marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.Descripcion = (string)datosFiltro.lector["Categoria"];
                    aux.IdCategoria = (int)datosFiltro.lector["IdCategoria"];
                    aux.ImagenUrl = (string)datosFiltro.lector["ImagenUrl"];
                    aux.Precio = (decimal)datosFiltro.lector["Precio"];
                    ListaFiltroAvanzado.Add(aux);


                }
                

                return ListaFiltroAvanzado;
            }
            catch (Exception ex)
            {

                throw ex;
            }










        }
    }


   

}
