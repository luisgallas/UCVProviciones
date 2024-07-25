using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Newtonsoft.Json.Linq;

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
            // ConfigurarMenuPorRol();
        }

        /* private void ConfigurarMenuPorRol()
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
                    // btnAccesoTotal.Visible = true;
                     break;
                 default:
                     MessageBox.Show("Rol no reconocido");
                     this.Close();
                     break;
             }
         }*/
        

        private void FormMenu_Load(object sender, EventArgs e)
        {
            AjustarBotonesSegunRol();
        }
        private void AjustarBotonesSegunRol()
        {
            btnSolicitarCompras.Visible = false;
            btnVerificarPedidos.Visible = false;
            btnAprobarPedidos.Visible = false;

            int buttonPositionY = 12; // Posición inicial Y para el primer botón

            switch (_rol)
            {
                case "funcionario":
                    btnSolicitarCompras.Visible = true;
                    btnSolicitarCompras.Location = new System.Drawing.Point(12, buttonPositionY);
                    buttonPositionY += 60;

                    btnVerificarPedidos.Visible = true;
                    btnVerificarPedidos.Location = new System.Drawing.Point(12, buttonPositionY);
                    buttonPositionY += 60;
                    break;

                case "directivo":
                    btnAprobarPedidos.Visible = true;
                    btnAprobarPedidos.Location = new System.Drawing.Point(12, buttonPositionY);
                    buttonPositionY += 60;

                    btnVerificarPedidos.Visible = true;
                    btnVerificarPedidos.Location = new System.Drawing.Point(12, buttonPositionY);
                    buttonPositionY += 60;
                    break;

                case "administrador":
                    btnSolicitarCompras.Visible = true;
                    btnSolicitarCompras.Location = new System.Drawing.Point(12, buttonPositionY);
                    buttonPositionY += 36;

                    btnVerificarPedidos.Visible = true;
                    btnVerificarPedidos.Location = new System.Drawing.Point(12, buttonPositionY);
                    buttonPositionY += 60;

                    btnAprobarPedidos.Visible = true;
                    btnAprobarPedidos.Location = new System.Drawing.Point(12, buttonPositionY);
                    buttonPositionY += 60;
                    break;
            }

            btnAtrasMaL.Location = new System.Drawing.Point(12, buttonPositionY);
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



        /* private void btnVerificarEstadoSolicitudes_Click(object sender, EventArgs e)
         {
             var formVerificarPedidos = new FormVerificarPedidos();
             formVerificarPedidos.ShowDialog();
         }*/




        private void btnVerificarPedidos_Click(object sender, EventArgs e)
        {
            var formVerificarPedidos = new FormVerificarPedidos();
            formVerificarPedidos.ShowDialog();
        }

        private void btnAtrasMaL_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
