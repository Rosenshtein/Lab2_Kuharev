namespace Lab3.Forms
{
    partial class AddNewArray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewArray));
            lblAddNewArray = new Label();
            rbtnAdd = new RadioButton();
            rbntGenArray = new RadioButton();
            tbArrayOriginal = new TextBox();
            btnSort = new Button();
            tbSortedArray = new TextBox();
            lblMyArray = new Label();
            lblSortedArray = new Label();
            lblMin = new Label();
            tbMin = new TextBox();
            tbMax = new TextBox();
            lblMax = new Label();
            btnGenerate = new Button();
            tbDimension = new TextBox();
            lblRazmer = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblAddNewArray
            // 
            lblAddNewArray.AutoSize = true;
            lblAddNewArray.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAddNewArray.Location = new Point(19, 35);
            lblAddNewArray.Margin = new Padding(6, 0, 6, 0);
            lblAddNewArray.Name = "lblAddNewArray";
            lblAddNewArray.Size = new Size(398, 46);
            lblAddNewArray.TabIndex = 12;
            lblAddNewArray.Text = "Добавить новый массив";
            // 
            // rbtnAdd
            // 
            rbtnAdd.AutoSize = true;
            rbtnAdd.Checked = true;
            rbtnAdd.Location = new Point(19, 92);
            rbtnAdd.Margin = new Padding(4, 5, 4, 5);
            rbtnAdd.Name = "rbtnAdd";
            rbtnAdd.Size = new Size(229, 36);
            rbtnAdd.TabIndex = 13;
            rbtnAdd.TabStop = true;
            rbtnAdd.Text = "Добавить вручную";
            rbtnAdd.UseVisualStyleBackColor = true;
            rbtnAdd.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbntGenArray
            // 
            rbntGenArray.AutoSize = true;
            rbntGenArray.Location = new Point(19, 123);
            rbntGenArray.Margin = new Padding(4, 5, 4, 5);
            rbntGenArray.Name = "rbntGenArray";
            rbntGenArray.Size = new Size(298, 36);
            rbntGenArray.TabIndex = 14;
            rbntGenArray.Text = "Сгенерировать случайно";
            rbntGenArray.UseVisualStyleBackColor = true;
            rbntGenArray.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // tbArrayOriginal
            // 
            tbArrayOriginal.Location = new Point(324, 110);
            tbArrayOriginal.Multiline = true;
            tbArrayOriginal.Name = "tbArrayOriginal";
            tbArrayOriginal.Size = new Size(349, 134);
            tbArrayOriginal.TabIndex = 15;
            tbArrayOriginal.KeyPress += textBox1_KeyPress;
            // 
            // btnSort
            // 
            btnSort.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            btnSort.Location = new Point(383, 440);
            btnSort.Margin = new Padding(4);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(199, 39);
            btnSort.TabIndex = 16;
            btnSort.Text = "Отсортировать";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += button1_Click;
            // 
            // tbSortedArray
            // 
            tbSortedArray.Location = new Point(324, 290);
            tbSortedArray.Multiline = true;
            tbSortedArray.Name = "tbSortedArray";
            tbSortedArray.ReadOnly = true;
            tbSortedArray.Size = new Size(349, 134);
            tbSortedArray.TabIndex = 17;
            // 
            // lblMyArray
            // 
            lblMyArray.AutoSize = true;
            lblMyArray.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMyArray.Location = new Point(324, 71);
            lblMyArray.Margin = new Padding(6, 0, 6, 0);
            lblMyArray.Name = "lblMyArray";
            lblMyArray.Size = new Size(212, 46);
            lblMyArray.TabIndex = 18;
            lblMyArray.Text = "Ваш массив:";
            // 
            // lblSortedArray
            // 
            lblSortedArray.AutoSize = true;
            lblSortedArray.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSortedArray.Location = new Point(324, 247);
            lblSortedArray.Margin = new Padding(6, 0, 6, 0);
            lblSortedArray.Name = "lblSortedArray";
            lblSortedArray.Size = new Size(313, 46);
            lblSortedArray.TabIndex = 19;
            lblSortedArray.Text = "Отсортированный:";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMin.Location = new Point(33, 171);
            lblMin.Margin = new Padding(6, 0, 6, 0);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(287, 32);
            lblMin.TabIndex = 20;
            lblMin.Text = "Минимальное значение:";
            lblMin.Visible = false;
            // 
            // tbMin
            // 
            tbMin.Location = new Point(37, 200);
            tbMin.MaxLength = 5;
            tbMin.Name = "tbMin";
            tbMin.Size = new Size(220, 39);
            tbMin.TabIndex = 21;
            tbMin.Visible = false;
            tbMin.KeyPress += textBox3_KeyPress;
            // 
            // tbMax
            // 
            tbMax.Location = new Point(37, 275);
            tbMax.MaxLength = 5;
            tbMax.Name = "tbMax";
            tbMax.Size = new Size(220, 39);
            tbMax.TabIndex = 23;
            tbMax.Visible = false;
            tbMax.KeyPress += textBox4_KeyPress;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMax.Location = new Point(33, 246);
            lblMax.Margin = new Padding(6, 0, 6, 0);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(295, 32);
            lblMax.TabIndex = 22;
            lblMax.Text = "Максимальное значение:";
            lblMax.Visible = false;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            btnGenerate.Location = new Point(51, 440);
            btnGenerate.Margin = new Padding(4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(197, 39);
            btnGenerate.TabIndex = 24;
            btnGenerate.Text = "Сгенерировать";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += button2_Click;
            // 
            // tbDimension
            // 
            tbDimension.Location = new Point(37, 351);
            tbDimension.MaxLength = 4;
            tbDimension.Name = "tbDimension";
            tbDimension.Size = new Size(220, 39);
            tbDimension.TabIndex = 26;
            tbDimension.Visible = false;
            tbDimension.KeyPress += textBox5_KeyPress;
            // 
            // lblRazmer
            // 
            lblRazmer.AutoSize = true;
            lblRazmer.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblRazmer.Location = new Point(33, 322);
            lblRazmer.Margin = new Padding(6, 0, 6, 0);
            lblRazmer.Name = "lblRazmer";
            lblRazmer.Size = new Size(156, 32);
            lblRazmer.TabIndex = 25;
            lblRazmer.Text = "Размерность";
            lblRazmer.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            btnSave.Location = new Point(231, 504);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(258, 39);
            btnSave.TabIndex = 27;
            btnSave.Text = "Сохранить массивы";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button3_Click;
            // 
            // AddNewArray
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(738, 556);
            Controls.Add(btnSave);
            Controls.Add(tbDimension);
            Controls.Add(lblRazmer);
            Controls.Add(btnGenerate);
            Controls.Add(tbMax);
            Controls.Add(lblMax);
            Controls.Add(tbMin);
            Controls.Add(lblMin);
            Controls.Add(lblSortedArray);
            Controls.Add(lblMyArray);
            Controls.Add(tbSortedArray);
            Controls.Add(btnSort);
            Controls.Add(tbArrayOriginal);
            Controls.Add(rbntGenArray);
            Controls.Add(rbtnAdd);
            Controls.Add(lblAddNewArray);
            Font = new Font("Segoe UI Variable Display Semil", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddNewArray";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить новый массив || CombSortAPP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddNewArray;
        private RadioButton rbtnAdd;
        private RadioButton rbntGenArray;
        private TextBox tbArrayOriginal;
        private Button btnSort;
        private TextBox tbSortedArray;
        private Label lblMyArray;
        private Label lblSortedArray;
        private Label lblMin;
        private TextBox tbMin;
        private TextBox tbMax;
        private Label lblMax;
        private Button btnGenerate;
        private TextBox tbDimension;
        private Label lblRazmer;
        private Button btnSave;
    }
}