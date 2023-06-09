using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using AccesoDatosSql;
using Negocio;
using System.IO;
using System.Runtime.Remoting.Channels;


namespace TPFinalNivel2_Pelozo
{
    public partial class Form1 : Form
    {

        private List<Articulos> ListaDataGridView;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CargarDataGridView();

        }

        private void CargarDataGridView()
        {


            
           NegocioArticulo  MostrarDatos = new NegocioArticulo();

            try
            {


                ListaDataGridView = MostrarDatos.Listar();
                dataGridView1.DataSource = ListaDataGridView;
                dataGridView1.Columns["ImagenUrl"].Visible = false;
                cargarimagen(ListaDataGridView[0].ImagenUrl);

                




            }
            catch (Exception ex)
            {

                throw ex;
            }




        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Form2 Agregar = new Form2();

            Agregar.ShowDialog();

            CargarDataGridView();

            




        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
                Articulos seleccionado = (Articulos)dataGridView1.CurrentRow.DataBoundItem;
                cargarimagen(seleccionado.ImagenUrl);

                



               

         
            }

            private void cargarimagen (string imagen)
        {


            try
            {
            pictureBoxArticulos.Load(imagen);

            }
            catch (Exception)
            {

                pictureBoxArticulos.Load("https://img.freepik.com/vector-gratis/ups-error-404-ilustracion-concepto-robot-roto_114360-5529.jpg?w=740&t=st=1685972963~exp=1685973563~hmac=d7423b4ab86d312d89adcd7a48787658ddd5581ab4c78a1b78550c5c4cded702");
            }
            
            

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

            

            try

            {

                if (dataGridView1.Rows.Count > 0)
                {

                  Articulos seleccionado = (Articulos)dataGridView1.CurrentRow.DataBoundItem;
                    Form2 Modificar = new Form2(seleccionado);
                    Modificar.ShowDialog();
                    CargarDataGridView();

                }
                else
                {



                    MessageBox.Show("Porfavor Selecciona un articulo para modificarlo.");


                     }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            NegocioArticulo Servicios = new NegocioArticulo();

            Articulos seleccionado;

            try
            {
             DialogResult respuesta = MessageBox.Show("Estas seguro de borrar el registro permanentemente ?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {


                    seleccionado = (Articulos)dataGridView1.CurrentRow.DataBoundItem;
                    Servicios.Eliminar(seleccionado.Id);

                    CargarDataGridView();





                }










            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }






        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> ListaFiltro;
            if (textBoxFiltro.Text.Length > 0)
            {

                ListaFiltro = ListaDataGridView.FindAll(x => x.Nombre.ToUpper().Contains(textBoxFiltro.Text.ToUpper()));
            }
            else
            {

                ListaFiltro = ListaDataGridView;


            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaFiltro;



        }

    }
    }

