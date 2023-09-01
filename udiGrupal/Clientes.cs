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
        DataTable tabla = new DataTable();

        public Clientes()
        {
            InitializeComponent();
            sql1 = new Acceso();
            mostrarTabla();
        }

        private void BtnCargaGenerico_Click(object sender, EventArgs e)
        {



            string consulta = "INSERT INTO cliente (Nombre, Direccion, Telefono) values (" + 
                "'" + TxtNombreGenerico.Text+
                "','" + txtDireccionCliente.Text + 
                "'," + Int32.Parse(txtTelefonoCliente.Text)+")";

            sql1.ConsultaEscritura(consulta);
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = string.Format("Select * From proveedor where id_proveedor={0}", TxtIdGenerico.Text);
            tabla = sql1.ConsultaLectura(consulta);
            dataGridView1.DataSource = tabla;
        }

        private void button_mostrar_Click(object sender, EventArgs e)
        {
            mostrarTabla();
        }

        private void mostrarTabla()
        {
            tabla.Clear();
            string consulta = string.Format("Select * From cliente");
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
                        string consulta = string.Format("Delete from cliente where cliente=" + Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
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
                
                panelActualizacion.Visible = true;
                textBox_id_cl.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
                textBoxNombre.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                textBoxDireccion.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
                textBoxTelefono.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);

            }
            else
            {
                MessageBox.Show("Seleccione un registro a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string consulta = string.Format("Update cliente set nombre='{1}',direccion='{2}',telefono={3} where Id={0}", textBox_id_cl.Text, textBoxNombre.Text, textBoxDireccion.Text, textBoxTelefono.Text);
            sql1.ConsultaEscritura(consulta);
            MessageBox.Show("Cliente actualizado con exito");

            panelActualizacion.Hide();
            textBox_id_cl.Text = "";
            textBoxNombre.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";

            mostrarTabla();
        }

    }
}
