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
        Acceso sql1;
        DataTable tabla = new DataTable();

        private string NombreProducto;
        private double Precio_venta;
        private string consulta;
        private int cantidad;

        public Productos()
        {
                InitializeComponent();
                sql1 = new Acceso();
                panel2.Visible = false;
                mostrar_tabla();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
        }

        private void BtnCargaGenerico_Click_1(object sender, EventArgs e)
        {

            NombreProducto = TxtNombreGenerico.Text;
            Precio_venta = Convert.ToDouble(Textbox_Pventa.Text);
            cantidad = Convert.ToInt32(txtCantidad.Text);
            consulta = String.Format("insert into producto(nombre,precio_venta,cantidad) values('{0}',{1},{2})", NombreProducto, Precio_venta, cantidad);
            sql1.ConsultaEscritura(consulta);
            MessageBox.Show("Producto guardado con éxito");
            Textbox_Pventa.Text = "";
            TxtNombreGenerico.Text = "";
            txtCantidad.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = string.Format("Select * From producto where id_producto={0}", TxtIdGenerico.Text);
            tabla = sql1.ConsultaLectura(consulta);
            dataGridView1.DataSource = tabla;

            if (tabla.Rows.Count == 0) {
                MessageBox.Show("No se encontro ningun producto.", "Atencion");
            }

        }





        private void TxtIdGenerico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_seleccionar_todo_Click(object sender, EventArgs e)
        {
            mostrar_tabla();
        }

        private void mostrar_tabla()
    {
            tabla.Clear();
            string consulta = string.Format("Select * From producto");
            tabla = sql1.ConsultaLectura(consulta);
            dataGridView1.DataSource = tabla;

    }


        private void btn_borrar_Click(object sender, EventArgs e)
        {

            if(dataGridView1.SelectedRows.Count==1)
            {
            
             try
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        string consulta = string.Format("Delete from producto where id_producto=" + Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
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
                MessageBox.Show("Por favor seleccion un registro a borrar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {

                panel2.Visible = true;
                textBox_id_producto.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
                textBoxNombre.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                textBoxPrecio.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
                textBoxCantidad.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);

            }
            else
            {
                MessageBox.Show("Seleccione un registro a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string consulta = string.Format("Update producto set nombre='{1}',precio_venta={2},cantidad={3} where id_producto={0}", textBox_id_producto.Text, textBoxNombre.Text, textBoxPrecio.Text, textBoxCantidad.Text);
            sql1.ConsultaEscritura(consulta);
            MessageBox.Show("Producto actualizado con exito");

            panel2.Hide();
            textBox_id_producto.Text = "";
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
            textBoxCantidad.Text = "";

            mostrar_tabla();



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      

     
            




        }



    }










    

