using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercarpp
{
    
    public partial  class Form1 : Form
    {
        //Se Hace la vinculacion con la BD por medio de una objeto
        ConexionCompraDataContext obj = new ConexionCompraDataContext();
        
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Se hacen las conversiones de los tipos segun sea el caso para  lograr hacer el insert en la BD
            int IdProducto = Convert.ToInt32(txtIdProducto.Text);
            int Cedula = Convert.ToInt32(txtCedula.Text);
            DateTime Fecha = Convert.ToDateTime(txtFecha.Text);
            int Precio = Convert.ToInt32(txtPrecio.Text);
            //Por medio del objeto creado en el datacontext se llama el store procedure y se listan los campos del formulario
            obj.InsertarCompra(IdProducto, Cedula,txtProducto.Text,txtCantidad.Text, txtDescuento.Text, Precio, txtLugar.Text, Fecha, txtTipoDeProducto.Text, txtDescripcion.Text);

            MessageBox.Show("tu registro se ha insertado");
            listar();
            limpiar();
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listar();
        }
        //Metodo para Listar los registros de la BD y que se visualicen en el datagrid
        void listar()
        {
            dataGridView1.DataSource = obj.ListarCompra();
        }
        
        //MEtodo para limpiar los  valores de los Textbox
        void limpiar()
        {
            
            txtIdProducto.Text = "";
            txtCantidad.Text = "";
            txtDescuento.Text = "";
            txtPrecio.Text = "";           
            txtProducto.Text = "";
            txtDescripcion.Text = "";
            
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                label11.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtCedula.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtProducto.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtCantidad.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtDescuento.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtLugar.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtFecha.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtTipoDeProducto.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtIdProducto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

       

        
    }
}
