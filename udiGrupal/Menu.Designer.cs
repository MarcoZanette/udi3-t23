namespace udiGrupal
{
    partial class Menu
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
            this.BtnProductosMenu = new System.Windows.Forms.Button();
            this.BtnProveedoresMenu = new System.Windows.Forms.Button();
            this.BtnClienteMenu = new System.Windows.Forms.Button();
            this.BtnConfiguracionMenu = new System.Windows.Forms.Button();
            this.BtnSalirMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProductosMenu
            // 
            this.BtnProductosMenu.Location = new System.Drawing.Point(24, 49);
            this.BtnProductosMenu.Name = "BtnProductosMenu";
            this.BtnProductosMenu.Size = new System.Drawing.Size(109, 51);
            this.BtnProductosMenu.TabIndex = 0;
            this.BtnProductosMenu.Text = "Producto";
            this.BtnProductosMenu.UseVisualStyleBackColor = true;
            this.BtnProductosMenu.Click += new System.EventHandler(this.BtnProductosMenu_Click);
            // 
            // BtnProveedoresMenu
            // 
            this.BtnProveedoresMenu.Location = new System.Drawing.Point(156, 49);
            this.BtnProveedoresMenu.Name = "BtnProveedoresMenu";
            this.BtnProveedoresMenu.Size = new System.Drawing.Size(109, 51);
            this.BtnProveedoresMenu.TabIndex = 1;
            this.BtnProveedoresMenu.Text = "Proveedores";
            this.BtnProveedoresMenu.UseVisualStyleBackColor = true;
            this.BtnProveedoresMenu.Click += new System.EventHandler(this.BtnProveedoresMenu_Click);
            // 
            // BtnClienteMenu
            // 
            this.BtnClienteMenu.Location = new System.Drawing.Point(24, 134);
            this.BtnClienteMenu.Name = "BtnClienteMenu";
            this.BtnClienteMenu.Size = new System.Drawing.Size(109, 52);
            this.BtnClienteMenu.TabIndex = 2;
            this.BtnClienteMenu.Text = "Clientes";
            this.BtnClienteMenu.UseVisualStyleBackColor = true;
            this.BtnClienteMenu.Click += new System.EventHandler(this.BtnClienteMenu_Click);
            // 
            // BtnConfiguracionMenu
            // 
            this.BtnConfiguracionMenu.Location = new System.Drawing.Point(156, 134);
            this.BtnConfiguracionMenu.Name = "BtnConfiguracionMenu";
            this.BtnConfiguracionMenu.Size = new System.Drawing.Size(109, 52);
            this.BtnConfiguracionMenu.TabIndex = 3;
            this.BtnConfiguracionMenu.Text = "Configuracion";
            this.BtnConfiguracionMenu.UseVisualStyleBackColor = true;
            this.BtnConfiguracionMenu.Click += new System.EventHandler(this.BtnConfiguracionMenu_Click);
            // 
            // BtnSalirMenu
            // 
            this.BtnSalirMenu.Location = new System.Drawing.Point(205, 234);
            this.BtnSalirMenu.Name = "BtnSalirMenu";
            this.BtnSalirMenu.Size = new System.Drawing.Size(75, 23);
            this.BtnSalirMenu.TabIndex = 4;
            this.BtnSalirMenu.Text = "Salir";
            this.BtnSalirMenu.UseVisualStyleBackColor = true;
            this.BtnSalirMenu.Click += new System.EventHandler(this.BtnSalirMenu_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.BtnSalirMenu);
            this.Controls.Add(this.BtnConfiguracionMenu);
            this.Controls.Add(this.BtnClienteMenu);
            this.Controls.Add(this.BtnProveedoresMenu);
            this.Controls.Add(this.BtnProductosMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProductosMenu;
        private System.Windows.Forms.Button BtnProveedoresMenu;
        private System.Windows.Forms.Button BtnClienteMenu;
        private System.Windows.Forms.Button BtnConfiguracionMenu;
        private System.Windows.Forms.Button BtnSalirMenu;
    }
}