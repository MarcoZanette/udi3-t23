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
    public partial class Productos : Generico
    {
        private string NombreProducto;
        private double Precio_venta;


        public Productos()
        {
                InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

            NombreProducto = TxtNombreGenerico.Text;
            Precio_venta = Textbox_Pventa.Text;


        }

        
    }
}
