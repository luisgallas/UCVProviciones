using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCVProviciones
{
    public partial class FormVerificarPedidos : Form
    {
        private const string SolicitudesFilePath = "solicitudes.json";

        public FormVerificarPedidos()
        {
            InitializeComponent();
        }

        private void FormVerificarPedidos_Load(object sender, EventArgs e)
        {
            CargarPedidos();
        }

        private void CargarPedidos()
        {
            if (File.Exists(SolicitudesFilePath))
            {
                var jsonData = File.ReadAllText(SolicitudesFilePath);
                var pedidos = JArray.Parse(jsonData);

                dataGridViewPedidos.DataSource = pedidos.ToObject<System.Data.DataTable>();
            }
            else
            {
                MessageBox.Show("No hay pedidos registrados.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
