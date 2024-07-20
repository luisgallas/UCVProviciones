namespace UCVProviciones
{
    /*partial class FormSolicitudCompras
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
             SuspendLayout();
             // 
             // FormSolicitudCompras
             // 
             AutoScaleDimensions = new SizeF(8F, 20F);
             AutoScaleMode = AutoScaleMode.Font;
             ClientSize = new Size(800, 450);
             Name = "FormSolicitudCompras";
             Text = "FormSolicitudCompras";
             Load += FormSolicitudCompras_Load;
             ResumeLayout(false);
         }

         #endregion
     }*/
    partial class FormSolicitudCompras
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
            btnNuevaSolicitud = new Button();
            lblAtrasSoliCompras = new Button();
            lblSolicitudCompras = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSolicitudes
            // 
            dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSolicitudes.Location = new Point(13, 110);
            dataGridViewSolicitudes.Margin = new Padding(4, 5, 4, 5);
            dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            dataGridViewSolicitudes.RowHeadersWidth = 51;
            dataGridViewSolicitudes.Size = new Size(747, 372);
            dataGridViewSolicitudes.TabIndex = 0;
            // 
            // btnNuevaSolicitud
            // 
            btnNuevaSolicitud.Location = new Point(16, 508);
            btnNuevaSolicitud.Margin = new Padding(4, 5, 4, 5);
            btnNuevaSolicitud.Name = "btnNuevaSolicitud";
            btnNuevaSolicitud.Size = new Size(200, 46);
            btnNuevaSolicitud.TabIndex = 1;
            btnNuevaSolicitud.Text = "Nueva Solicitud";
            btnNuevaSolicitud.UseVisualStyleBackColor = true;
            btnNuevaSolicitud.Click += btnNuevaSolicitud_Click;
            // 
            // lblAtrasSoliCompras
            // 
            lblAtrasSoliCompras.ImageAlign = ContentAlignment.TopCenter;
            lblAtrasSoliCompras.Location = new Point(294, 508);
            lblAtrasSoliCompras.Name = "lblAtrasSoliCompras";
            lblAtrasSoliCompras.Size = new Size(117, 48);
            lblAtrasSoliCompras.TabIndex = 2;
            lblAtrasSoliCompras.Text = "Atras";
            lblAtrasSoliCompras.UseVisualStyleBackColor = true;
            lblAtrasSoliCompras.Click += lblAtrasSoliCompras_Click;
            // 
            // lblSolicitudCompras
            // 
            lblSolicitudCompras.AutoSize = true;
            lblSolicitudCompras.Font = new Font("Stencil", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSolicitudCompras.ForeColor = Color.Red;
            lblSolicitudCompras.Location = new Point(239, 20);
            lblSolicitudCompras.Name = "lblSolicitudCompras";
            lblSolicitudCompras.Size = new Size(390, 35);
            lblSolicitudCompras.TabIndex = 3;
            lblSolicitudCompras.Text = "SOLICITUDES DE COMPRAS";
            lblSolicitudCompras.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormSolicitudCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 568);
            Controls.Add(lblSolicitudCompras);
            Controls.Add(lblAtrasSoliCompras);
            Controls.Add(btnNuevaSolicitud);
            Controls.Add(dataGridViewSolicitudes);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormSolicitudCompras";
            Text = "Solicitud de Compras";
            Load += FormSolicitudCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private System.Windows.Forms.Button btnNuevaSolicitud;
        private Button lblAtrasSoliCompras;
        private Label lblSolicitudCompras;
    }
}