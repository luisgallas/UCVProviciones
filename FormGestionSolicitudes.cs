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
    public partial class FormGestionSolicitudes : Form
    {
        private const string SolicitudesFilePath = "solicitudes.json";

        public FormGestionSolicitudes()
        {
            InitializeComponent();
        }

        private void FormGestionSolicitudes_Load(object sender, EventArgs e)
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

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            CambiarEstadoSolicitud("Aprobado");
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            CambiarEstadoSolicitud("Rechazado");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CambiarEstadoSolicitud("En espera");
        }
        private void CambiarEstadoSolicitud(string nuevoEstado)
        {
            if (dataGridViewSolicitudes.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dataGridViewSolicitudes.SelectedRows[0];
                var usuario = filaSeleccionada.Cells["usuario"].Value.ToString();
                var descripcion = filaSeleccionada.Cells["descripcion"].Value.ToString();

                if (File.Exists(SolicitudesFilePath))
                {
                    var jsonData = File.ReadAllText(SolicitudesFilePath);
                    var solicitudes = JArray.Parse(jsonData);

                    foreach (var solicitud in solicitudes)
                    {
                        if (solicitud["usuario"].ToString() == usuario && solicitud["descripcion"].ToString() == descripcion)
                        {
                            solicitud["estado"] = nuevoEstado;
                            break;
                        }
                    }

                    File.WriteAllText(SolicitudesFilePath, solicitudes.ToString());
                    CargarSolicitudes();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud.");
            }
        }

        private void btnATRasGSC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarSolicitud();
        }
        private void EliminarSolicitud()
        {
            if (dataGridViewSolicitudes.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dataGridViewSolicitudes.SelectedRows[0];
                var usuario = filaSeleccionada.Cells["usuario"].Value.ToString();
                var descripcion = filaSeleccionada.Cells["descripcion"].Value.ToString();

                if (File.Exists(SolicitudesFilePath))
                {
                    var jsonData = File.ReadAllText(SolicitudesFilePath);
                    var solicitudes = JArray.Parse(jsonData);

                    var solicitud = solicitudes.FirstOrDefault(s => s["usuario"].ToString() == usuario && s["descripcion"].ToString() == descripcion);

                    if (solicitud != null)
                    {
                        solicitudes.Remove(solicitud);
                        File.WriteAllText(SolicitudesFilePath, solicitudes.ToString());
                        CargarSolicitudes();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud.");
            }
        }
    }
}
