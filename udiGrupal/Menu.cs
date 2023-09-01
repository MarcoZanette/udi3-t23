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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnClienteMenu_Click(object sender, EventArgs e)
        {
            Clientes c1 = new Clientes();
            c1.Show();
        }

        private void BtnSalirMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnProductosMenu_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.Show();
        }

        private void BtnConfiguracionMenu_Click(object sender, EventArgs e)
        {
            Confirguracion Config = new Confirguracion();
            Config.Show();
        }

        private void BtnProveedoresMenu_Click(object sender, EventArgs e)
        {
            Proveedores Prov = new Proveedores();
            Prov.Show();
        }
    }
}
