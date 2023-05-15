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

namespace InsertarRegistro
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MiBaseDeDatos;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Tabla (Columna1, Columna2, Columna3) VALUES ";
            if (checkBox1.Checked)
            {
                query += string.Format("('{0}', '{1}', '{2}'), ", "Valor1", "Valor2", "Valor3");
            }
            if (checkBox2.Checked)
            {
                query += string.Format("('{0}', '{1}', '{2}'), ", "Valor4", "Valor5", "Valor6");
            }
            if (checkBox3.Checked)
            {

            }
        }
    }
}
