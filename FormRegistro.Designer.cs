using Microsoft.VisualBasic.Devices;

namespace UCVProviciones
{
    /* partial class FormRegistro
     {
         /// <summary>
         /// Required designer variable.
         /// </summary>
         private System.ComponentModel.IContainer components = null;

         /// <summary>
         /// Clean up any resources being used.
         /// </summary>
         /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
         protected override void Dispose(bool disposing)
         {
             if (disposing && (components != null))
             {
                 components.Dispose();
             }
             base.Dispose(disposing);
         }


         #region Windows Form Designer generated code

         /// <summary>
         /// Required method for Designer support - do not modify
         /// the contents of this method with the code editor.
         /// </summary>
         private void InitializeComponent()
         {
             btnGuardar_Click = new Button();
             txtNuevoUsuario = new TextBox();
             txtNuevaContraseña = new TextBox();
             cmbRol = new ComboBox();
             SuspendLayout();
             // 
             // btnGuardar_Click
             // 
             btnGuardar_Click.Location = new Point(180, 332);
             btnGuardar_Click.Name = "btnGuardar_Click";
             btnGuardar_Click.Size = new Size(94, 29);
             btnGuardar_Click.TabIndex = 0;
             btnGuardar_Click.Text = "Guardar";
             btnGuardar_Click.UseVisualStyleBackColor = true;
             btnGuardar_Click.Click += btnGuardar_Click_Click;
             // 
             // txtNuevoUsuario
             // 
             txtNuevoUsuario.Location = new Point(164, 102);
             txtNuevoUsuario.Name = "txtNuevoUsuario";
             txtNuevoUsuario.Size = new Size(125, 27);
             txtNuevoUsuario.TabIndex = 1;
             // 
             // txtNuevaContraseña
             // 
             txtNuevaContraseña.Location = new Point(164, 194);
             txtNuevaContraseña.Name = "txtNuevaContraseña";
             txtNuevaContraseña.Size = new Size(125, 27);
             txtNuevaContraseña.TabIndex = 2;
             // 
             // cmbRol
             // 
             cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
             cmbRol.FormattingEnabled = true;
             cmbRol.Items.AddRange(new object[] { "funcionario", "directivo", "administrador" });
             cmbRol.Location = new Point(441, 101);
             cmbRol.Name = "cmbRol";
             cmbRol.Size = new Size(156, 28);
             cmbRol.TabIndex = 5;
             // 
             // FormRegistro
             // 
             AutoScaleDimensions = new SizeF(8F, 20F);
             AutoScaleMode = AutoScaleMode.Font;
             ClientSize = new Size(800, 450);
             Controls.Add(cmbRol);
             Controls.Add(txtNuevaContraseña);
             Controls.Add(txtNuevoUsuario);
             Controls.Add(btnGuardar_Click);
             Name = "FormRegistro";
             Text = "FormRegistro";
             ResumeLayout(false);
             PerformLayout();
         }

         #endregion

         private Button btnGuardar_Click;
         private TextBox txtNuevoUsuario;
         private TextBox txtNuevaContraseña;
         private ComboBox cmbRol;
     }*/
    partial class FormRegistro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNuevoUsuario = new TextBox();
            txtNuevaContraseña = new TextBox();
            lblNuevoUsuario = new Label();
            lblNuevaContraseña = new Label();
            lblRol = new Label();
            cmbRol = new ComboBox();
            btnGuardar = new Button();
            NombreNuevoUsuario = new Label();
            ContraseñaNueva = new Label();
            lblRolUsuario = new Label();
            btnCancelarRU = new Button();
            SuspendLayout();
            // 
            // txtNuevoUsuario
            // 
            txtNuevoUsuario.Location = new Point(122, 104);
            txtNuevoUsuario.Margin = new Padding(4, 5, 4, 5);
            txtNuevoUsuario.Name = "txtNuevoUsuario";
            txtNuevoUsuario.Size = new Size(207, 27);
            txtNuevoUsuario.TabIndex = 0;
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.Location = new Point(122, 176);
            txtNuevaContraseña.Margin = new Padding(4, 5, 4, 5);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.PasswordChar = '*';
            txtNuevaContraseña.Size = new Size(207, 27);
            txtNuevaContraseña.TabIndex = 1;
            // 
            // lblNuevoUsuario
            // 
            lblNuevoUsuario.Location = new Point(0, 0);
            lblNuevoUsuario.Margin = new Padding(4, 0, 4, 0);
            lblNuevoUsuario.Name = "lblNuevoUsuario";
            lblNuevoUsuario.Size = new Size(133, 35);
            lblNuevoUsuario.TabIndex = 9;
            // 
            // lblNuevaContraseña
            // 
            lblNuevaContraseña.Location = new Point(0, 0);
            lblNuevaContraseña.Margin = new Padding(4, 0, 4, 0);
            lblNuevaContraseña.Name = "lblNuevaContraseña";
            lblNuevaContraseña.Size = new Size(133, 35);
            lblNuevaContraseña.TabIndex = 8;
            // 
            // lblRol
            // 
            lblRol.Location = new Point(0, 0);
            lblRol.Margin = new Padding(4, 0, 4, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(133, 35);
            lblRol.TabIndex = 7;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Funcionario", "Directivo", "Administrador" });
            cmbRol.Location = new Point(122, 262);
            cmbRol.Margin = new Padding(4, 5, 4, 5);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(207, 28);
            cmbRol.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(122, 342);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 35);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_Click;
            // 
            // NombreNuevoUsuario
            // 
            NombreNuevoUsuario.AutoSize = true;
            NombreNuevoUsuario.Location = new Point(122, 71);
            NombreNuevoUsuario.Name = "NombreNuevoUsuario";
            NombreNuevoUsuario.Size = new Size(59, 20);
            NombreNuevoUsuario.TabIndex = 10;
            NombreNuevoUsuario.Text = "Usuario";
            // 
            // ContraseñaNueva
            // 
            ContraseñaNueva.AutoSize = true;
            ContraseñaNueva.Location = new Point(122, 151);
            ContraseñaNueva.Name = "ContraseñaNueva";
            ContraseñaNueva.Size = new Size(83, 20);
            ContraseñaNueva.TabIndex = 11;
            ContraseñaNueva.Text = "Contraseña";
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.Location = new Point(122, 236);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(110, 20);
            lblRolUsuario.TabIndex = 12;
            lblRolUsuario.Text = "Rol del Usuario";
            // 
            // btnCancelarRU
            // 
            btnCancelarRU.Location = new Point(294, 342);
            btnCancelarRU.Name = "btnCancelarRU";
            btnCancelarRU.Size = new Size(99, 35);
            btnCancelarRU.TabIndex = 13;
            btnCancelarRU.Text = "Cancelar";
            btnCancelarRU.UseVisualStyleBackColor = true;
            btnCancelarRU.Click += btnCancelarRU_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 439);
            Controls.Add(btnCancelarRU);
            Controls.Add(lblRolUsuario);
            Controls.Add(ContraseñaNueva);
            Controls.Add(NombreNuevoUsuario);
            Controls.Add(btnGuardar);
            Controls.Add(cmbRol);
            Controls.Add(lblRol);
            Controls.Add(lblNuevaContraseña);
            Controls.Add(lblNuevoUsuario);
            Controls.Add(txtNuevaContraseña);
            Controls.Add(txtNuevoUsuario);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormRegistro";
            Text = "Registro de Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnGuardar;
        private Label NombreNuevoUsuario;
        private Label ContraseñaNueva;
        private Label lblRolUsuario;
        private Button btnCancelarRU;
    }
}