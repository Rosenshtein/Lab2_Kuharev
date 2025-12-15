using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab3.Classes.OperationWithDB;
namespace Lab3.Forms
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void outFromProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void outFromAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            UserHasArraysMenu();
        }

        internal void UserHasArraysMenu()
        {
            if (UserHasArrays())
            {
                label1.Text = "     Добро пожаловать!";
                label2.Hide();
                pictureBox1.Hide();
                myArraysToolStripMenuItem.Visible = true;
            }
            else
            {
                myArraysToolStripMenuItem.Visible = false;
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void myArraysToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MyArrays myArrays = new MyArrays();
            myArrays.Show();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddNewArray addNewArray = new AddNewArray();
            addNewArray.Show();
        }

        public void ShowForm()
        {
            Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void Menu_Activated(object sender, EventArgs e)
        {
            UserHasArraysMenu();
        }
    }
}
