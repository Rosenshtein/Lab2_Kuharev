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
            mainMenu = new MenuStrip();
            arraysToolStripMenuItem = new ToolStripMenuItem();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            myArraysToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            outToolStripMenuItem = new ToolStripMenuItem();
            lblYouNoHaveArrays = new Label();
            lblAddNewArray = new Label();
            pctrBoxStrelka = new PictureBox();
            mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctrBoxStrelka).BeginInit();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Font = new Font("Segoe UI Variable Display Semil", 12F);
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { arraysToolStripMenuItem, helpToolStripMenuItem, outToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(7, 3, 0, 3);
            mainMenu.Size = new Size(398, 37);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // arraysToolStripMenuItem
            // 
            arraysToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewToolStripMenuItem, myArraysToolStripMenuItem });
            arraysToolStripMenuItem.Name = "arraysToolStripMenuItem";
            arraysToolStripMenuItem.Size = new Size(107, 31);
            arraysToolStripMenuItem.Text = "Массивы";
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(241, 32);
            addNewToolStripMenuItem.Text = "Добавить новый";
            addNewToolStripMenuItem.Click += addNewToolStripMenuItem_Click;
            // 
            // myArraysToolStripMenuItem
            // 
            myArraysToolStripMenuItem.Name = "myArraysToolStripMenuItem";
            myArraysToolStripMenuItem.Size = new Size(241, 32);
            myArraysToolStripMenuItem.Text = "Мои массивы";
            myArraysToolStripMenuItem.Click += myArraysToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(101, 31);
            helpToolStripMenuItem.Text = "Справка";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // outToolStripMenuItem
            // 
            outToolStripMenuItem.Name = "outToolStripMenuItem";
            outToolStripMenuItem.Size = new Size(79, 31);
            outToolStripMenuItem.Text = "Выйти";
            outToolStripMenuItem.Click += outToolStripMenuItem_Click;
            // 
            // lblYouNoHaveArrays
            // 
            lblYouNoHaveArrays.AutoSize = true;
            lblYouNoHaveArrays.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            lblYouNoHaveArrays.Location = new Point(86, 98);
            lblYouNoHaveArrays.Margin = new Padding(4, 0, 4, 0);
            lblYouNoHaveArrays.Name = "lblYouNoHaveArrays";
            lblYouNoHaveArrays.Size = new Size(302, 32);
            lblYouNoHaveArrays.TabIndex = 5;
            lblYouNoHaveArrays.Text = "У вас еще нет массивов :(";
            // 
            // lblAddNewArray
            // 
            lblAddNewArray.AutoSize = true;
            lblAddNewArray.Font = new Font("Segoe UI Variable Small Semilig", 14.25F);
            lblAddNewArray.Location = new Point(118, 124);
            lblAddNewArray.Margin = new Padding(4, 0, 4, 0);
            lblAddNewArray.Name = "lblAddNewArray";
            lblAddNewArray.Size = new Size(199, 32);
            lblAddNewArray.TabIndex = 6;
            lblAddNewArray.Text = "Добавьте новый";
            // 
            // pctrBoxStrelka
            // 
            pctrBoxStrelka.Image = Properties.Resources.Без_имени;
            pctrBoxStrelka.Location = new Point(-26, 12);
            pctrBoxStrelka.Name = "pctrBoxStrelka";
            pctrBoxStrelka.Size = new Size(301, 313);
            pctrBoxStrelka.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrBoxStrelka.TabIndex = 7;
            pctrBoxStrelka.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(398, 256);
            Controls.Add(lblAddNewArray);
            Controls.Add(lblYouNoHaveArrays);
            Controls.Add(mainMenu);
            Controls.Add(pctrBoxStrelka);
            Font = new Font("Segoe UI Variable Display Semil", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню || CombSortAPP";
            Activated += Menu_Activated;
            FormClosed += Menu_FormClosed;
            Load += Menu_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctrBoxStrelka).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem arraysToolStripMenuItem;
        private ToolStripMenuItem myArraysToolStripMenuItem;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem outToolStripMenuItem;
        private Label lblYouNoHaveArrays;
        private Label lblAddNewArray;
        private PictureBox pctrBoxStrelka;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}