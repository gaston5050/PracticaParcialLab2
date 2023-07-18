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
using Negocio;

namespace prueba_conecciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AgenteNegocio negocio = new AgenteNegocio();
            dgvTablaAgentes.DataSource = negocio.listar();
            dgvTablaAgentes.Columns["urlImagen"].Visible = false;    



        }

        private void dgvTablaAgentes_SelectionChanged(object sender, EventArgs e)

        {

            Agente seleccionado = new Agente();


            seleccionado = (Agente)dgvTablaAgentes.CurrentRow.DataBoundItem;

            pbFoto.Load(seleccionado.UrlImagen);


        }
    }
}
