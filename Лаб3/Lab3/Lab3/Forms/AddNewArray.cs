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
using static Lab3.Classes.CombSort;

namespace Lab3.Forms
{
    public partial class AddNewArray : Form
    {
        public AddNewArray()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = (TextBox)sender;

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;

            if (e.KeyChar == ' ')
            {
                if (tb.SelectionStart == 0) { e.Handled = true; return; }     // пробел в начале
                if (tb.Text.EndsWith(" ")) { e.Handled = true; return; }      // два подряд
                return;
            }

            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbArrayOriginal.Text.Length > 0)
            {
                if (TryGetArrayFromText(tbArrayOriginal.Text, out int[] arr, out string err))
                {
                    int[] sortedArr = Sort(arr);
                    textBox2.Text = string.Join(" ", sortedArr);
                }
            }
            else MessageBox.Show("Вы не ввели значения!", " :( ");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbntGenArray.Checked)
            {
                label3.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
                tbMin.Visible = true;
                tbMax.Visible = true;
                tbDimension.Visible = true;
            }
            else
            {
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = true;
                tbMin.Visible = false;
                tbMax.Visible = false;
                tbDimension.Visible = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = (TextBox)sender;

            // Backspace, Delete, стрелки и т.п.
            if (char.IsControl(e.KeyChar)) return;

            // Цифры всегда можно
            if (char.IsDigit(e.KeyChar)) return;

            // Минус — только в самом начале и только один раз
            if (e.KeyChar == '-')
            {
                bool atStart = tb.SelectionStart == 0;
                bool alreadyHasMinus = tb.Text.Contains('-');

                if (atStart && !alreadyHasMinus)
                    return;

                e.Handled = true;
                return;
            }

            // Всё остальное запрещаем (в т.ч. пробелы)
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = (TextBox)sender;

            // Backspace, Delete, стрелки и т.п.
            if (char.IsControl(e.KeyChar)) return;

            // Цифры всегда можно
            if (char.IsDigit(e.KeyChar)) return;

            // Минус — только в самом начале и только один раз
            if (e.KeyChar == '-')
            {
                bool atStart = tb.SelectionStart == 0;
                bool alreadyHasMinus = tb.Text.Contains('-');

                if (atStart && !alreadyHasMinus)
                    return;

                e.Handled = true;
                return;
            }

            // Всё остальное запрещаем (в т.ч. пробелы)
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbntGenArray.Checked)
            {
                int[] arr = new int[Convert.ToInt32(tbDimension.Text)];
                GenerateRandomArray(arr, Convert.ToInt32(tbMin.Text), Convert.ToInt32(tbMax.Text));
                tbArrayOriginal.Text = string.Join(" ", arr);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = (TextBox)sender;

            // Backspace, Delete, стрелки и т.п.
            if (char.IsControl(e.KeyChar)) return;

            // Цифры всегда можно
            if (char.IsDigit(e.KeyChar)) return;


            // Всё остальное запрещаем (в т.ч. пробелы)
            e.Handled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAdd.Checked)
            {
                tbArrayOriginal.Text = "";
                textBox2.Text = "";
            }
            else
            {
                tbArrayOriginal.Text = "";
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (TryGetArrayFromText(tbArrayOriginal.Text, out int[] arr, out string err))
            {
                TryGetArrayFromText(textBox2.Text, out int[] arrSort, out string errSort);
                OperationWithDB.SaveOriginalArray(arr);
                OperationWithDB.InsertArrayItems(arr);
                if (OperationWithDB.SaveSortedArray(arrSort))
                    if (OperationWithDB.InsertArrayItemsSort(arrSort))
                        MessageBox.Show("Успешно сохранено!", "Успешно!");
                Close();

            }
        }

       
    }
}
