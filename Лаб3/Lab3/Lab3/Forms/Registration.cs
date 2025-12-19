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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static Lab3.Classes.OperationWithDB;
namespace Lab3
{
    public partial class Registration : Form
    {
        private Form _parent;

        public Registration(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        internal void CloseForm()
        {
            _parent.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTB1.UseSystemPasswordChar = !cBoxShowPassword.Checked;
            PasswordTB2.UseSystemPasswordChar = !cBoxShowPassword.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckPassTB())
                if (IsLoginFree(LoginTB.Text))
                {
                    if (Registration(LoginTB.Text, PasswordTB2.Text))
                        MessageBox.Show("Вы успешно зарегистрировались!", "Успешно!");
                        CloseForm();
                }
                else
                {
                    MessageBox.Show("Логин занят, попробуйте другой!", "Ошибка!");
                }

        }

        internal bool CheckPassTB()
        {
            if (PasswordTB1.Text == PasswordTB2.Text)
                return true;
            else
                MessageBox.Show("Пароли не совпадают!", "Ошибка!");
            return false;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
