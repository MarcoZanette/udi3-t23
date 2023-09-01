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
    public partial class Proveedores : Generico
    {
        Acceso sql1;
        DataTable tabla = new DataTable();

        private string NombreProveedor;
        private string ApellidoProveedor;
        private string DomicilioProveedor;
        private string consulta;
        

        public Proveedores()
        {
            InitializeComponent();
            sql1 = new Acceso();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

       

        private void BtnCargaGenerico_Click_1(object sender, EventArgs e)
        {
            NombreProveedor = TxtNombreGenerico.Text;
            ApellidoProveedor = TxtApellidoProv.Text;
            DomicilioProveedor = TxtDomicilioProv.Text;
            consulta = String.Format("insert into proveedor(nombre,apellido, domicilio) values('{0}','{1}','{2}')", NombreProveedor, ApellidoProveedor, DomicilioProveedor);
            sql1.ConsultaEscritura(consulta);
            MessageBox.Show("Proveedor guardado con exito");
            TxtNombreGenerico.Text = "";
            TxtApellidoProv.Text = "";
            TxtDomicilioProv.Text = "";
        }

        private void button_mostrar_Click(object sender, EventArgs e)
        {
            tabla.Clear();
            string consulta = string.Format("Select * From proveedor");
            tabla = sql1.ConsultaLectura(consulta);
            dataGridView1.DataSource = tabla;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = string.Format("Select * From proveedor where id_proveedor={0}", TxtIdGenerico.Text);
            tabla = sql1.ConsultaLectura(consulta);
            dataGridView1.DataSource = tabla;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        string consulta = string.Format("Delete from proveedor where id_proveedor=" + Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
                        sql1.ConsultaEscritura(consulta);
                        int indiceActual = dataGridView1.SelectedRows[0].Index;
                        dataGridView1.Rows.RemoveAt(indiceActual);
                        MessageBox.Show("Registro eliminado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un registro a borrar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                panel2.Visible = true;
                textBox_id_prov.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
                textBoxNombre.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                textBoxApellido.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
                textBoxdomicilio.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);

            }
            else
            {
                MessageBox.Show("Seleccione un registro a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string consulta = string.Format("Update proveedor set nombre='{1}',apellido='{2}',domicilio='{3}' where id_proveedor={0}", textBox_id_prov.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxdomicilio.Text);
            sql1.ConsultaEscritura(consulta);
            MessageBox.Show("Proveedor actualizado con exito");
        }








        




    }
}