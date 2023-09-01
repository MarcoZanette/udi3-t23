namespace udiGrupal
{
    partial class FormIngreso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnIngresoLogin = new System.Windows.Forms.Button();
            this.TxtUserLogin = new System.Windows.Forms.TextBox();
            this.TxtContraLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // BtnIngresoLogin
            // 
            this.BtnIngresoLogin.Location = new System.Drawing.Point(87, 135);
            this.BtnIngresoLogin.Name = "BtnIngresoLogin";
            this.BtnIngresoLogin.Size = new System.Drawing.Size(107, 57);
            this.BtnIngresoLogin.TabIndex = 2;
            this.BtnIngresoLogin.Text = "Ingresar";
            this.BtnIngresoLogin.UseVisualStyleBackColor = true;
            this.BtnIngresoLogin.Click += new System.EventHandler(this.BtnIngresoLogin_Click);
            // 
            // TxtUserLogin
            // 
            this.TxtUserLogin.Location = new System.Drawing.Point(87, 46);
            this.TxtUserLogin.Name = "TxtUserLogin";
            this.TxtUserLogin.Size = new System.Drawing.Size(166, 20);
            this.TxtUserLogin.TabIndex = 3;
            // 
            // TxtContraLogin
            // 
            this.TxtContraLogin.Location = new System.Drawing.Point(87, 90);
            this.TxtContraLogin.Name = "TxtContraLogin";
            this.TxtContraLogin.Size = new System.Drawing.Size(166, 20);
            this.TxtContraLogin.TabIndex = 4;
            // 
            // FormIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.TxtContraLogin);
            this.Controls.Add(this.TxtUserLogin);
            this.Controls.Add(this.BtnIngresoLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormIngreso";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormIngreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnIngresoLogin;
        private System.Windows.Forms.TextBox TxtUserLogin;
        private System.Windows.Forms.TextBox TxtContraLogin;
    }
}

