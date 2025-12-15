using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Classes;
using static Lab3.Classes.OperationWithDB;
namespace Lab3.Forms
{
    public partial class MyArrays : Form
    {
        public MyArrays()
        {
            InitializeComponent();
        }

        private void MyArrays_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadTable(dtArrays);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int arrayId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["array_id"].Value);
            textBox1.Text = LoadArrayValuesAsText(arrayId);
        }

        private void MyArrays_FormClosed(object sender, FormClosedEventArgs e)
        {
       
        }
    }
}
