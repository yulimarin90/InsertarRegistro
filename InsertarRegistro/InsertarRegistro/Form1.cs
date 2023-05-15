using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InsertarRegistro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
            else if (checkedListBox2.CheckedItems.Count > 0)
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un elemento.");
            }
        }
    }
}
