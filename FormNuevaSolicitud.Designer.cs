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
    /*partial class FormNuevaSolicitud
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
            dataGridViewSolicitudes = new DataGridView();
            btnAgregarSolicitud = new Button();
            btnGuardarSolicitudes = new Button();
            txtDescripcion = new TextBox();
            txtCantidad = new TextBox();
            lblDescripcion = new Label();
            lblCantidad = new Label();
            btnAtrasNSC = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSolicitudes
            // 
            dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSolicitudes.Location = new Point(16, 27);
            dataGridViewSolicitudes.Margin = new Padding(4, 5, 4, 5);
            dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            dataGridViewSolicitudes.RowHeadersWidth = 51;
            dataGridViewSolicitudes.Size = new Size(1013, 453);
            dataGridViewSolicitudes.TabIndex = 0;
            // 
            // btnAgregarSolicitud
            // 
            btnAgregarSolicitud.Location = new Point(16, 554);
            btnAgregarSolicitud.Margin = new Padding(4, 5, 4, 5);
            btnAgregarSolicitud.Name = "btnAgregarSolicitud";
            btnAgregarSolicitud.Size = new Size(200, 46);
            btnAgregarSolicitud.TabIndex = 1;
            btnAgregarSolicitud.Text = "Agregar Solicitud";
            btnAgregarSolicitud.UseVisualStyleBackColor = true;
            btnAgregarSolicitud.Click += btnAgregarSolicitud_Click;
            // 
            // btnGuardarSolicitudes
            // 
            btnGuardarSolicitudes.Location = new Point(240, 554);
            btnGuardarSolicitudes.Margin = new Padding(4, 5, 4, 5);
            btnGuardarSolicitudes.Name = "btnGuardarSolicitudes";
            btnGuardarSolicitudes.Size = new Size(200, 46);
            btnGuardarSolicitudes.TabIndex = 2;
            btnGuardarSolicitudes.Text = "Guardar Solicitudes";
            btnGuardarSolicitudes.UseVisualStyleBackColor = true;
            btnGuardarSolicitudes.Click += btnGuardarSolicitudes_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(16, 508);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(199, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(240, 508);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(199, 27);
            txtCantidad.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(16, 483);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripción";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(236, 483);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // btnAtrasNSC
            // 
            btnAtrasNSC.Location = new Point(799, 554);
            btnAtrasNSC.Name = "btnAtrasNSC";
            btnAtrasNSC.Size = new Size(109, 46);
            btnAtrasNSC.TabIndex = 7;
            btnAtrasNSC.Text = "Atras";
            btnAtrasNSC.UseVisualStyleBackColor = true;
            btnAtrasNSC.Click += btnAtrasNSC_Click;
            // 
            // FormNuevaSolicitud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 632);
            Controls.Add(btnAtrasNSC);
            Controls.Add(lblCantidad);
            Controls.Add(lblDescripcion);
            Controls.Add(txtCantidad);
            Controls.Add(txtDescripcion);
            Controls.Add(btnGuardarSolicitudes);
            Controls.Add(btnAgregarSolicitud);
            Controls.Add(dataGridViewSolicitudes);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormNuevaSolicitud";
            Text = "Nueva Solicitud de Compras";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private System.Windows.Forms.Button btnAgregarSolicitud;
        private System.Windows.Forms.Button btnGuardarSolicitudes;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private Button btnAtrasNSC;
    }
}