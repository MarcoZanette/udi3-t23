namespace udiGrupal
{
    partial class Confirguracion
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
            this.txtMuestraUsuarioConfig = new System.Windows.Forms.TextBox();
            this.txtCambioContra = new System.Windows.Forms.TextBox();
            this.txtCambioIVA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardarConfiguaracion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMuestraUsuarioConfig
            // 
            this.txtMuestraUsuarioConfig.Location = new System.Drawing.Point(94, 64);
            this.txtMuestraUsuarioConfig.Name = "txtMuestraUsuarioConfig";
            this.txtMuestraUsuarioConfig.Size = new System.Drawing.Size(100, 20);
            this.txtMuestraUsuarioConfig.TabIndex = 0;
            // 
            // txtCambioContra
            // 
            this.txtCambioContra.Location = new System.Drawing.Point(94, 104);
            this.txtCambioContra.Name = "txtCambioContra";
            this.txtCambioContra.Size = new System.Drawing.Size(100, 20);
            this.txtCambioContra.TabIndex = 1;
            // 
            // txtCambioIVA
            // 
            this.txtCambioIVA.Location = new System.Drawing.Point(94, 179);
            this.txtCambioIVA.Name = "txtCambioIVA";
            this.txtCambioIVA.Size = new System.Drawing.Size(100, 20);
            this.txtCambioIVA.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "I.V.A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cambiar Contraseña del Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cambiar I.V.A";
            // 
            // btnGuardarConfiguaracion
            // 
            this.btnGuardarConfiguaracion.Location = new System.Drawing.Point(205, 234);
            this.btnGuardarConfiguaracion.Name = "btnGuardarConfiguaracion";
            this.btnGuardarConfiguaracion.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarConfiguaracion.TabIndex = 8;
            this.btnGuardarConfiguaracion.Text = "Guardar";
            this.btnGuardarConfiguaracion.UseVisualStyleBackColor = true;
            this.btnGuardarConfiguaracion.Click += new System.EventHandler(this.btnGuardarConfiguaracion_Click);
            // 
            // Confirguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.btnGuardarConfiguaracion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCambioIVA);
            this.Controls.Add(this.txtCambioContra);
            this.Controls.Add(this.txtMuestraUsuarioConfig);
            this.Name = "Confirguracion";
            this.Text = "Confirguracion";
            this.Load += new System.EventHandler(this.Confirguracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMuestraUsuarioConfig;
        private System.Windows.Forms.TextBox txtCambioContra;
        private System.Windows.Forms.TextBox txtCambioIVA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardarConfiguaracion;
    }
}