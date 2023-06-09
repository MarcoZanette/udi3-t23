namespace udiGrupal
{
    partial class Proveedores
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ApellidoProv = new System.Windows.Forms.TextBox();
            this.txt_DomicilioProv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Domicilio";
            // 
            // txt_ApellidoProv
            // 
            this.txt_ApellidoProv.Location = new System.Drawing.Point(81, 87);
            this.txt_ApellidoProv.Name = "txt_ApellidoProv";
            this.txt_ApellidoProv.Size = new System.Drawing.Size(100, 20);
            this.txt_ApellidoProv.TabIndex = 7;
            // 
            // txt_DomicilioProv
            // 
            this.txt_DomicilioProv.Location = new System.Drawing.Point(81, 114);
            this.txt_DomicilioProv.Name = "txt_DomicilioProv";
            this.txt_DomicilioProv.Size = new System.Drawing.Size(100, 20);
            this.txt_DomicilioProv.TabIndex = 8;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ApellidoProv);
            this.Controls.Add(this.txt_DomicilioProv);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.Controls.SetChildIndex(this.txt_DomicilioProv, 0);
            this.Controls.SetChildIndex(this.txt_ApellidoProv, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ApellidoProv;
        private System.Windows.Forms.TextBox txt_DomicilioProv;
    }
}