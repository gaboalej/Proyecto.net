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
        // declaro la lista de tipo articulo , para que esos items se carguen en el datagrid.
        private List<Articulos> ListaDataGridView;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cargo todos los items que va a tener el combobox campo y el data grid en el load.
            CargarDataGridView();

            
            comboBoxCampo.Items.Add("Codigo");
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Id");
            textBoxFiltroAvanzado.Enabled = false;

        }


        //Metodo para cargar el datagrid.
        private void CargarDataGridView()
        {



            NegocioArticulo MostrarDatos = new NegocioArticulo();

            try
            {


                ListaDataGridView = MostrarDatos.Listar();
                dataGridView1.DataSource = ListaDataGridView;
                //oculto las columnas que quiero.
                dataGridView1.Columns["ImagenUrl"].Visible = false;
                dataGridView1.Columns["IdMarca"].Visible = false;
                dataGridView1.Columns["IdCategoria"].Visible = false;
                dataGridView1.Columns["Descripcion"].Visible = false;


                //se carga la imagen al inicio que esta en el primer lugar del index.
                cargarimagen(ListaDataGridView[0].ImagenUrl);
               
                
                
                //Ordeno las columnas del datagridview.
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
            //se carga el datagridview del form2 y se agrega un articulo. si se agrega exitosamente , se vuelve a refrescar el datagridview.

            Form2 Agregar = new Form2();

            Agregar.ShowDialog();

            CargarDataGridView();






        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // la imagen cambia dependiendo de que imagen se seleccione en el datagrid.
            Articulos seleccionado = (Articulos)dataGridView1.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado.ImagenUrl);








        }

        private void cargarimagen(string imagen)
        {
           // se carga la url de una imagen mediante string , sino se agrega una imagen por defecto de error 404.

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
            //se evalua si el datagrid no esta vacio y se modifica el articulo seleccionado.

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
            //elimina segun el articulo seleccionado basandose en su id.
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
        {//evalua si el filtro rapido tiene mas de un caracter en su textbox para poder realizar la busqueda,sino carga el datagrid con todos sus articulos.
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
            // dependiendo que campo se seleccione , las opciones de su criterio cambiaran.
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
            // metodo que carga el datagrid segun el filtro seleccionado y analiza si el campo y criterio estan seleccionados.
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
            // si el campo seleccionado es id solo se podran buscar numeros en el textbox del filtro avanzado.
            string campo = comboBoxCampo.SelectedItem.ToString();

            if (campo == "Id")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {

                    e.Handled = true;


                }

            }
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {





            try
            {
            // Obtiene el artículo seleccionado en el dataGridView1
            Articulos seleccionado = (Articulos)dataGridView1.CurrentRow.DataBoundItem;
            // creo una nueva instancia del form3 y le paso (articulo) seleccionado como parametro para su constructor..
            
            Form3 Verdetalles = new Form3(seleccionado);
            Verdetalles.ShowDialog();   


            }
            catch (Exception ex)
            {

                throw ex;
            }







        }


    }
    }

