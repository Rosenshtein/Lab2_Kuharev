using Lab3.Classes;
using Lab3.Forms;
using static Lab3.Classes.OperationWithDB;

namespace Lab3
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AutorizationMethod(LoginTB.Text, PasswordTB.Text.Trim()))
                NextToMain();
        }

        internal void NextToMain()
        {
            Hide();
            new Menu().ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Registration(this).Show();
            Hide();      
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {


            Label lbl = sender as Label;
            if (lbl != null)
            {
                lbl.ForeColor = Color.Navy; // исходный цвет
            }
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl != null)
            {
                lbl.ForeColor = Color.RoyalBlue; // выбери любой цвет
            }
        }

        private void Aut_Load(object sender, EventArgs e)
        {
            ConnectToDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Aut_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection(myConnect);
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTB.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }
    }
}
