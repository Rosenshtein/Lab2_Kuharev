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
            label1 = new Label();
            AboutProgram = new TabControl();
            AboutProgramAndAuthor = new TabPage();
            HowUse = new TabPage();
            panel1 = new Panel();
            tabPage3 = new TabPage();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AboutProgram.SuspendLayout();
            AboutProgramAndAuthor.SuspendLayout();
            HowUse.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(4, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 36);
            label1.TabIndex = 14;
            label1.Text = "Справка";
            // 
            // AboutProgram
            // 
            AboutProgram.Controls.Add(AboutProgramAndAuthor);
            AboutProgram.Controls.Add(HowUse);
            AboutProgram.Controls.Add(tabPage3);
            AboutProgram.Dock = DockStyle.Bottom;
            AboutProgram.Location = new Point(0, 60);
            AboutProgram.Name = "AboutProgram";
            AboutProgram.SelectedIndex = 0;
            AboutProgram.Size = new Size(405, 331);
            AboutProgram.TabIndex = 15;
            // 
            // AboutProgramAndAuthor
            // 
            AboutProgramAndAuthor.BackColor = Color.White;
            AboutProgramAndAuthor.Controls.Add(label3);
            AboutProgramAndAuthor.Controls.Add(label2);
            AboutProgramAndAuthor.Location = new Point(4, 30);
            AboutProgramAndAuthor.Name = "AboutProgramAndAuthor";
            AboutProgramAndAuthor.Padding = new Padding(3);
            AboutProgramAndAuthor.Size = new Size(397, 297);
            AboutProgramAndAuthor.TabIndex = 0;
            AboutProgramAndAuthor.Text = "О программе";
            // 
            // HowUse
            // 
            HowUse.BackColor = Color.White;
            HowUse.Controls.Add(label4);
            HowUse.Location = new Point(4, 30);
            HowUse.Name = "HowUse";
            HowUse.Padding = new Padding(3);
            HowUse.Size = new Size(397, 297);
            HowUse.TabIndex = 1;
            HowUse.Text = "Как пользоваться";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 54);
            panel1.TabIndex = 16;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(397, 297);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Сортировка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(9, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 36);
            label2.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 15.15F);
            label3.Location = new Point(17, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(318, 224);
            label3.TabIndex = 16;
            label3.Text = "Программа представляет собой\r\nучебное задание по созданию   \r\nграфического приложения\r\nс примером работы\r\nсортировки расчёской.\r\nВыполнил работу студент\r\nгруппы 444 Кухарев Н.А.\r\n2025 год";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 15.15F);
            label4.Location = new Point(4, 3);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(362, 280);
            label4.TabIndex = 17;
            label4.Text = resources.GetString("label4.Text");
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(405, 391);
            Controls.Add(panel1);
            Controls.Add(AboutProgram);
            Font = new Font("Segoe UI Variable Display Semil", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Help";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            AboutProgram.ResumeLayout(false);
            AboutProgramAndAuthor.ResumeLayout(false);
            AboutProgramAndAuthor.PerformLayout();
            HowUse.ResumeLayout(false);
            HowUse.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TabControl AboutProgram;
        private TabPage AboutProgramAndAuthor;
        private Label label3;
        private Label label2;
        private TabPage HowUse;
        private TabPage tabPage3;
        private Panel panel1;
        private Label label4;
    }
}