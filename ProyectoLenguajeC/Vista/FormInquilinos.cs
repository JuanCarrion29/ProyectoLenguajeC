using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using System.Windows;

namespace ProyectoLenguajeC.Vista
{
    public partial class FormInquilinos : Form
    {
        string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private readonly SqlCommandBuilder commandBuilder;
        private DataTable table;


        public class Inquilino
        {
            public Inquilino(string id, string nombre, string apellido, string email, string telefono)
            {
                Nombre = nombre;
                Apellido = apellido;
                Email = email;
                Telefono = telefono;
                this.id = id;
            }

            public string id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Email { get; set; }
            public string Telefono { get; set; }

        }

        private void CargarDatos()
        {
            string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);


            string query = "SELECT * FROM Inquilinos";
            SqlCommand command = new SqlCommand(query, connection);


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataSet dataSet = new System.Data.DataSet();
            adapter.Fill(dataSet);


            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public FormInquilinos()
        {
            InitializeComponent();

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void FormInquilinos_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Inquilinos", connection);
                table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Inquilinos (Nombre, Apellido, Email, Telefono) VALUES (@nombre, @apellido, @email, @telefono)", connection))
                {
                    command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@telefono", txtTelefono.Text);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        System.Windows.MessageBox.Show("Usuario agregado correctamente.");
                        CargarDatos();
                    }
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string id = row.Cells["ID_Inquilino"].Value.ToString();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Inquilinos WHERE ID_Inquilino = @id", conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                CargarDatos();
           
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                DataRow row = table.Rows[index];
                row["Nombre"] = txtNombre.Text;
                row["Apellido"] = txtApellido.Text;
                row["Email"] = txtEmail.Text;
                row["Teléfono"] = txtTelefono.Text;
                dataAdapter.Update(table);
            }
        }
    }
}
