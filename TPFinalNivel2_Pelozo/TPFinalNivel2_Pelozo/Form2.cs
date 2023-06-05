using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosSql;
using FuncionesAPP;
using System.Drawing.Text;

namespace TPFinalNivel2_Pelozo
{
    public partial class Form2 : Form
    {
        private MetodosGetSet Negocio = null;
        
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(MetodosGetSet negocio)
        {

            InitializeComponent();

            this.Negocio = negocio;
            Text = "Modificar producto";


        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
        Funciones Servicios= new Funciones();


            try
            {

                if (Negocio == null) {
                
                
                    Negocio = new MetodosGetSet();
                
                
                }

               Negocio.Codigo= textBoxCodigo.Text;
               Negocio.Nombre= textBoxNombre.Text;
               Negocio.Descripcion = textBoxDescripcion.Text;
               Negocio.IdMarca = int.Parse(textBoxIdMarca.Text);
               Negocio.IdCategoria = int.Parse(textBoxIdCategoria.Text);
               Negocio.ImagenUrl = textBoxImagenUrl.Text;
               Negocio.Precio = decimal.Parse(textBoxPrecio.Text);
               
                if (Negocio.Id != 0)
                {

                    Servicios.Modificar(Negocio);

                    MessageBox.Show("Se ha Modificado exitosamente!");
                }
                else
                {
                   

                    

                    Servicios.Agregar(Negocio);
                    

                    MessageBox.Show("Se Agrego exitosamente!");


                }
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           





        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

            if (Negocio != null)
            {
             
              textBoxCodigo.Text = Negocio.Codigo;
              textBoxNombre.Text = Negocio.Nombre;
              textBoxDescripcion.Text = Negocio.Descripcion;
              textBoxIdMarca.Text =Negocio.IdMarca.ToString();
              textBoxIdCategoria.Text = Negocio.IdCategoria.ToString();
              textBoxImagenUrl.Text = Negocio.ImagenUrl;
              textBoxPrecio.Text = Negocio.Precio.ToString();



            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



           







        }
    }

    
    

    



}
