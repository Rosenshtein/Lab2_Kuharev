namespace Lab3.Forms
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            lblHelp = new Label();
            panel1 = new Panel();
            HowUse = new TabPage();
            lblTextHowToUse = new Label();
            label4 = new Label();
            AboutProgramAndAuthor = new TabPage();
            label3 = new Label();
            label2 = new Label();
            AboutProgram = new TabControl();
            panel1.SuspendLayout();
            HowUse.SuspendLayout();
            AboutProgramAndAuthor.SuspendLayout();
            AboutProgram.SuspendLayout();
            SuspendLayout();
            // 
            // lblHelp
            // 
            lblHelp.AutoSize = true;
            lblHelp.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHelp.Location = new Point(4, 9);
            lblHelp.Margin = new Padding(4, 0, 4, 0);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(152, 46);
            lblHelp.TabIndex = 14;
            lblHelp.Text = "Справка";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblHelp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 54);
            panel1.TabIndex = 16;
            // 
            // HowUse
            // 
            HowUse.AutoScroll = true;
            HowUse.BackColor = Color.White;
            HowUse.Controls.Add(lblTextHowToUse);
            HowUse.Controls.Add(label4);
            HowUse.Location = new Point(4, 29);
            HowUse.Name = "HowUse";
            HowUse.Padding = new Padding(3);
            HowUse.Size = new Size(516, 298);
            HowUse.TabIndex = 1;
            HowUse.Text = "Как пользоваться";
            // 
            // lblTextHowToUse
            // 
            lblTextHowToUse.AutoSize = true;
            lblTextHowToUse.Font = new Font("Segoe UI Variable Display", 15.15F);
            lblTextHowToUse.Location = new Point(12, 12);
            lblTextHowToUse.Margin = new Padding(4, 0, 4, 0);
            lblTextHowToUse.Name = "lblTextHowToUse";
            lblTextHowToUse.Size = new Size(617, 1820);
            lblTextHowToUse.TabIndex = 18;
            lblTextHowToUse.Text = resources.GetString("lblTextHowToUse.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 15.15F);
            label4.Location = new Point(4, 3);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 35);
            label4.TabIndex = 17;
            // 
            // AboutProgramAndAuthor
            // 
            AboutProgramAndAuthor.AutoScroll = true;
            AboutProgramAndAuthor.BackColor = Color.White;
            AboutProgramAndAuthor.Controls.Add(label3);
            AboutProgramAndAuthor.Controls.Add(label2);
            AboutProgramAndAuthor.Location = new Point(4, 36);
            AboutProgramAndAuthor.Name = "AboutProgramAndAuthor";
            AboutProgramAndAuthor.Padding = new Padding(3);
            AboutProgramAndAuthor.Size = new Size(516, 291);
            AboutProgramAndAuthor.TabIndex = 0;
            AboutProgramAndAuthor.Text = "О программе";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 15.15F);
            label3.Location = new Point(97, 31);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(395, 280);
            label3.TabIndex = 16;
            label3.Text = "Программа представляет собой\r\nучебное задание по созданию   \r\nграфического приложения\r\nс примером работы\r\nсортировки расчёской.\r\nВыполнил работу студент\r\nгруппы 444 Кухарев Н.А.\r\n2025 год";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(9, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 46);
            label2.TabIndex = 15;
            // 
            // AboutProgram
            // 
            AboutProgram.Controls.Add(AboutProgramAndAuthor);
            AboutProgram.Controls.Add(HowUse);
            AboutProgram.Dock = DockStyle.Bottom;
            AboutProgram.Location = new Point(0, 89);
            AboutProgram.Name = "AboutProgram";
            AboutProgram.SelectedIndex = 0;
            AboutProgram.Size = new Size(524, 331);
            AboutProgram.TabIndex = 15;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(524, 420);
            Controls.Add(panel1);
            Controls.Add(AboutProgram);
            Font = new Font("Segoe UI Variable Display Semil", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Help";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            HowUse.ResumeLayout(false);
            HowUse.PerformLayout();
            AboutProgramAndAuthor.ResumeLayout(false);
            AboutProgramAndAuthor.PerformLayout();
            AboutProgram.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblHelp;
        private Panel panel1;
        private TabPage HowUse;
        private Label lblTextHowToUse;
        private Label label4;
        private TabPage AboutProgramAndAuthor;
        private Label label3;
        private Label label2;
        private TabControl AboutProgram;
    }
}