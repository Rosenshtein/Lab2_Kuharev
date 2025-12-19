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
            lblPassword.Location = new Point(32, 143);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 32);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Пароль";
            // 
            // PasswordTB1
            // 
            PasswordTB1.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            PasswordTB1.Location = new Point(32, 183);
            PasswordTB1.Margin = new Padding(5, 5, 5, 5);
            PasswordTB1.Name = "PasswordTB1";
            PasswordTB1.Size = new Size(265, 39);
            PasswordTB1.TabIndex = 9;
            PasswordTB1.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            lblLogin.Location = new Point(26, 33);
            lblLogin.Margin = new Padding(5, 0, 5, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(81, 32);
            lblLogin.TabIndex = 8;
            lblLogin.Text = "Логин";
            // 
            // LoginTB
            // 
            LoginTB.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            LoginTB.Location = new Point(31, 79);
            LoginTB.Margin = new Padding(5, 5, 5, 5);
            LoginTB.Name = "LoginTB";
            LoginTB.Size = new Size(265, 39);
            LoginTB.TabIndex = 7;
            // 
            // lblRepeatPassword
            // 
            lblRepeatPassword.AutoSize = true;
            lblRepeatPassword.Font = new Font("Segoe UI Variable Small Semilig", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblRepeatPassword.Location = new Point(31, 245);
            lblRepeatPassword.Margin = new Padding(5, 0, 5, 0);
            lblRepeatPassword.Name = "lblRepeatPassword";
            lblRepeatPassword.Size = new Size(220, 32);
            lblRepeatPassword.TabIndex = 12;
            lblRepeatPassword.Text = "Повторите пароль";
            // 
            // PasswordTB2
            // 
            PasswordTB2.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            PasswordTB2.Location = new Point(31, 285);
            PasswordTB2.Margin = new Padding(5, 5, 5, 5);
            PasswordTB2.Name = "PasswordTB2";
            PasswordTB2.Size = new Size(265, 39);
            PasswordTB2.TabIndex = 11;
            PasswordTB2.UseSystemPasswordChar = true;
            // 
            // btnRegistation
            // 
            btnRegistation.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            btnRegistation.Location = new Point(30, 429);
            btnRegistation.Margin = new Padding(5, 5, 5, 5);
            btnRegistation.Name = "btnRegistation";
            btnRegistation.Size = new Size(264, 49);
            btnRegistation.TabIndex = 13;
            btnRegistation.Text = "Зарегистрироваться";
            btnRegistation.UseVisualStyleBackColor = true;
            btnRegistation.Click += button1_Click;
            // 
            // cBoxShowPassword
            // 
            cBoxShowPassword.AutoSize = true;
            cBoxShowPassword.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cBoxShowPassword.Location = new Point(32, 340);
            cBoxShowPassword.Margin = new Padding(5, 5, 5, 5);
            cBoxShowPassword.Name = "cBoxShowPassword";
            cBoxShowPassword.Size = new Size(221, 36);
            cBoxShowPassword.TabIndex = 14;
            cBoxShowPassword.Text = "Показать пароль";
            cBoxShowPassword.UseVisualStyleBackColor = true;
            cBoxShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(337, 513);
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