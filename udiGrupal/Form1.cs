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
    public partial class FormIngreso : Form
    {
        Acceso sql1;

        public FormIngreso()
        {
            InitializeComponent();

            sql1 = new Acceso();

            TxtContraLogin.UseSystemPasswordChar = false;
            TxtContraLogin.PasswordChar = '☺';
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresoLogin_Click(object sender, EventArgs e)
        {
            string usuarioAcceso = "admin";
            string consulta = "SELECT Contra FROM Usuario WHERE Nombre = '"+TxtUserLogin.Text+"'";
            DataTable tabla = sql1.ConsultaLectura(consulta);

            string claveAcceso;
            try
            {
                 claveAcceso = tabla.Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex) {
                claveAcceso = "";
            }

            if(TxtUserLogin.Text == usuarioAcceso && TxtContraLogin.Text == claveAcceso)
            {
                Menu InstanciaMenu = new Menu();
                InstanciaMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }
        }
    }
}
