using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLenguajeC.Repositorio;
using ProyectoLenguajeC.Modelo;
using System.Diagnostics.Contracts;

namespace ProyectoLenguajeC.Vista
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void TxBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBoxNombreLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void PnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        public class Usuariosss
        {
            public Usuariosss(string nombre, string contra)
            {
                this.nombre = nombre;
                this.contra = contra;
            }

            public string nombre { get; set; }
            public string contra { get; set; }



        }
        string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True";
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Usuariosss usuario = new Usuariosss(TextBoxNombreLog.Text, TextBoxContra.Text);
                
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre=@nombre AND [password]=@password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", usuario.nombre);
                    command.Parameters.AddWithValue("@password", usuario.contra);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");
                        FormMenu formMenu = new FormMenu();
                        this.Hide();
                        formMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al establecer la conexión: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
