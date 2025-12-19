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
            lblPassword = new Label();
            PasswordTB1 = new TextBox();
            lblLogin = new Label();
            LoginTB = new TextBox();
            lblRepeatPassword = new Label();
            PasswordTB2 = new TextBox();
            btnRegistation = new Button();
            cBoxShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Variable Small Semilig", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPassword.Location = new Point(28, 107);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(78, 26);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Пароль";
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
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            lblLogin.Location = new Point(23, 25);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(65, 26);
            lblLogin.TabIndex = 8;
            lblLogin.Text = "Логин";
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
            // lblRepeatPassword
            // 
            lblRepeatPassword.AutoSize = true;
            lblRepeatPassword.Font = new Font("Segoe UI Variable Small Semilig", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblRepeatPassword.Location = new Point(27, 184);
            lblRepeatPassword.Margin = new Padding(4, 0, 4, 0);
            lblRepeatPassword.Name = "lblRepeatPassword";
            lblRepeatPassword.Size = new Size(174, 26);
            lblRepeatPassword.TabIndex = 12;
            lblRepeatPassword.Text = "Повторите пароль";
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
            // 
            // btnRegistation
            // 
            btnRegistation.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            btnRegistation.Location = new Point(26, 322);
            btnRegistation.Margin = new Padding(4);
            btnRegistation.Name = "btnRegistation";
            btnRegistation.Size = new Size(231, 37);
            btnRegistation.TabIndex = 13;
            btnRegistation.Text = "Зарегистрироваться";
            btnRegistation.UseVisualStyleBackColor = true;
            btnRegistation.Click += button1_Click;
            // 
            // cBoxShowPassword
            // 
            cBoxShowPassword.AutoSize = true;
            cBoxShowPassword.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cBoxShowPassword.Location = new Point(28, 255);
            cBoxShowPassword.Margin = new Padding(4);
            cBoxShowPassword.Name = "cBoxShowPassword";
            cBoxShowPassword.Size = new Size(173, 30);
            cBoxShowPassword.TabIndex = 14;
            cBoxShowPassword.Text = "Показать пароль";
            cBoxShowPassword.UseVisualStyleBackColor = true;
            cBoxShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(295, 385);
            Controls.Add(cBoxShowPassword);
            Controls.Add(btnRegistation);
            Controls.Add(lblRepeatPassword);
            Controls.Add(PasswordTB2);
            Controls.Add(lblPassword);
            Controls.Add(PasswordTB1);
            Controls.Add(lblLogin);
            Controls.Add(LoginTB);
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
        private Label lblPassword;
        private TextBox PasswordTB1;
        private Label lblLogin;
        private TextBox LoginTB;
        private Label lblRepeatPassword;
        private TextBox PasswordTB2;
        private Button btnRegistation;
        private CheckBox cBoxShowPassword;
    }
}