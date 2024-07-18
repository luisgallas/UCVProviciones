using Newtonsoft.Json.Linq;

namespace UCVProviciones
{
    public partial class Form1 : Form
    {
        private const string UsuariosFilePath = "usuarios.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            var rol = ValidarUsuario(usuario, contraseña);
            if (rol != null)
            {
                MessageBox.Show("Login exitoso");
                FormMenu formMenu = new FormMenu(rol);
                formMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnCancelar_Click_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }


        }

        private void btnRegistrar_Click_Click(object sender, EventArgs e)
        {
            {
                FormRegistro formRegistro = new FormRegistro();
                formRegistro.ShowDialog();
            }
        }
        private string ValidarUsuario(string usuario, string contraseña)//poner de nuevo boll despues
        {
            if (File.Exists(UsuariosFilePath))
            {
                var jsonData = File.ReadAllText(UsuariosFilePath);
                var usuarios = JArray.Parse(jsonData);

                foreach (var u in usuarios)
                {
                    if (u["usuario"].ToString() == usuario && u["contraseña"].ToString() == contraseña)
                    {
                        return u["rol"].ToString();
                    }
                }
            }

            return null;
        }
    }
}
