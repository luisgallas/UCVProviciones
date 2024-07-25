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
using Newtonsoft.Json;

namespace UCVProviciones
{
    public partial class FormRegistro : Form
    {
        private const string UsuariosFilePath = "usuarios.json";
        //private List<Usuario> usuarios;
        private bool mostrarContrasena = false;
        
        public FormRegistro()
        {
            InitializeComponent();
            //CargarUsuarios();
        }
       /*private void CargarUsuarios()
        {
            if (File.Exists("usuarios.json"))
            {
                var json = File.ReadAllText("usuarios.json");
                usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);
            }
            else
            {
                usuarios = new List<Usuario>();
            }
        }
        private void GuardarUsuarios()
        {
            var json = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
            File.WriteAllText("usuarios.json", json);
        }*/


        private void btnGuardar_Click_Click(object sender, EventArgs e)
        {
             string usuario = txtNuevoUsuario.Text;
             string contraseña = txtNuevaContraseña.Text;
             string rol = cmbRol.SelectedItem.ToString();
            //bool rol = cmbRol.SelectedItem.ToString();

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
            /*string usuario = txtNuevoUsuario.Text;
            string contraseña = txtNuevaContraseña.Text;
            string rol = cmbRol.SelectedItem.ToString();

            // Verificar si el usuario y la contraseña ya existen
            bool usuarioExistente = usuarios.Any(u => u.NombreUsuario == usuario && u.Contraseña == contraseña);

            if (usuarioExistente)
            {
                MessageBox.Show("El usuario y la contraseña ya existen. Por favor, ingrese datos diferentes.", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Si no existen, registrar el nuevo usuario
                var nuevoUsuario = new Usuario
                {
                    NombreUsuario = usuario,
                    Contraseña = contraseña,
                    Rol = rol
                };

                usuarios.Add(nuevoUsuario);
                GuardarUsuarios();

                MessageBox.Show("Usuario registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }*/
        }

        private void btnCancelarRU_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       /* public class Usuario
        {
            public string usuario { get; set; }
            public string contraseña { get; set; }
            public string rol { get; set; }
        }*/

        private void pbpasswordNew_Click(object sender, EventArgs e)
        {
            mostrarContrasena = !mostrarContrasena ;
            if (mostrarContrasena)
            {
                txtNuevaContraseña.PasswordChar = '\0';
                pbpasswordNew.Image = UCVProviciones.Properties.Resources.ocultacontrasena;
            }
            else
            {
                txtNuevaContraseña.PasswordChar = '*';
                pbpasswordNew.Image = UCVProviciones.Properties.Resources.vercontrasena ;
            }
        }
    }
}
