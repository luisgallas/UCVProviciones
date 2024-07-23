using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace UCVProviciones
{
    public partial class FormSolicitudCompras : Form
    {
        private string _usuario;
        private const string SolicitudesFilePath = "solicitudes.json";
        public FormSolicitudCompras(string usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void FormSolicitudCompras_Load(object sender, EventArgs e)
        {
            CargarSolicitudes();
        }
        private void CargarSolicitudes()
        {
            if (File.Exists(SolicitudesFilePath))
            {
                var jsonData = File.ReadAllText(SolicitudesFilePath);
                var solicitudes = JArray.Parse(jsonData);

                dataGridViewSolicitudes.DataSource = solicitudes;
            }
        }

        private void btnNuevaSolicitud_Click(object sender, EventArgs e)
        {
            using (var formNuevaSolicitud = new FormNuevaSolicitud(_usuario))
            {
                if (formNuevaSolicitud.ShowDialog() == DialogResult.OK)
                {
                    CargarSolicitudes();
                }
            }
        }

        private void lblAtrasSoliCompras_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
    }
}
