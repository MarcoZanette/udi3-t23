using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace udiGrupal
{
    public partial class Confirguracion : Form
    {
        Acceso sql1;

        public Confirguracion()
        {
            InitializeComponent();
            sql1 = new Acceso();
        
        }


        private void Confirguracion_Load(object sender, EventArgs e)
        {

            txtMuestraUsuarioConfig.Text = "admin";

            txtMuestraUsuarioConfig.ReadOnly = true;

        }

        private void btnGuardarConfiguaracion_Click(object sender, EventArgs e)
        {


            string consulta = "UPDATE Usuario SET Contra = '"+ txtCambioContra.Text +"' WHERE Nombre = 'admin' ";
            sql1.ConsultaEscritura(consulta);


            string consulta1 = "UPDATE IVA SET IVA = " + txtCambioIVA.Text + " WHERE Id = 2 ";
            sql1.ConsultaEscritura(consulta1);

            MessageBox.Show("Guardado con Exito");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
