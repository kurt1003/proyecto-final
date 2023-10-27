using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_final
{
    public partial class insertar : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=inventario; Uid=root; Pwd=;");
        public insertar()
        {
            InitializeComponent();
        }

        private void insertar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                conexion.Open();

                MySqlTransaction transaction = conexion.BeginTransaction();

                try
                {
                    
                    string insertProductoQuery = "INSERT INTO producto(idproducto, producto_nombre,codigo,stock,precio,descripcion) VALUES (@productoId,@Nombre_producto, @codigo, @stock, @Precio,@Descripcion )";
                    MySqlCommand insertProductoCommand = new MySqlCommand(insertProductoQuery, conexion, transaction);
                    insertProductoCommand.Parameters.AddWithValue("@productoId", textBox_precio.Text);
                    insertProductoCommand.Parameters.AddWithValue("@Nombre_producto", textBox_producto.Text);
                    insertProductoCommand.Parameters.AddWithValue("@codigo", textBox_codigo.Text);
                    insertProductoCommand.Parameters.AddWithValue("@stock", textBox_stock.Text);
                    insertProductoCommand.Parameters.AddWithValue("@Descripcion", textBox9.Text);
                    insertProductoCommand.Parameters.AddWithValue("@Precio", textBox_precio.Text);
                    insertProductoCommand.ExecuteNonQuery();

                    long productoId = insertProductoCommand.LastInsertedId;

                    // Luego, inserta datos en la tabla marca relacionada con el producto
                    string insertMarcaQuery = "INSERT INTO marca(idproducto, nombre_marca) VALUES (@idProducto, @nombre_marca)";
                    MySqlCommand insertMarcaCommand = new MySqlCommand(insertMarcaQuery, conexion, transaction);
                    insertMarcaCommand.Parameters.AddWithValue("@idProducto", productoId);
                    insertMarcaCommand.Parameters.AddWithValue("@nombre_marca", textBox_marca.Text);
                    insertMarcaCommand.ExecuteNonQuery();

                    long marcaId = insertMarcaCommand.LastInsertedId;

                    // Finalmente, inserta datos en la tabla proveedor relacionada con la marca
                    string insertProveedorQuery = "INSERT INTO proveedor(idmarca, nombre_proveedor, correo_electronico, Direccion, telefono) VALUES (@idmarca, @nombre_proveedor, @correo_electronico, @Direccion, @telefono)";
                    MySqlCommand insertProveedorCommand = new MySqlCommand(insertProveedorQuery, conexion, transaction);
                    insertProveedorCommand.Parameters.AddWithValue("@idmarca", marcaId);
                    insertProveedorCommand.Parameters.AddWithValue("@nombre_proveedor", textBox_proveedor.Text);
                    insertProveedorCommand.Parameters.AddWithValue("@correo_electronico", textBox_correo.Text);
                    insertProveedorCommand.Parameters.AddWithValue("@Direccion", textBox_direccion.Text);
                    insertProveedorCommand.Parameters.AddWithValue("@telefono", textBox_telefono.Text);
                    insertProveedorCommand.ExecuteNonQuery();

                    // Confirmar la transacción
                    transaction.Commit();

                    MessageBox.Show("Los datos se insertaron correctamente.");
                }
                catch (Exception ex)
                {
                    // En caso de error, revertir la transacción
                    transaction.Rollback();
                    MessageBox.Show("Error al insertar datos: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }


        private void textBox_codigo_Enter(object sender, EventArgs e)
        {
            if (textBox_codigo.Text == "Código")
            {
                textBox_codigo.Text = "";
            }
        }

        private void textBox_codigo_Leave(object sender, EventArgs e)
        {
            if (textBox_codigo.Text == "")
            {
                textBox_codigo.Text = "Código";
            }
        }

        private void textBox_producto_Enter(object sender, EventArgs e)
        {
            if (textBox_producto.Text == "Producto")
            {
                textBox_producto.Text = "";
            }
        }

        private void textBox_producto_Leave(object sender, EventArgs e)
        {
            if (textBox_producto.Text == "")
            {
                textBox_producto.Text = "Producto";
            }
        }

        private void textBox_producto_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void textBox_stock_Enter(object sender, EventArgs e)
        {
            if (textBox_stock.Text == "Stock")
            {
                textBox_stock.Text = "";
            }
        }

        private void textBox_stock_Leave(object sender, EventArgs e)
        {
            if (textBox_stock.Text == "")
            {
                textBox_stock.Text = "Stock";
            }
        }

        private void textBox_precio_Enter(object sender, EventArgs e)
        {
            if (textBox_precio.Text == "Precio")
            {
                textBox_precio.Text = "";
            }
        }

        private void textBox_precio_Leave(object sender, EventArgs e)
        {
            if (textBox_precio.Text == "")
            {
                textBox_precio.Text = "Precio";
            }
        }

        private void textBox_marca_Enter(object sender, EventArgs e)
        {
            if (textBox_marca.Text == "Marca")
            {
                textBox_marca.Text = "";
            }
        }

        private void textBox_marca_Leave(object sender, EventArgs e)
        {
            if (textBox_marca.Text == "")
            {
                textBox_marca.Text = "Marca";
            }
        }

        private void textBox_proveedor_Enter(object sender, EventArgs e)
        {

            if (textBox_proveedor.Text == "Proveedor")
            {
                textBox_proveedor.Text = "";
            }
        }

        private void textBox_proveedor_Leave(object sender, EventArgs e)
        {
            if (textBox_proveedor.Text == "")
            {
                textBox_proveedor.Text = "Proveedor";
            }
        }

        private void textBox_telefono_Enter(object sender, EventArgs e)
        {

            if (textBox_telefono.Text == "Número de teléfono")
            {
                textBox_telefono.Text = "";
            }
        }

        private void textBox_telefono_Leave(object sender, EventArgs e)
        {
            if (textBox_telefono.Text == "")
            {
                textBox_telefono.Text = "Número de teléfono";
            }
        }

        private void textBox_correo_Enter(object sender, EventArgs e)
        {
            if (textBox_correo.Text == "Correo electrónico")
            {
                textBox_correo.Text = "";
            }
        }

        private void textBox_correo_Leave(object sender, EventArgs e)
        {
            if (textBox_correo.Text == "")
            {
                textBox_correo.Text = "Correo electrónico";
            }
        }

        private void textBox_direccion_Enter(object sender, EventArgs e)
        {

            if (textBox_direccion.Text == "Dirección")
            {
                textBox_direccion.Text = "";
            }
        }

        private void textBox_direccion_Leave(object sender, EventArgs e)
        {
            if (textBox_direccion.Text == "")
            {
                textBox_direccion.Text = "Dirección";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_proveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_codigo_Enter_1(object sender, EventArgs e)
        {
            if (textBox_codigo.Text == "Código")
            {
                textBox_codigo.Text = "";
            }
        }

        private void textBox_codigo_Leave_1(object sender, EventArgs e)
        {
            if (textBox_codigo.Text == "")
            {
                textBox_codigo.Text = "Código";
            }
        }

        private void textBox_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
