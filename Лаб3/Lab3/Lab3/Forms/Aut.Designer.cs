namespace Lab3
{
    partial class Aut
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aut));
            button1 = new Button();
            LoginTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            PasswordTB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            button1.Location = new Point(34, 337);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(231, 41);
            button1.TabIndex = 1;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginTB
            // 
            LoginTB.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            LoginTB.Location = new Point(34, 105);
            LoginTB.Margin = new Padding(4);
            LoginTB.Name = "LoginTB";
            LoginTB.Size = new Size(232, 33);
            LoginTB.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            label1.Location = new Point(34, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 26);
            label1.TabIndex = 4;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Small Semilig", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(34, 142);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 26);
            label2.TabIndex = 6;
            label2.Text = "Пароль";
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            PasswordTB.Location = new Point(34, 172);
            PasswordTB.Margin = new Padding(4);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(232, 33);
            PasswordTB.TabIndex = 5;
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            label3.Location = new Point(34, 257);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 26);
            label3.TabIndex = 7;
            label3.Text = "Нет аккаунта? ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(34, 283);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(184, 26);
            label4.TabIndex = 9;
            label4.Text = "Зарегистрируйтесь!";
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(33, 25);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(174, 36);
            label5.TabIndex = 10;
            label5.Text = "Авторизация";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(34, 213);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(173, 30);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Aut
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(304, 410);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordTB);
            Controls.Add(label1);
            Controls.Add(LoginTB);
            Controls.Add(button1);
            Font = new Font("Segoe UI Variable Display Semil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Aut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация || CombSortAPP";
            FormClosed += Aut_FormClosed;
            Load += Aut_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox LoginTB;
        private Label label1;
        private Label label2;
        private TextBox PasswordTB;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
    }
}
