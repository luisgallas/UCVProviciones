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
    public partial class FormNuevaSolicitud : Form
    {
        private string _usuario;
        private const string SolicitudesFilePath = "solicitudes.json";
        public FormNuevaSolicitud(string usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void FormNuevaSolicitud_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cantidad = txtCantidad.Text;
            var descripcion = txtDescripcion.Text;

            var nuevaSolicitud = new JObject
            {
                { "usuario", _usuario },
                { "cantidad", cantidad },
                { "descripcion", descripcion },
                { "estado", "En espera" },
                { "fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }
            };

            JArray solicitudes;

            if (File.Exists(SolicitudesFilePath))
            {
                var jsonData = File.ReadAllText(SolicitudesFilePath);
                solicitudes = JArray.Parse(jsonData);
            }
            else
            {
                solicitudes = new JArray();
            }

            solicitudes.Add(nuevaSolicitud);
            File.WriteAllText(SolicitudesFilePath, solicitudes.ToString());

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
