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
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSolicitudes
            // 
            dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSolicitudes.Location = new Point(16, 18);
            dataGridViewSolicitudes.Margin = new Padding(4, 5, 4, 5);
            dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            dataGridViewSolicitudes.RowHeadersWidth = 51;
            dataGridViewSolicitudes.Size = new Size(747, 462);
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
            // FormSolicitudCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 586);
            Controls.Add(btnNuevaSolicitud);
            Controls.Add(dataGridViewSolicitudes);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormSolicitudCompras";
            Text = "Solicitud de Compras";
            Load += FormSolicitudCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private System.Windows.Forms.Button btnNuevaSolicitud;
    }
}