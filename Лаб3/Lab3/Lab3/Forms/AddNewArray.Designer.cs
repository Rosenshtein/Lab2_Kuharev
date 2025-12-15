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
            label5 = new Label();
            rbtnAdd = new RadioButton();
            rbntGenArray = new RadioButton();
            tbArrayOriginal = new TextBox();
            btnSort = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbMin = new TextBox();
            tbMax = new TextBox();
            label4 = new Label();
            btnGenerate = new Button();
            tbDimension = new TextBox();
            label6 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(19, 35);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(398, 46);
            label5.TabIndex = 12;
            label5.Text = "Добавить новый массив";
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
            // textBox2
            // 
            textBox2.Location = new Point(324, 290);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(349, 134);
            textBox2.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(324, 71);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 46);
            label1.TabIndex = 18;
            label1.Text = "Ваш массив:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(324, 247);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(313, 46);
            label2.TabIndex = 19;
            label2.Text = "Отсортированный:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(33, 171);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(287, 32);
            label3.TabIndex = 20;
            label3.Text = "Минимальное значение:";
            label3.Visible = false;
            // 
            // tbMin
            // 
            tbMin.Location = new Point(37, 200);
            tbMin.MaxLength = 10;
            tbMin.Name = "tbMin";
            tbMin.Size = new Size(220, 39);
            tbMin.TabIndex = 21;
            tbMin.Visible = false;
            tbMin.KeyPress += textBox3_KeyPress;
            // 
            // tbMax
            // 
            tbMax.Location = new Point(37, 275);
            tbMax.MaxLength = 10;
            tbMax.Name = "tbMax";
            tbMax.Size = new Size(220, 39);
            tbMax.TabIndex = 23;
            tbMax.Visible = false;
            tbMax.KeyPress += textBox4_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(33, 246);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(295, 32);
            label4.TabIndex = 22;
            label4.Text = "Максимальное значение:";
            label4.Visible = false;
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
            tbDimension.MaxLength = 10;
            tbDimension.Name = "tbDimension";
            tbDimension.Size = new Size(220, 39);
            tbDimension.TabIndex = 26;
            tbDimension.Visible = false;
            tbDimension.KeyPress += textBox5_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(33, 322);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(156, 32);
            label6.TabIndex = 25;
            label6.Text = "Размерность";
            label6.Visible = false;
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
            Controls.Add(label6);
            Controls.Add(btnGenerate);
            Controls.Add(tbMax);
            Controls.Add(label4);
            Controls.Add(tbMin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(btnSort);
            Controls.Add(tbArrayOriginal);
            Controls.Add(rbntGenArray);
            Controls.Add(rbtnAdd);
            Controls.Add(label5);
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

        private Label label5;
        private RadioButton rbtnAdd;
        private RadioButton rbntGenArray;
        private TextBox tbArrayOriginal;
        private Button btnSort;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbMin;
        private TextBox tbMax;
        private Label label4;
        private Button btnGenerate;
        private TextBox tbDimension;
        private Label label6;
        private Button btnSave;
    }
}