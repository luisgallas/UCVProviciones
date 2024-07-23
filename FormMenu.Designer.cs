namespace UCVProviciones
{
    /*partial class FormMenu
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
            btnAtrasLogin = new Button();
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
            btnVerificarEstadoSolicitudes.Location = new Point(200, 12);
            btnVerificarEstadoSolicitudes.Name = "btnVerificarEstadoSolicitudes";
            btnVerificarEstadoSolicitudes.Size = new Size(192, 29);
            btnVerificarEstadoSolicitudes.TabIndex = 1;
            btnVerificarEstadoSolicitudes.Text = "Verificar Pedidos";
            btnVerificarEstadoSolicitudes.UseVisualStyleBackColor = true;
            btnVerificarEstadoSolicitudes.Click += btnVerificarEstadoSolicitudes_Click;
            // 
            // btnAprobarPedidos
            // 
            btnAprobarPedidos.Location = new Point(398, 12);
            btnAprobarPedidos.Name = "btnAprobarPedidos";
            btnAprobarPedidos.Size = new Size(191, 29);
            btnAprobarPedidos.TabIndex = 2;
            btnAprobarPedidos.Text = "Aprobar pedidos";
            btnAprobarPedidos.UseVisualStyleBackColor = true;
            btnAprobarPedidos.Click += btnAprobarPedidos_Click;
            // 
            // btnAccesoTotal
            // 
            btnAccesoTotal.Location = new Point(605, 12);
            btnAccesoTotal.Name = "btnAccesoTotal";
            btnAccesoTotal.Size = new Size(191, 29);
            btnAccesoTotal.TabIndex = 3;
            btnAccesoTotal.Text = "Acceso Total";
            btnAccesoTotal.UseVisualStyleBackColor = true;
            // 
            // btnAtrasLogin
            // 
            btnAtrasLogin.Location = new Point(36, 302);
            btnAtrasLogin.Name = "btnAtrasLogin";
            btnAtrasLogin.Size = new Size(94, 29);
            btnAtrasLogin.TabIndex = 4;
            btnAtrasLogin.Text = "Atras";
            btnAtrasLogin.UseVisualStyleBackColor = true;
            btnAtrasLogin.Click += btnAtrasLogin_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 450);
            Controls.Add(btnAtrasLogin);
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
        private Button btnAtrasLogin;
    }*/
    partial class FormMenu
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
            btnSolicitarCompras = new Button();
            btnVerificarPedidos = new Button();
            btnAprobarPedidos = new Button();
            btnAtrasMaL = new Button();
            SuspendLayout();
            // 
            // btnSolicitarCompras
            // 
            btnSolicitarCompras.Location = new Point(13, 14);
            btnSolicitarCompras.Margin = new Padding(4, 5, 4, 5);
            btnSolicitarCompras.Name = "btnSolicitarCompras";
            btnSolicitarCompras.Size = new Size(200, 46);
            btnSolicitarCompras.TabIndex = 0;
            btnSolicitarCompras.Text = "Solicitar Compras";
            btnSolicitarCompras.UseVisualStyleBackColor = true;
            btnSolicitarCompras.Click += btnSolicitarCompras_Click;
            // 
            // btnVerificarPedidos
            // 
            btnVerificarPedidos.Location = new Point(13, 74);
            btnVerificarPedidos.Margin = new Padding(4, 5, 4, 5);
            btnVerificarPedidos.Name = "btnVerificarPedidos";
            btnVerificarPedidos.Size = new Size(200, 46);
            btnVerificarPedidos.TabIndex = 1;
            btnVerificarPedidos.Text = "Verificar Pedidos";
            btnVerificarPedidos.UseVisualStyleBackColor = true;
            btnVerificarPedidos.Click += btnVerificarPedidos_Click;
            // 
            // btnAprobarPedidos
            // 
            btnAprobarPedidos.Location = new Point(13, 141);
            btnAprobarPedidos.Margin = new Padding(4, 5, 4, 5);
            btnAprobarPedidos.Name = "btnAprobarPedidos";
            btnAprobarPedidos.Size = new Size(200, 46);
            btnAprobarPedidos.TabIndex = 2;
            btnAprobarPedidos.Text = "Aprobar Pedidos";
            btnAprobarPedidos.UseVisualStyleBackColor = true;
            btnAprobarPedidos.Click += btnAprobarPedidos_Click;
            // 
            // btnAtrasMaL
            // 
            btnAtrasMaL.Location = new Point(270, 303);
            btnAtrasMaL.Name = "btnAtrasMaL";
            btnAtrasMaL.Size = new Size(94, 29);
            btnAtrasMaL.TabIndex = 3;
            btnAtrasMaL.Text = "Atras";
            btnAtrasMaL.UseVisualStyleBackColor = true;
            btnAtrasMaL.Click += btnAtrasMaL_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 369);
            Controls.Add(btnAtrasMaL);
            Controls.Add(btnSolicitarCompras);
            Controls.Add(btnVerificarPedidos);
            Controls.Add(btnAprobarPedidos);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMenu";
            Text = "Menú Principal";
            Load += FormMenu_Load;
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnSolicitarCompras;
        private System.Windows.Forms.Button btnVerificarPedidos;
        private System.Windows.Forms.Button btnAprobarPedidos;
        private System.Windows.Forms.Button btnAtrasMenu;
        private Button btnAtrasMaL;
    }
}