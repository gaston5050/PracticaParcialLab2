using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Dominio;
using Negocio;

namespace Conexiones
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
            dgvAgentes.DataSource = negocio.listar();



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AccesoDatosManager reg = new AccesoDatosManager();
            int num = Int32.Parse(txtEliminar.Text);

            reg.setConsulta($"delete  from agentes where idAgente = {num}");
           // reg.AbrirConexion();
            reg.ejecutarAccion();
             reg.CerrarConexion();



        }
    }
}
