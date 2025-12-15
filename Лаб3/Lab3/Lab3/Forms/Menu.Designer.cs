namespace Lab3.Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            arraysToolStripMenuItem = new ToolStripMenuItem();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            myArraysToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            outToolStripMenuItem = new ToolStripMenuItem();
            outFromProgramToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Variable Display Semil", 12F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arraysToolStripMenuItem, helpToolStripMenuItem, outToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(398, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arraysToolStripMenuItem
            // 
            arraysToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewToolStripMenuItem, myArraysToolStripMenuItem });
            arraysToolStripMenuItem.Name = "arraysToolStripMenuItem";
            arraysToolStripMenuItem.Size = new Size(87, 25);
            arraysToolStripMenuItem.Text = "Массивы";
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(196, 26);
            addNewToolStripMenuItem.Text = "Добавить новый";
            addNewToolStripMenuItem.Click += addNewToolStripMenuItem_Click;
            // 
            // myArraysToolStripMenuItem
            // 
            myArraysToolStripMenuItem.Name = "myArraysToolStripMenuItem";
            myArraysToolStripMenuItem.Size = new Size(196, 26);
            myArraysToolStripMenuItem.Text = "Мои массивы";
            myArraysToolStripMenuItem.Click += myArraysToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(82, 25);
            helpToolStripMenuItem.Text = "Справка";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // outToolStripMenuItem
            // 
            outToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { outFromProgramToolStripMenuItem });
            outToolStripMenuItem.Name = "outToolStripMenuItem";
            outToolStripMenuItem.Size = new Size(66, 25);
            outToolStripMenuItem.Text = "Выйти";
            // 
            // outFromProgramToolStripMenuItem
            // 
            outFromProgramToolStripMenuItem.Name = "outFromProgramToolStripMenuItem";
            outFromProgramToolStripMenuItem.Size = new Size(182, 26);
            outFromProgramToolStripMenuItem.Text = "Из программы";
            outFromProgramToolStripMenuItem.Click += outFromProgramToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            label1.Location = new Point(86, 98);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(235, 26);
            label1.TabIndex = 5;
            label1.Text = "У вас еще нет массивов :(";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            label2.Location = new Point(118, 124);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 26);
            label2.TabIndex = 6;
            label2.Text = "Добавьте новый";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Без_имени;
            pictureBox1.Location = new Point(-26, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(398, 256);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Variable Display Semil", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню || CombSortAPP";
            Activated += Menu_Activated;
            FormClosed += Menu_FormClosed;
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arraysToolStripMenuItem;
        private ToolStripMenuItem myArraysToolStripMenuItem;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem outToolStripMenuItem;
        private ToolStripMenuItem outFromProgramToolStripMenuItem;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}