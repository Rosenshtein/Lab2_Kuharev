namespace Lab3.Forms
{
    partial class MyArrays
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyArrays));
            dataGridView1 = new DataGridView();
            label5 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            array_id = new DataGridViewTextBoxColumn();
            array_role = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { array_id, array_role });
            dataGridView1.Location = new Point(27, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(398, 175);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(27, 19);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(184, 36);
            label5.TabIndex = 11;
            label5.Text = "Мои массивы";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(461, 70);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(384, 175);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(461, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 36);
            label1.TabIndex = 13;
            label1.Text = "Элементы массива";
            label1.Click += label1_Click;
            // 
            // array_id
            // 
            array_id.DataPropertyName = "array_id";
            array_id.HeaderText = "Номер массива";
            array_id.Name = "array_id";
            array_id.ReadOnly = true;
            array_id.Resizable = DataGridViewTriState.False;
            // 
            // array_role
            // 
            array_role.DataPropertyName = "array_role";
            array_role.HeaderText = "Тип массива";
            array_role.Name = "array_role";
            array_role.ReadOnly = true;
            array_role.Resizable = DataGridViewTriState.False;
            // 
            // MyArrays
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(876, 460);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI Variable Display Semil", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MyArrays";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мои массивы || CombSortAPP";
            FormClosed += MyArrays_FormClosed;
            Load += MyArrays_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox1;
        private Label label1;
        private DataGridViewTextBoxColumn array_id;
        private DataGridViewTextBoxColumn array_role;
    }
}