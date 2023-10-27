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

namespace proyecto_final
{
    public partial class logincs : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=inventario; Uid=root; Pwd=;");
        public logincs()
        {
            InitializeComponent();
        }

        private void button_esconder_Click(object sender, EventArgs e)
        {
            {
                if (textBox_password.UseSystemPasswordChar)
                {
                    textBox_password.UseSystemPasswordChar = false;
                }
                else
                {
                    textBox_password.UseSystemPasswordChar = true;
                }
                button_esconder.Visible = false;
                button_visualizar.Visible = true;
            }
        }

        private void button_visualizar_Click(object sender, EventArgs e)
        {
            if (textBox_password.UseSystemPasswordChar)
            {
                textBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
            }

            button_esconder.Visible = true;
            button_visualizar .Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string Usuario = textBox_user.Text;
            string Contra = textBox_password.Text;

            conexion.Open();

            string consultaUsuario = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @usuario";
            MySqlCommand comandoUsuario = new MySqlCommand(consultaUsuario, conexion);
            comandoUsuario.Parameters.AddWithValue("@usuario", Usuario);

            int usuarioCount = Convert.ToInt32(comandoUsuario.ExecuteScalar());
            if (Usuario == "" & Contra == "")
            {
                label4.Visible = true;

            }
            else
            {
                if (usuarioCount > 0)
                {
                    // El usuario es válido, ahora verifica la contraseña
                    string consultaContraseña = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @usuario AND password = @contraseña";
                    MySqlCommand comandoContraseña = new MySqlCommand(consultaContraseña, conexion);
                    comandoContraseña.Parameters.AddWithValue("@usuario", Usuario);
                    comandoContraseña.Parameters.AddWithValue("@contraseña", Contra);

                    int contraseñaCount = Convert.ToInt32(comandoContraseña.ExecuteScalar());

                    if (contraseñaCount > 0)
                    {




                        Form2 x = new Form2();
                        this.Hide();
                        x.Show();
                    }
                    else
                    {
                        Form6 x = new Form6();
                        x.ShowDialog();
                        textBox_password.Text = "";
                    }
                }
                else
                {
                    Form5 x = new Form5();

                    x.ShowDialog();
                    textBox_user.Text = "";

                }

            }


            // Cierra la conexión a la base de datos
            conexion.Close();

        }

        private void logincs_Load(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_password.Text))
            {
                label3.Visible = false;
            }
            else
            {
                label3.Visible = true;
            }
        }

        private void textBox_user_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_user.Text))
            {
                label4.Visible = false;
            }
            else
            {
                label4.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_password_Enter(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


