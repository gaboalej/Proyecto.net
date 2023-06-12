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
using System.Xml;

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
            comboBoxCampo.Items.Add("Codigo");
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Id");
            textBoxFiltroAvanzado.Enabled = false;

        }

        private void CargarDataGridView()
        {



            NegocioArticulo MostrarDatos = new NegocioArticulo();

            try
            {


                ListaDataGridView = MostrarDatos.Listar();
                dataGridView1.DataSource = ListaDataGridView;
                dataGridView1.Columns["ImagenUrl"].Visible = false;
                cargarimagen(ListaDataGridView[0].ImagenUrl);

                dataGridView1.Columns["Id"].DisplayIndex = 0;
                dataGridView1.Columns["Codigo"].DisplayIndex = 1;
                dataGridView1.Columns["Nombre"].DisplayIndex = 2;
                dataGridView1.Columns["Descripcion"].DisplayIndex = 3;
                dataGridView1.Columns["Marca"].DisplayIndex = 4;
                dataGridView1.Columns["IdMarca"].DisplayIndex = 5;
                dataGridView1.Columns["Categoria"].DisplayIndex = 6;
                dataGridView1.Columns["IdCategoria"].DisplayIndex = 7;
                dataGridView1.Columns["Precio"].DisplayIndex = 8;




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

        private void cargarimagen(string imagen)
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

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string opcion = comboBoxCampo.SelectedItem.ToString();

            if (opcion == "Id")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
                textBoxFiltroAvanzado.Enabled = true;
            }
            else
            {

                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Comienza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
                textBoxFiltroAvanzado.Enabled = true;


            }



        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            try
            {


                NegocioArticulo negocioArticulo = new NegocioArticulo();




                // utilize el simbolo de navegacion segura  ?. en el combobox para poder validar si se selecciono algo y no es nulo.
                string Campo = comboBoxCampo.SelectedItem?.ToString();
                string Criterio = comboBoxCriterio.SelectedItem?.ToString();
                string Filtro = textBoxFiltroAvanzado.Text;
                
               


                if (string.IsNullOrEmpty(Campo))
                {
                    MessageBox.Show("Seleccione un campo para poder buscar");
                    
                    
                }
                else if (string.IsNullOrEmpty(Criterio))
                {

                    MessageBox.Show("Seleccione un criterio para poder buscar");
                   
                    


                }
                else if (!string.IsNullOrEmpty(Campo) && !string.IsNullOrEmpty(Criterio))
                {
                   
                    dataGridView1.DataSource = negocioArticulo.Filtrar(Campo, Criterio, Filtro);
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }




        }

        private void textBoxFiltroAvanzado_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            string campo = comboBoxCampo.SelectedItem.ToString();

            if (campo == "Id")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {

                    e.Handled = true;


                }

            }
        }

       
    }
    }

