namespace Lab3.Forms
{
    partial class MyArrays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyArrays));
            dgwMyArrays = new DataGridView();
            lblMyArrays = new Label();
            tBoxElements = new TextBox();
            lblElements = new Label();
            array_id = new DataGridViewTextBoxColumn();
            array_role = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgwMyArrays).BeginInit();
            SuspendLayout();
            // 
            // dgwMyArrays
            // 
            dgwMyArrays.AllowUserToAddRows = false;
            dgwMyArrays.AllowUserToDeleteRows = false;
            dgwMyArrays.AllowUserToResizeColumns = false;
            dgwMyArrays.AllowUserToResizeRows = false;
            dgwMyArrays.BackgroundColor = SystemColors.ButtonFace;
            dgwMyArrays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMyArrays.Columns.AddRange(new DataGridViewColumn[] { array_id, array_role });
            dgwMyArrays.Location = new Point(27, 70);
            dgwMyArrays.Name = "dgwMyArrays";
            dgwMyArrays.ReadOnly = true;
            dgwMyArrays.RowHeadersWidth = 51;
            dgwMyArrays.Size = new Size(398, 175);
            dgwMyArrays.TabIndex = 0;
            dgwMyArrays.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // lblMyArrays
            // 
            lblMyArrays.AutoSize = true;
            lblMyArrays.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMyArrays.Location = new Point(27, 19);
            lblMyArrays.Margin = new Padding(4, 0, 4, 0);
            lblMyArrays.Name = "lblMyArrays";
            lblMyArrays.Size = new Size(235, 46);
            lblMyArrays.TabIndex = 11;
            lblMyArrays.Text = "Мои массивы";
            // 
            // tBoxElements
            // 
            tBoxElements.Location = new Point(461, 70);
            tBoxElements.Multiline = true;
            tBoxElements.Name = "tBoxElements";
            tBoxElements.ReadOnly = true;
            tBoxElements.Size = new Size(384, 175);
            tBoxElements.TabIndex = 12;
            // 
            // lblElements
            // 
            lblElements.AutoSize = true;
            lblElements.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblElements.Location = new Point(461, 19);
            lblElements.Margin = new Padding(4, 0, 4, 0);
            lblElements.Name = "lblElements";
            lblElements.Size = new Size(318, 46);
            lblElements.TabIndex = 13;
            lblElements.Text = "Элементы массива";
            // 
            // array_id
            // 
            array_id.DataPropertyName = "array_id";
            array_id.HeaderText = "Номер массива";
            array_id.MinimumWidth = 6;
            array_id.Name = "array_id";
            array_id.ReadOnly = true;
            array_id.Resizable = DataGridViewTriState.False;
            array_id.Width = 125;
            // 
            // array_role
            // 
            array_role.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            array_role.DataPropertyName = "array_role";
            array_role.HeaderText = "Тип массива";
            array_role.MinimumWidth = 6;
            array_role.Name = "array_role";
            array_role.ReadOnly = true;
            array_role.Resizable = DataGridViewTriState.False;
            array_role.Width = 139;
            // 
            // MyArrays
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(876, 441);
            Controls.Add(lblElements);
            Controls.Add(tBoxElements);
            Controls.Add(lblMyArrays);
            Controls.Add(dgwMyArrays);
            Font = new Font("Segoe UI Variable Display Semil", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MyArrays";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мои массивы || CombSortAPP";
            Load += MyArrays_Load;
            ((System.ComponentModel.ISupportInitialize)dgwMyArrays).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwMyArrays;
        private Label lblMyArrays;
        private TextBox tBoxElements;
        private Label lblElements;
        private DataGridViewTextBoxColumn array_id;
        private DataGridViewTextBoxColumn array_role;
    }
}