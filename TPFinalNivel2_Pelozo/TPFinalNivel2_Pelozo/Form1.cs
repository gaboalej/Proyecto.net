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
using FuncionesAPP;


namespace TPFinalNivel2_Pelozo
{
    public partial class Form1 : Form
    {

        private List<MetodosGetSet> ListarDataGridView;



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



            Funciones MostrarDatos = new Funciones();

            try
            {


                ListarDataGridView = MostrarDatos.Listar();
                dataGridView1.DataSource = ListarDataGridView;






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
    }
}
