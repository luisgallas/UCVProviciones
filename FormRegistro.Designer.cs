﻿namespace UCVProviciones
{
    partial class FormRegistro
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
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}