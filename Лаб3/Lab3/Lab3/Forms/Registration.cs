using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Classes;

namespace Lab3
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aut aut = new Aut();
            aut.Show();
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }
        
        internal void CloseForm()
        {
            Aut aut = new Aut();
            aut.Show();
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTB1.UseSystemPasswordChar = !checkBox1.Checked;
            PasswordTB2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckPassTB() )
               if (OperationWithDB.Reg(LoginTB.Text, PasswordTB2.Text))
                  MessageBox.Show("Вы успешно зарестрировались!", "Успешно!");
                  CloseForm();
        }

        internal bool CheckPassTB()
        {
            if (PasswordTB1.Text == PasswordTB2.Text)
                return true;
            else
                MessageBox.Show("Пароли не совпадают!", "Ошибка!");
                return false;
        }
    }
}
