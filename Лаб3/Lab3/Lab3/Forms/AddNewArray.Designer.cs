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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            button3 = new Button();
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(19, 92);
            radioButton1.Margin = new Padding(4, 5, 4, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(229, 36);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Добавить вручную";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(19, 123);
            radioButton2.Margin = new Padding(4, 5, 4, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(298, 36);
            radioButton2.TabIndex = 14;
            radioButton2.Text = "Сгенерировать случайно";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 110);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 134);
            textBox1.TabIndex = 15;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            button1.Location = new Point(383, 440);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(199, 39);
            button1.TabIndex = 16;
            button1.Text = "Отсортировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // textBox3
            // 
            textBox3.Location = new Point(37, 200);
            textBox3.MaxLength = 10;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 39);
            textBox3.TabIndex = 21;
            textBox3.Visible = false;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(37, 275);
            textBox4.MaxLength = 10;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 39);
            textBox4.TabIndex = 23;
            textBox4.Visible = false;
            textBox4.KeyPress += textBox4_KeyPress;
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
            // button2
            // 
            button2.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            button2.Location = new Point(51, 440);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(197, 39);
            button2.TabIndex = 24;
            button2.Text = "Сгенерировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(37, 351);
            textBox5.MaxLength = 10;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(220, 39);
            textBox5.TabIndex = 26;
            textBox5.Visible = false;
            textBox5.KeyPress += textBox5_KeyPress;
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
            // button3
            // 
            button3.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            button3.Location = new Point(231, 504);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(258, 39);
            button3.TabIndex = 27;
            button3.Text = "Сохранить массивы";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AddNewArray
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(738, 556);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
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
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Button button2;
        private TextBox textBox5;
        private Label label6;
        private Button button3;
    }
}