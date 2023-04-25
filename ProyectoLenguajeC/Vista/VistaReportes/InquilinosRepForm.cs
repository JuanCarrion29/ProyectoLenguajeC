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

namespace ProyectoLenguajeC.Vista.VistaReportes
{
    public partial class InquilinosRepForm : Form
    {
        public InquilinosRepForm()
        {
            InitializeComponent();
        }

        private void InquilinosRepForm_Load(object sender, EventArgs e)
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
    }
}
