namespace UCVProviciones
{
    partial class FormMenu
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
            btnSolicitarCompras = new Button();
            btnVerificarEstadoSolicitudes = new Button();
            btnAprobarPedidos = new Button();
            btnAccesoTotal = new Button();
            SuspendLayout();
            // 
            // btnSolicitarCompras
            // 
            btnSolicitarCompras.Location = new Point(3, 12);
            btnSolicitarCompras.Name = "btnSolicitarCompras";
            btnSolicitarCompras.Size = new Size(191, 29);
            btnSolicitarCompras.TabIndex = 0;
            btnSolicitarCompras.Text = "Solicitar compras";
            btnSolicitarCompras.UseVisualStyleBackColor = true;
            btnSolicitarCompras.Click += btnSolicitarCompras_Click;
            // 
            // btnVerificarEstadoSolicitudes
            // 
            btnVerificarEstadoSolicitudes.Location = new Point(2, 70);
            btnVerificarEstadoSolicitudes.Name = "btnVerificarEstadoSolicitudes";
            btnVerificarEstadoSolicitudes.Size = new Size(192, 29);
            btnVerificarEstadoSolicitudes.TabIndex = 1;
            btnVerificarEstadoSolicitudes.Text = "verificar solicitud";
            btnVerificarEstadoSolicitudes.UseVisualStyleBackColor = true;
            // 
            // btnAprobarPedidos
            // 
            btnAprobarPedidos.Location = new Point(3, 133);
            btnAprobarPedidos.Name = "btnAprobarPedidos";
            btnAprobarPedidos.Size = new Size(191, 29);
            btnAprobarPedidos.TabIndex = 2;
            btnAprobarPedidos.Text = "Aprobar pedidos";
            btnAprobarPedidos.UseVisualStyleBackColor = true;
            // 
            // btnAccesoTotal
            // 
            btnAccesoTotal.Location = new Point(3, 197);
            btnAccesoTotal.Name = "btnAccesoTotal";
            btnAccesoTotal.Size = new Size(191, 29);
            btnAccesoTotal.TabIndex = 3;
            btnAccesoTotal.Text = "Acceso Total";
            btnAccesoTotal.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAccesoTotal);
            Controls.Add(btnAprobarPedidos);
            Controls.Add(btnVerificarEstadoSolicitudes);
            Controls.Add(btnSolicitarCompras);
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSolicitarCompras;
        private Button btnVerificarEstadoSolicitudes;
        private Button btnAprobarPedidos;
        private Button btnAccesoTotal;
    }
}