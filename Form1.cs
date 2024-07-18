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

                if (ValidarUsuario(usuario, contraseña))
                {
                    MessageBox.Show("Login exitoso");
                    // Aquí puedes agregar el código para abrir una nueva ventana o lo que necesites hacer después del login
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
        private bool ValidarUsuario(string usuario, string contraseña)
        {
            if (File.Exists(UsuariosFilePath))
            {
                var jsonData = File.ReadAllText(UsuariosFilePath);
                var usuarios = JArray.Parse(jsonData);

                foreach (var u in usuarios)
                {
                    if (u["usuario"].ToString() == usuario && u["contraseña"].ToString() == contraseña)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
