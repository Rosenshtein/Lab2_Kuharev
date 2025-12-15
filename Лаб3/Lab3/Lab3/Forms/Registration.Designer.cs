namespace Lab3
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            button2 = new Button();
            label2 = new Label();
            PasswordTB1 = new TextBox();
            label1 = new Label();
            LoginTB = new TextBox();
            label3 = new Label();
            PasswordTB2 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            button2.Location = new Point(27, 367);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(231, 37);
            button2.TabIndex = 3;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Small Semilig", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(28, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 26);
            label2.TabIndex = 10;
            label2.Text = "Пароль";
            // 
            // PasswordTB1
            // 
            PasswordTB1.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            PasswordTB1.Location = new Point(28, 137);
            PasswordTB1.Margin = new Padding(4);
            PasswordTB1.Name = "PasswordTB1";
            PasswordTB1.Size = new Size(232, 33);
            PasswordTB1.TabIndex = 9;
            PasswordTB1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            label1.Location = new Point(23, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 26);
            label1.TabIndex = 8;
            label1.Text = "Логин";
            // 
            // LoginTB
            // 
            LoginTB.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            LoginTB.Location = new Point(27, 59);
            LoginTB.Margin = new Padding(4);
            LoginTB.Name = "LoginTB";
            LoginTB.Size = new Size(232, 33);
            LoginTB.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Small Semilig", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(27, 184);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 26);
            label3.TabIndex = 12;
            label3.Text = "Повторите пароль";
            // 
            // PasswordTB2
            // 
            PasswordTB2.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            PasswordTB2.Location = new Point(27, 214);
            PasswordTB2.Margin = new Padding(4);
            PasswordTB2.Name = "PasswordTB2";
            PasswordTB2.Size = new Size(232, 33);
            PasswordTB2.TabIndex = 11;
            PasswordTB2.UseSystemPasswordChar = true;
            PasswordTB2.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            button1.Location = new Point(26, 322);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(231, 37);
            button1.TabIndex = 13;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(28, 255);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(173, 30);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(292, 436);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(PasswordTB2);
            Controls.Add(label2);
            Controls.Add(PasswordTB1);
            Controls.Add(label1);
            Controls.Add(LoginTB);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация || CombSortAPP";
            FormClosed += Registration_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        private TextBox PasswordTB1;
        private Label label1;
        private TextBox LoginTB;
        private Label label3;
        private TextBox PasswordTB2;
        private Button button1;
        private CheckBox checkBox1;
    }
}