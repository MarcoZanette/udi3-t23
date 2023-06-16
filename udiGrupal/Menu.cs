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
    }
}
