using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace UCVProviciones
{
    public partial class FormRegistro : Form
    {
        private const string UsuariosFilePath = "usuarios.json";
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_Click(object sender, EventArgs e)
        {
            string usuario = txtNuevoUsuario.Text;
            string contraseña = txtNuevaContraseña.Text;
            string rol = cmbRol.SelectedItem.ToString();

            var nuevoUsuario = new JObject
            {
                { "usuario", usuario },
                { "contraseña", contraseña },
                { "rol", rol }
            };

            JArray usuarios;

            if (File.Exists(UsuariosFilePath))
            {
                var jsonData = File.ReadAllText(UsuariosFilePath);
                usuarios = JArray.Parse(jsonData);
            }
            else
            {
                usuarios = new JArray();
            }

            usuarios.Add(nuevoUsuario);
            File.WriteAllText(UsuariosFilePath, usuarios.ToString());

            MessageBox.Show("Usuario registrado exitosamente");
            this.Close();
        }

        private void btnCancelarRU_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
