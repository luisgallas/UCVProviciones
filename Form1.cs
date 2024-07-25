using Newtonsoft.Json.Linq;

namespace UCVProviciones
{
    public partial class Form1 : Form
    {
        private const string UsuariosFilePath = "usuarios.json";
        private bool mostrasContrasena = false;
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
                // MessageBox.Show("Login exitoso");
                FormMenu formMenu = new FormMenu(usuario, rol);
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
                    var usuarioToken = u.SelectToken("usuario");
                    var contraseñaToken = u.SelectToken("contraseña");

                    if (usuarioToken != null && contraseñaToken != null)
                    {
                        string usuarioValor = usuarioToken.ToString();
                        string contraseñaValor = contraseñaToken.ToString();

                        if (usuarioValor == usuario && contraseñaValor == contraseña)
                        {
                            var rolToken = u.SelectToken("rol");
                            if (rolToken != null)
                            {
                                return rolToken.ToString();
                            }
                        }
                    }
                    /*if (u["usuario"].ToString() == usuario && u["contraseña"].ToString() == contraseña)
                    {
                        return u["rol"].ToString();
                    }*/
                }
            }
            return null;
        }
            /*if (File.Exists(UsuariosFilePath))
            {
             
            if (File.Exists(UsuariosFilePath))
            {
                var jsonData = File.ReadAllText(UsuariosFilePath);
                var usuarios = JArray.Parse(jsonData);

                foreach (var u in usuarios)
                {
                    if (u["usuario"].ToString() == usuario && u["contraseña"].ToString() == contraseña)
                    {
                        // Aquí ajustamos para manejar un booleano
                        bool esFuncionario = (bool)u["rol"];
                        if (esFuncionario)
                            return "funcionario";
                        else
                            return "administrador"; // Asumiendo que hay un solo administrador por ahora
                    }
                }
            }

            return null;*/
       // }


        private void pbcontrasena_Click(object sender, EventArgs e)
        {
            mostrasContrasena = !mostrasContrasena;
            if (mostrasContrasena)
            {
                txtContraseña.PasswordChar = '\0';
                pbcontrasena.Image = UCVProviciones.Properties.Resources.ocultacontrasena;

            }
            else
            {
                txtContraseña.PasswordChar = '*';
                pbcontrasena.Image = UCVProviciones.Properties.Resources.vercontrasena;
            }
        }

        
    }
}
