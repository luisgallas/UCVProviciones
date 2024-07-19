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
            string contrase�a = txtContrase�a.Text;

            var rol = ValidarUsuario(usuario, contrase�a);
            if (rol != null)
            {
                MessageBox.Show("Login exitoso");
                FormMenu formMenu = new FormMenu(usuario,rol);
                formMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos");
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
        private string ValidarUsuario(string usuario, string contrase�a)//poner de nuevo boll despues
        {
            if (File.Exists(UsuariosFilePath))
            {
                var jsonData = File.ReadAllText(UsuariosFilePath);
                var usuarios = JArray.Parse(jsonData);

                foreach (var u in usuarios)
                {
                    if (u["usuario"].ToString() == usuario && u["contrase�a"].ToString() == contrase�a)
                    {
                        return u["rol"].ToString();
                    }
                }
            }

            return null;
        }
    }
}
