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

                if (ValidarUsuario(usuario, contrase�a))
                {
                    MessageBox.Show("Login exitoso");
                    // Aqu� puedes agregar el c�digo para abrir una nueva ventana o lo que necesites hacer despu�s del login
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
        private bool ValidarUsuario(string usuario, string contrase�a)
        {
            if (File.Exists(UsuariosFilePath))
            {
                var jsonData = File.ReadAllText(UsuariosFilePath);
                var usuarios = JArray.Parse(jsonData);

                foreach (var u in usuarios)
                {
                    if (u["usuario"].ToString() == usuario && u["contrase�a"].ToString() == contrase�a)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
