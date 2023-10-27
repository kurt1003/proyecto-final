using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_final
{
    public partial class Productos : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=inventario; Uid=root; Pwd=;");

        public Productos()
        {
           
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chkCheckedCh(object sender,EventArgs eventArgs)
        {
           
        }
        private void Productos_Load(object sender, EventArgs e)
        {

            conexion.Open();
            string cadena = "SELECT nombre_producto AS Producto,codigo AS Código,marca AS Marca,precio AS Precio,stock AS Stock FROM producto";


            MySqlDataAdapter adaptador = new MySqlDataAdapter(cadena, conexion);

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
           
            conexion.Close();


      

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox_código.Checked == true)
            {

                string searchTerm = textBox_buscador.Text;
                string query = "SELECT nombre_producto AS Producto,Código,Stock,Precio FROM  producto WHERE Código LIKE @parametro";
                using (MySqlCommand command = new MySqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@parametro", "%" + searchTerm + "%");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable; // Muestra los resultados en el DataGridView.
                    }

                }
            }
            else
            if (checkBox_producto.Checked == true)
            {
                string searchTerm = textBox_buscador.Text;
                string query = "SELECT nombre_producto AS Producto,Código,Stock,Precio FROM  producto WHERE nombre_producto LIKE @parametro";
                using (MySqlCommand command = new MySqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@parametro", "%" + searchTerm + "%");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable; // Muestra los resultados en el DataGridView.
                    }
                }

            }
            else
                if(checkBox_marca.Checked == true) 
            {
                string searchTerm = textBox_buscador.Text;
                string query = "SELECT nombre_producto AS Producto,Código,Stock,Precio FROM  producto WHERE marca LIKE @parametro";
                using (MySqlCommand command = new MySqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@parametro", "%" + searchTerm + "%");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable; // Muestra los resultados en el DataGridView.
                    }
                }


            }

    

    }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
