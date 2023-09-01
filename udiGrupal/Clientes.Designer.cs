namespace udiGrupal
{
    partial class Clientes
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
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelActualizacion = new System.Windows.Forms.Panel();
            this.textBox_id_cl = new System.Windows.Forms.TextBox();
            this.LBL_id_cl = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.button_mostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelActualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCargaGenerico
            // 
            this.BtnCargaGenerico.Location = new System.Drawing.Point(16, 152);
            this.BtnCargaGenerico.Click += new System.EventHandler(this.BtnCargaGenerico_Click);
            // 
            // TxtIdGenerico
            // 
            this.TxtIdGenerico.Location = new System.Drawing.Point(69, 202);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 205);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono:";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(81, 93);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionCliente.TabIndex = 7;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(81, 126);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoCliente.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 500);
            this.dataGridView1.TabIndex = 9;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(61, 269);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 20;
            this.btn_modificar.Text = "modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(108, 228);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 19;
            this.btn_borrar.Text = "borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(18, 228);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelActualizacion
            // 
            this.panelActualizacion.Controls.Add(this.textBox_id_cl);
            this.panelActualizacion.Controls.Add(this.LBL_id_cl);
            this.panelActualizacion.Controls.Add(this.textBoxTelefono);
            this.panelActualizacion.Controls.Add(this.btnactualizar);
            this.panelActualizacion.Controls.Add(this.label6);
            this.panelActualizacion.Controls.Add(this.label7);
            this.panelActualizacion.Controls.Add(this.textBoxDireccion);
            this.panelActualizacion.Controls.Add(this.label8);
            this.panelActualizacion.Controls.Add(this.textBoxNombre);
            this.panelActualizacion.Location = new System.Drawing.Point(2, 318);
            this.panelActualizacion.Name = "panelActualizacion";
            this.panelActualizacion.Size = new System.Drawing.Size(222, 203);
            this.panelActualizacion.TabIndex = 21;
            // 
            // textBox_id_cl
            // 
            this.textBox_id_cl.Location = new System.Drawing.Point(100, 30);
            this.textBox_id_cl.Name = "textBox_id_cl";
            this.textBox_id_cl.Size = new System.Drawing.Size(100, 20);
            this.textBox_id_cl.TabIndex = 15;
            // 
            // LBL_id_cl
            // 
            this.LBL_id_cl.AutoSize = true;
            this.LBL_id_cl.Location = new System.Drawing.Point(25, 33);
            this.LBL_id_cl.Name = "LBL_id_cl";
            this.LBL_id_cl.Size = new System.Drawing.Size(49, 13);
            this.LBL_id_cl.TabIndex = 14;
            this.LBL_id_cl.Text = "id cliente";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(100, 121);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 6;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(115, 162);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 13;
            this.btnactualizar.Text = "actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "apellido";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(100, 91);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccion.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Telefono";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(100, 57);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // button_mostrar
            // 
            this.button_mostrar.Location = new System.Drawing.Point(106, 152);
            this.button_mostrar.Name = "button_mostrar";
            this.button_mostrar.Size = new System.Drawing.Size(75, 23);
            this.button_mostrar.TabIndex = 22;
            this.button_mostrar.Text = "mostrar";
            this.button_mostrar.UseVisualStyleBackColor = true;
            this.button_mostrar.Click += new System.EventHandler(this.button_mostrar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(658, 533);
            this.Controls.Add(this.button_mostrar);
            this.Controls.Add(this.panelActualizacion);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.txtTelefonoCliente);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.BtnCargaGenerico, 0);
            this.Controls.SetChildIndex(this.TxtNombreGenerico, 0);
            this.Controls.SetChildIndex(this.txtTelefonoCliente, 0);
            this.Controls.SetChildIndex(this.txtDireccionCliente, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtIdGenerico, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.panelActualizacion, 0);
            this.Controls.SetChildIndex(this.button_mostrar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelActualizacion.ResumeLayout(false);
            this.panelActualizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelActualizacion;
        private System.Windows.Forms.TextBox textBox_id_cl;
        private System.Windows.Forms.Label LBL_id_cl;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button button_mostrar;

    }
}