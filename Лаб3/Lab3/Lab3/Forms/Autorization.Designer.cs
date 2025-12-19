namespace Lab3
{
    partial class Autorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            btnLogin = new Button();
            LoginTB = new TextBox();
            lblLogin = new Label();
            lblPassword = new Label();
            PasswordTB = new TextBox();
            lblNoHaveAccount = new Label();
            lblRegistration = new Label();
            lblAutorization = new Label();
            checkBoxShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            btnLogin.Location = new Point(34, 337);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(231, 41);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
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
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            lblLogin.Location = new Point(34, 75);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(65, 26);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Variable Small Semilig", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPassword.Location = new Point(34, 142);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(78, 26);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Пароль";
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
            // lblNoHaveAccount
            // 
            lblNoHaveAccount.AutoSize = true;
            lblNoHaveAccount.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            lblNoHaveAccount.Location = new Point(34, 257);
            lblNoHaveAccount.Margin = new Padding(4, 0, 4, 0);
            lblNoHaveAccount.Name = "lblNoHaveAccount";
            lblNoHaveAccount.Size = new Size(139, 26);
            lblNoHaveAccount.TabIndex = 7;
            lblNoHaveAccount.Text = "Нет аккаунта? ";
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Cursor = Cursors.Hand;
            lblRegistration.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            lblRegistration.ForeColor = Color.RoyalBlue;
            lblRegistration.Location = new Point(34, 283);
            lblRegistration.Margin = new Padding(4, 0, 4, 0);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(184, 26);
            lblRegistration.TabIndex = 9;
            lblRegistration.Text = "Зарегистрируйтесь!";
            lblRegistration.Click += label4_Click;
            lblRegistration.MouseEnter += label4_MouseEnter;
            lblRegistration.MouseLeave += label4_MouseLeave;
            // 
            // lblAutorization
            // 
            lblAutorization.AutoSize = true;
            lblAutorization.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAutorization.Location = new Point(33, 25);
            lblAutorization.Margin = new Padding(4, 0, 4, 0);
            lblAutorization.Name = "lblAutorization";
            lblAutorization.Size = new Size(174, 36);
            lblAutorization.TabIndex = 10;
            lblAutorization.Text = "Авторизация";
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBoxShowPassword.Location = new Point(34, 213);
            checkBoxShowPassword.Margin = new Padding(4);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(173, 30);
            checkBoxShowPassword.TabIndex = 8;
            checkBoxShowPassword.Text = "Показать пароль";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Autorization
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(304, 410);
            Controls.Add(lblAutorization);
            Controls.Add(lblRegistration);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(lblNoHaveAccount);
            Controls.Add(lblPassword);
            Controls.Add(PasswordTB);
            Controls.Add(lblLogin);
            Controls.Add(LoginTB);
            Controls.Add(btnLogin);
            Font = new Font("Segoe UI Variable Display Semil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Autorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация || CombSortAPP";
            FormClosed += Aut_FormClosed;
            Load += Aut_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox LoginTB;
        private Label lblLogin;
        private Label lblPassword;
        private TextBox PasswordTB;
        private Label lblNoHaveAccount;
        private Label lblRegistration;
        private Label lblAutorization;
        private CheckBox checkBoxShowPassword;
    }
}
