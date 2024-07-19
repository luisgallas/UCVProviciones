namespace UCVProviciones
{
    /* partial class FormGestionSolicitudes
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
             this.Text = "FormGestionSolicitudes";
         }

         #endregion
     }*/
    partial class FormGestionSolicitudes
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
            btnAprobar = new Button();
            btnRechazar = new Button();
            btnModificar = new Button();
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
            dataGridViewSolicitudes.Size = new Size(1013, 462);
            dataGridViewSolicitudes.TabIndex = 0;
            // 
            // btnAprobar
            // 
            btnAprobar.Location = new Point(16, 508);
            btnAprobar.Margin = new Padding(4, 5, 4, 5);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(133, 46);
            btnAprobar.TabIndex = 1;
            btnAprobar.Text = "Aprobar";
            btnAprobar.UseVisualStyleBackColor = true;
            btnAprobar.Click += btnAprobar_Click;
            // 
            // btnRechazar
            // 
            btnRechazar.Location = new Point(173, 508);
            btnRechazar.Margin = new Padding(4, 5, 4, 5);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(133, 46);
            btnRechazar.TabIndex = 2;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(333, 508);
            btnModificar.Margin = new Padding(4, 5, 4, 5);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(133, 46);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FormGestionSolicitudes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 586);
            Controls.Add(btnModificar);
            Controls.Add(btnRechazar);
            Controls.Add(btnAprobar);
            Controls.Add(dataGridViewSolicitudes);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormGestionSolicitudes";
            Text = "Gestión de Solicitudes de Compra";
            Load += FormGestionSolicitudes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnModificar;
    }
}