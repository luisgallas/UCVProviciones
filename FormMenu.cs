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
    public partial class FormMenu : Form
    {
        private string _rol;
        private string _usuario;

        public FormMenu(string usuario, string rol)
        {
            _usuario = usuario;
            _rol = rol;
            InitializeComponent();
            ConfigurarMenuPorRol();
        }

        private void ConfigurarMenuPorRol()
        {
            switch (_rol)
            {
                case "funcionario":
                    btnSolicitarCompras.Visible = true;
                    btnVerificarEstadoSolicitudes.Visible = true;
                    btnAprobarPedidos.Visible = false;
                    btnAccesoTotal.Visible = false;
                    break;
                case "directivo":
                    btnSolicitarCompras.Visible = false;
                    btnVerificarEstadoSolicitudes.Visible = false;
                    btnAprobarPedidos.Visible = true;
                    btnAccesoTotal.Visible = false;
                    break;
                case "administrador":
                    btnSolicitarCompras.Visible = true;
                    btnVerificarEstadoSolicitudes.Visible = true;
                    btnAprobarPedidos.Visible = true;
                    btnAccesoTotal.Visible = true;
                    break;
                default:
                    MessageBox.Show("Rol no reconocido");
                    this.Close();
                    break;
            }
        }


        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSolicitarCompras_Click(object sender, EventArgs e)
        {
            var formSolicitudCompras = new FormSolicitudCompras(_usuario);
            formSolicitudCompras.ShowDialog();
        }

        private void btnAprobarPedidos_Click(object sender, EventArgs e)
        {
            var formGestionSolicitudes = new FormGestionSolicitudes();
            formGestionSolicitudes.ShowDialog();
        }

        private void btnAtrasLogin_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
