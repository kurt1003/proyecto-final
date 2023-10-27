using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_final
{
    public partial class Actualizar : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=inventario; Uid=root; Pwd=;");

        public Actualizar()
        {
            InitializeComponent();
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox_marca_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            // Obtener datos ingresados por el usuario
            string nombreProveedor = textBox_proveedor.Text;
            string correoProveedor = textBox_correo.Text;
            string telefono=textBox_telefono.Text;
            string direccion=textBox_direccion.Text;
            string nombreMarca =textBox_marca.Text;
            string nombreProducto = textBox_producto.Text;
            string codigoProducto =textBox_codigo.Text;
            string stock=textBox_stock.Text;
            string precio=textBox_precio.Text;

            // Insertar proveedor
            string insertProveedorQuery = "INSERT INTO proveedor (nombre_proveedor, correo,direecion,telefono) VALUES (@NombreProveedor, @Correo,@direccion,@telefono);";
            MySqlCommand insertProveedorCommand = new MySqlCommand(insertProveedorQuery, conexion);
            insertProveedorCommand.Parameters.AddWithValue("@NombreProveedor", nombreProveedor);
            insertProveedorCommand.Parameters.AddWithValue("@Correo", correoProveedor);
            insertProveedorCommand.Parameters.AddWithValue("@direccion", direccion);
            insertProveedorCommand.Parameters.AddWithValue("@telefono", telefono);
            insertProveedorCommand.ExecuteNonQuery();

            // Obtener el ID del proveedor insertado
            int proveedorId = (int)insertProveedorCommand.LastInsertedId;

            // Insertar marca
            string insertMarcaQuery = "INSERT INTO marca (nombre_marca) VALUES (@NombreMarca);";
            MySqlCommand insertMarcaCommand = new MySqlCommand(insertMarcaQuery, conexion);
            insertMarcaCommand.Parameters.AddWithValue("@NombreMarca", nombreMarca);
            insertMarcaCommand.ExecuteNonQuery();

            // Obtener el ID de la marca insertada
            int marcaId = (int)insertMarcaCommand.LastInsertedId;

            // Insertar producto relacionado con el proveedor y la marca
            string insertProductoQuery = "INSERT INTO producto (producto_nombre, codigo,stock,precio,descripcion proveedor_id, marca_id) " +
                                         "VALUES (@ProductoNombre, @Codigo, @ProveedorId, @MarcaId);";
            MySqlCommand insertProductoCommand = new MySqlCommand(insertProductoQuery, conexion);
            insertProductoCommand.Parameters.AddWithValue("@ProductoNombre", nombreProducto);
            insertProductoCommand.Parameters.AddWithValue("@Codigo", codigoProducto);
            insertProductoCommand.Parameters.AddWithValue("@stock", nombreProducto);
            insertProductoCommand.Parameters.AddWithValue("@precio", codigoProducto);
            insertProductoCommand.Parameters.AddWithValue("@ProveedorId", proveedorId);
            insertProductoCommand.Parameters.AddWithValue("@MarcaId", marcaId);
            insertProductoCommand.ExecuteNonQuery();

            MessageBox.Show("Datos insertados correctamente.");
            conexion.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_proveedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
