﻿using System;
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
        public FormIngreso()
        {
            InitializeComponent();
            TxtContraLogin.UseSystemPasswordChar = false;
            TxtContraLogin.PasswordChar = '☺';
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresoLogin_Click(object sender, EventArgs e)
        {
            string usuarioAcceso = "admin";
            string claveAcceso = "123321";

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
