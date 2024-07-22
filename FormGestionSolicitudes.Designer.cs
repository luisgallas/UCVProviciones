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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            dataGridViewSolicitudes = new DataGridView();
            btnAprobar = new Button();
            btnRechazar = new Button();
            btnModificar = new Button();
            btnATRasGSC = new Button();
            lblGSC = new Label();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSolicitudes
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewSolicitudes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridViewSolicitudes.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewSolicitudes.Location = new Point(31, 106);
            dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridViewSolicitudes.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewSolicitudes.RowHeadersWidth = 51;
            dataGridViewSolicitudes.Size = new Size(846, 300);
            dataGridViewSolicitudes.TabIndex = 0;
            // 
            // btnAprobar
            // 
            btnAprobar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAprobar.Location = new Point(4, 519);
            btnAprobar.Margin = new Padding(10, 9, 10, 9);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(131, 50);
            btnAprobar.TabIndex = 1;
            btnAprobar.Text = "Aprobar";
            btnAprobar.UseVisualStyleBackColor = true;
            btnAprobar.Click += btnAprobar_Click;
            // 
            // btnRechazar
            // 
            btnRechazar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRechazar.Location = new Point(143, 521);
            btnRechazar.Margin = new Padding(10, 9, 10, 9);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(170, 50);
            btnRechazar.TabIndex = 2;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(333, 521);
            btnModificar.Margin = new Padding(10, 9, 10, 9);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(122, 50);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnATRasGSC
            // 
            btnATRasGSC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnATRasGSC.Location = new Point(794, 443);
            btnATRasGSC.Margin = new Padding(7, 5, 7, 5);
            btnATRasGSC.Name = "btnATRasGSC";
            btnATRasGSC.Size = new Size(137, 46);
            btnATRasGSC.TabIndex = 5;
            btnATRasGSC.Text = "Atras";
            btnATRasGSC.UseVisualStyleBackColor = true;
            btnATRasGSC.Click += btnATRasGSC_Click;
            // 
            // lblGSC
            // 
            lblGSC.AutoSize = true;
            lblGSC.Location = new Point(168, 38);
            lblGSC.Name = "lblGSC";
            lblGSC.Size = new Size(549, 35);
            lblGSC.TabIndex = 6;
            lblGSC.Text = "GESTIÓN DE SOLICITUDE DE COMPRAS";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(566, 519);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(200, 46);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar Solicitud";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormGestionSolicitudes
            // 
            AutoScaleDimensions = new SizeF(19F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 611);
            Controls.Add(btnEliminar);
            Controls.Add(lblGSC);
            Controls.Add(btnATRasGSC);
            Controls.Add(btnModificar);
            Controls.Add(btnRechazar);
            Controls.Add(btnAprobar);
            Controls.Add(dataGridViewSolicitudes);
            Font = new Font("Stencil", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(10, 9, 10, 9);
            Name = "FormGestionSolicitudes";
            Text = "Gestión de Solicitudes de Compra";
            Load += FormGestionSolicitudes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnModificar;
        private Button btnATRasGSC;
        private Label lblGSC;
        private Button btnEliminar;
    }
}