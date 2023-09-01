namespace udiGrupal
{
    partial class Generico
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
            this.TxtIdGenerico = new System.Windows.Forms.TextBox();
            this.TxtNombreGenerico = new System.Windows.Forms.TextBox();
            this.BtnCargaGenerico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // TxtIdGenerico
            // 
            this.TxtIdGenerico.Location = new System.Drawing.Point(81, 34);
            this.TxtIdGenerico.Name = "TxtIdGenerico";
            this.TxtIdGenerico.Size = new System.Drawing.Size(100, 20);
            this.TxtIdGenerico.TabIndex = 2;
            // 
            // TxtNombreGenerico
            // 
            this.TxtNombreGenerico.Location = new System.Drawing.Point(81, 59);
            this.TxtNombreGenerico.Name = "TxtNombreGenerico";
            this.TxtNombreGenerico.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreGenerico.TabIndex = 3;
            // 
            // BtnCargaGenerico
            // 
            this.BtnCargaGenerico.Location = new System.Drawing.Point(194, 234);
            this.BtnCargaGenerico.Name = "BtnCargaGenerico";
            this.BtnCargaGenerico.Size = new System.Drawing.Size(75, 23);
            this.BtnCargaGenerico.TabIndex = 4;
            this.BtnCargaGenerico.Text = "Guardar";
            this.BtnCargaGenerico.UseVisualStyleBackColor = true;
            this.BtnCargaGenerico.Click += new System.EventHandler(this.BtnCargaGenerico_Click);
            // 
            // Generico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.BtnCargaGenerico);
            this.Controls.Add(this.TxtNombreGenerico);
            this.Controls.Add(this.TxtIdGenerico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Generico";
            this.Text = "Generico";
            this.Load += new System.EventHandler(this.Generico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button BtnCargaGenerico;
        public System.Windows.Forms.TextBox TxtIdGenerico;
        public System.Windows.Forms.TextBox TxtNombreGenerico;
        protected System.Windows.Forms.Label label1;
    }
}