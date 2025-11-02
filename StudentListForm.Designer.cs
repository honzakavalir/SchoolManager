namespace SchoolManager
{
    partial class StudentListForm
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
            menuStrip1 = new MenuStrip();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            editStudentToolStripMenuItem = new ToolStripMenuItem();
            deleteStudentToolStripMenuItem = new ToolStripMenuItem();
            closeMenuToolStripMenuItem = new ToolStripMenuItem();
            studentsDataGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, editStudentToolStripMenuItem, deleteStudentToolStripMenuItem, closeMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(99, 20);
            addStudentToolStripMenuItem.Text = "Přidat studenta";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // editStudentToolStripMenuItem
            // 
            editStudentToolStripMenuItem.Name = "editStudentToolStripMenuItem";
            editStudentToolStripMenuItem.Size = new Size(106, 20);
            editStudentToolStripMenuItem.Text = "Upravit studenta";
            // 
            // deleteStudentToolStripMenuItem
            // 
            deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            deleteStudentToolStripMenuItem.Size = new Size(106, 20);
            deleteStudentToolStripMenuItem.Text = "Smazat studenta";
            // 
            // closeMenuToolStripMenuItem
            // 
            closeMenuToolStripMenuItem.Name = "closeMenuToolStripMenuItem";
            closeMenuToolStripMenuItem.Size = new Size(94, 20);
            closeMenuToolStripMenuItem.Text = "Zpět do menu";
            closeMenuToolStripMenuItem.Click += closeMenuToolStripMenuItem_Click;
            // 
            // studentsDataGridView
            // 
            studentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsDataGridView.Dock = DockStyle.Fill;
            studentsDataGridView.Location = new Point(0, 24);
            studentsDataGridView.MultiSelect = false;
            studentsDataGridView.Name = "studentsDataGridView";
            studentsDataGridView.ReadOnly = true;
            studentsDataGridView.Size = new Size(800, 426);
            studentsDataGridView.TabIndex = 1;
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(studentsDataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "StudentListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Seznam studentů";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem editStudentToolStripMenuItem;
        private ToolStripMenuItem deleteStudentToolStripMenuItem;
        private ToolStripMenuItem closeMenuToolStripMenuItem;
        private DataGridView studentsDataGridView;
    }
}