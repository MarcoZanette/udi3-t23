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
    public partial class Clientes : Generico
    {
        Acceso sql1;

        public Clientes()
        {
            InitializeComponent();
            sql1 = new Acceso();
        }

        private void BtnCargaGenerico_Click(object sender, EventArgs e)
        {



            string consulta = "INSERT INTO cliente (Id, Nombre, Direccion, Telefono) values (" + 
                Int32.Parse(TxtIdGenerico.Text)+
                ", '" + TxtNombreGenerico.Text+
                "','" + txtDireccionCliente.Text + 
                "'," + Int32.Parse(txtTelefonoCliente.Text)+")";

            sql1.ConsultaEscritura(consulta);
        }


    }
}
