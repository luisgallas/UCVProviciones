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
    /*public partial class FormNuevaSolicitud : Form
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

        private void btnAtrasNSC_Click(object sender, EventArgs e)
        {
            this.Close ( ); 
        }
    }*/
    public partial class FormNuevaSolicitud : Form
    {
        private string _usuario;
        private const string SolicitudesFilePath = "solicitudes.json";
        private DataTable solicitudesTable;

        public FormNuevaSolicitud(string usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            InicializarDataTable();
        }

        private void InicializarDataTable()
        {
            solicitudesTable = new DataTable();
            solicitudesTable.Columns.Add("Descripcion");
            solicitudesTable.Columns.Add("Cantidad");
            solicitudesTable.Columns.Add("Estado");
            solicitudesTable.Columns.Add("Fecha");

            dataGridViewSolicitudes.DataSource = solicitudesTable;
        }



        private void btnGuardarSolicitudes_Click(object sender, EventArgs e)
        {
            var solicitudesList = new List<JObject>();

            foreach (DataRow row in solicitudesTable.Rows)
            {
                var solicitud = new JObject
                {
                    { "usuario", _usuario },
                    { "descripcion", row["Descripcion"].ToString() },
                    { "cantidad", row["Cantidad"].ToString() },
                    { "estado", row["Estado"].ToString() },
                    { "fecha", row["Fecha"].ToString() }
                };

                solicitudesList.Add(solicitud);
            }

            JArray jsonArray;
            if (File.Exists(SolicitudesFilePath))
            {
                var jsonData = File.ReadAllText(SolicitudesFilePath);
                jsonArray = JArray.Parse(jsonData);
            }
            else
            {
                jsonArray = new JArray();
            }

            foreach (var solicitud in solicitudesList)
            {
                jsonArray.Add(solicitud);
            }

            File.WriteAllText(SolicitudesFilePath, jsonArray.ToString());
            MessageBox.Show("Solicitudes guardadas exitosamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAgregarSolicitud_Click(object sender, EventArgs e)
        {
            var descripcion = txtDescripcion.Text;
            var cantidad = txtCantidad.Text;

            if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(cantidad))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            var nuevaFila = solicitudesTable.NewRow();
            nuevaFila["Descripcion"] = descripcion;
            nuevaFila["Cantidad"] = cantidad;
            nuevaFila["Estado"] = "En espera";
            nuevaFila["Fecha"] = DateTime.Now.ToString("yyyy-MM-dd");

            solicitudesTable.Rows.Add(nuevaFila);

            txtDescripcion.Clear();
            txtCantidad.Clear();
        }

        private void btnAtrasNSC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

