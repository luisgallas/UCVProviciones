﻿namespace UCVProviciones
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar_Click = new Button();
            btnCancelar_Click = new Button();
            lableUsuario = new Label();
            labelContraseña = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnRegistrar_Click = new Button();
            lblProviciones = new Label();
            SuspendLayout();
            // 
            // btnAceptar_Click
            // 
            btnAceptar_Click.Location = new Point(267, 335);
            btnAceptar_Click.Name = "btnAceptar_Click";
            btnAceptar_Click.Size = new Size(94, 29);
            btnAceptar_Click.TabIndex = 0;
            btnAceptar_Click.Text = "Aceptar";
            btnAceptar_Click.UseVisualStyleBackColor = true;
            btnAceptar_Click.Click += btnAceptar_Click_Click;
            // 
            // btnCancelar_Click
            // 
            btnCancelar_Click.Location = new Point(445, 335);
            btnCancelar_Click.Name = "btnCancelar_Click";
            btnCancelar_Click.Size = new Size(94, 29);
            btnCancelar_Click.TabIndex = 1;
            btnCancelar_Click.Text = "Cancelar";
            btnCancelar_Click.UseVisualStyleBackColor = true;
            btnCancelar_Click.Click += btnCancelar_Click_Click;
            // 
            // lableUsuario
            // 
            lableUsuario.AutoSize = true;
            lableUsuario.Location = new Point(343, 113);
            lableUsuario.Name = "lableUsuario";
            lableUsuario.Size = new Size(59, 20);
            lableUsuario.TabIndex = 2;
            lableUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(343, 209);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(83, 20);
            labelContraseña.TabIndex = 3;
            labelContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(343, 151);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(177, 27);
            txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(343, 254);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(177, 27);
            txtContraseña.TabIndex = 5;
            // 
            // btnRegistrar_Click
            // 
            btnRegistrar_Click.Location = new Point(735, 444);
            btnRegistrar_Click.Name = "btnRegistrar_Click";
            btnRegistrar_Click.Size = new Size(94, 29);
            btnRegistrar_Click.TabIndex = 6;
            btnRegistrar_Click.Text = "Registrar";
            btnRegistrar_Click.UseVisualStyleBackColor = true;
            btnRegistrar_Click.Click += btnRegistrar_Click_Click;
            // 
            // lblProviciones
            // 
            lblProviciones.AutoSize = true;
            lblProviciones.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProviciones.ForeColor = SystemColors.ActiveCaptionText;
            lblProviciones.Location = new Point(233, 30);
            lblProviciones.Name = "lblProviciones";
            lblProviciones.Size = new Size(371, 35);
            lblProviciones.TabIndex = 7;
            lblProviciones.Text = "PROVISIONES UC GUAIRA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 485);
            Controls.Add(lblProviciones);
            Controls.Add(btnRegistrar_Click);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(labelContraseña);
            Controls.Add(lableUsuario);
            Controls.Add(btnCancelar_Click);
            Controls.Add(btnAceptar_Click);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar_Click;
        private Button btnCancelar_Click;
        private Label lableUsuario;
        private Label labelContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnRegistrar_Click;
        private Label lblProviciones;
    }
}