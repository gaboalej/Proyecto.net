using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalNivel2_Pelozo
{
    public partial class Form3 : Form
    {
        List<Articulos> ListaDataGridView;
        // variable articulos que recibe el valor del constructor.
        private Articulos articuloSeleccionado;
        public Form3(Articulos seleccionado)
        {


      
            InitializeComponent();
            // recibe el valor del datagridview1 que se encuentra en el form1 para poder mostrar en el datagridview detalles , segun el articulo seleccionado del datagridview1(form1).
            articuloSeleccionado = seleccionado;


        }
      
        private void Form3_Load(object sender, EventArgs e)
        {

            
            
            CargarDataGridViewDetalles();

            //Ordeno las columnas del datagridview.
            dataGridViewDetalles.Columns["Id"].DisplayIndex = 0;
            dataGridViewDetalles.Columns["Codigo"].DisplayIndex = 1;
            dataGridViewDetalles.Columns["Nombre"].DisplayIndex = 2;
            dataGridViewDetalles.Columns["Descripcion"].DisplayIndex = 3;
            dataGridViewDetalles.Columns["Marca"].DisplayIndex = 4;
            dataGridViewDetalles.Columns["IdMarca"].DisplayIndex = 5;
            dataGridViewDetalles.Columns["Categoria"].DisplayIndex = 6;
            dataGridViewDetalles.Columns["IdCategoria"].DisplayIndex = 7;
            dataGridViewDetalles.Columns["Precio"].DisplayIndex = 8;
        }


        private void CargarDataGridViewDetalles()
        {



            NegocioArticulo MostrarDatos = new NegocioArticulo();
          
            try
            {
                ListaDataGridView = MostrarDatos.Listar();

                // en esta lista cargo el articulo seleccionado del datagridview principal  , al datagridview de detalles.
                List<Articulos> VerArticuloSeleccionado = new List<Articulos>();
                VerArticuloSeleccionado.Add(articuloSeleccionado);

                dataGridViewDetalles.DataSource = VerArticuloSeleccionado;
                dataGridViewDetalles.Columns["ImagenUrl"].Visible = false;


            }
            catch (Exception ex)
            {

                throw ex;
            }




        }
    }
}
