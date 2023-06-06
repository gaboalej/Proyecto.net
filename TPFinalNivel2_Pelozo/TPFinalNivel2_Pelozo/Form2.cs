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
using System.Diagnostics.Eventing.Reader;

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

                if (!ValidarCampos())
                {
                    MessageBox.Show("Todos los campos deben estar llenos.");
                    return;
                }

                Negocio.Codigo= textBoxCodigo.Text;
               Negocio.Nombre= textBoxNombre.Text;
               Negocio.Descripcion = textBoxDescripcion.Text;
               Negocio.IdMarca = int.Parse(textBoxIdMarca.Text);
                Negocio.IdCategoria = int.Parse(textBoxIdCategoria.Text);
               Negocio.ImagenUrl = textBoxImagenUrl.Text;
               Negocio.Precio = decimal.Parse(textBoxPrecio.Text);



                // validacion de si los campos de texto estan vacios.
               
                // si el id del datagridview  no esta vacio modifica.
                if (Negocio.Id != 0)
                {

                    Servicios.Modificar(Negocio);

                    MessageBox.Show("Se ha Modificado exitosamente!");
                }
                // si el id del datagridview esta vacio agrega.
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

        private bool ValidarCampos()
        {
            bool camposValidos = true;

            if (string.IsNullOrEmpty(textBoxCodigo.Text))
            {
                textBoxCodigo.BackColor = Color.Red;
                camposValidos = false;
            }
            else
            {
                textBoxCodigo.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                textBoxNombre.BackColor = Color.Red;
                camposValidos = false;
            }
            else
            {
                textBoxNombre.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                textBoxDescripcion.BackColor = Color.Red;
                camposValidos = false;
            }
            else
            {
                textBoxDescripcion.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(textBoxIdMarca.Text))
            {
                textBoxIdMarca.BackColor = Color.Red;
                camposValidos = false;
            }
            else
            {
                textBoxIdMarca.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(textBoxIdCategoria.Text))
            {
                textBoxIdCategoria.BackColor = Color.Red;
                camposValidos = false;
            }
            else
            {
                textBoxIdCategoria.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(textBoxImagenUrl.Text))
            {
                textBoxImagenUrl.BackColor = Color.Red;
                camposValidos = false;
            }
            else
            {
                textBoxImagenUrl.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(textBoxPrecio.Text))
            {
                textBoxPrecio.BackColor = Color.Red;
                camposValidos = false;
            }
            else
            {
                textBoxPrecio.BackColor = SystemColors.Window;
            }

            return camposValidos;
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

            // si tiene un caracter el color se vuelve blanco si es que esta rojo.
            if(textBoxCodigo.Text.Length > 0)
            {

                textBoxCodigo.BackColor = SystemColors.Window;

            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            // si tiene un caracter el color se vuelve blanco si es que esta rojo.
            if (textBoxNombre.Text.Length > 0)
            {

                textBoxNombre.BackColor = SystemColors.Window;

            }
        }

        private void textBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            // si tiene un caracter el color se vuelve blanco si es que esta rojo.
            if (textBoxDescripcion.Text.Length > 0)
            {

                textBoxDescripcion.BackColor = SystemColors.Window;

            }
        }

        private void textBoxIdMarca_TextChanged(object sender, EventArgs e)
        {
            // si tiene un caracter el color se vuelve blanco si es que esta rojo.
            if (textBoxIdMarca.Text.Length > 0)
            {

              textBoxIdMarca.BackColor = SystemColors.Window;

            }
        }

        private void textBoxIdCategoria_TextChanged(object sender, EventArgs e)
        {
            // si tiene un caracter el color se vuelve blanco si es que esta rojo.
            if (textBoxIdCategoria.Text.Length > 0)
            {

                textBoxIdCategoria.BackColor = SystemColors.Window;

            }
        }

        private void textBoxImagenUrl_TextChanged(object sender, EventArgs e)
        {
            // si tiene un caracter el color se vuelve blanco si es que esta rojo.
            if (textBoxImagenUrl.Text.Length > 0)
            {

                textBoxImagenUrl.BackColor = SystemColors.Window;

            }
        }

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            // si tiene un caracter el color se vuelve blanco si es que esta rojo.
            if (textBoxPrecio.Text.Length > 0)
            {

                textBoxPrecio.BackColor = SystemColors.Window;

            }
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo permite el ingreso de números y punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

           // como es el precio permiti el ingreso del punto.
            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxIdMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo permite el ingreso de numeros.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxIdCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo permite el ingreso de numeros.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

    
    

    



}
