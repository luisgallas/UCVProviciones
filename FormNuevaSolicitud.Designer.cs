namespace UCVProviciones
{
    /* partial class FormNuevaSolicitud
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
             this.components = new System.ComponentModel.Container();
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.ClientSize = new System.Drawing.Size(800, 450);
             this.Text = "FormNuevaSolicitud";
         }

         #endregion

     }*/
    partial class FormNuevaSolicitud
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
            txtCantidad = new TextBox();
            txtDescripcion = new TextBox();
            lblCantidad = new Label();
            lblDescripcion = new Label();
            btnGuardar = new Button();
            btnAtrasNSC = new Button();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(140, 38);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(265, 27);
            txtCantidad.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(140, 100);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(265, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(27, 43);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(27, 105);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(140, 162);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(133, 46);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAtrasNSC
            // 
            btnAtrasNSC.Location = new Point(343, 175);
            btnAtrasNSC.Name = "btnAtrasNSC";
            btnAtrasNSC.Size = new Size(94, 29);
            btnAtrasNSC.TabIndex = 5;
            btnAtrasNSC.Text = "Atras";
            btnAtrasNSC.UseVisualStyleBackColor = true;
            btnAtrasNSC.Click += btnAtrasNSC_Click;
            // 
            // FormNuevaSolicitud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 405);
            Controls.Add(btnAtrasNSC);
            Controls.Add(btnGuardar);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCantidad);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCantidad);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormNuevaSolicitud";
            Text = "Nueva Solicitud de Compra";
            Load += FormNuevaSolicitud_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private Button btnAtrasNSC;
    }
}