namespace SchoolManager
{
    partial class TeacherListForm
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
            menuStrip = new MenuStrip();
            addTeacherToolStripMenuItem = new ToolStripMenuItem();
            editTeacherToolStripMenuItem = new ToolStripMenuItem();
            deleteTeacherToolStripMenuItem = new ToolStripMenuItem();
            closeMenuToolStripMenuItem = new ToolStripMenuItem();
            teachersDataGridView = new DataGridView();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teachersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { addTeacherToolStripMenuItem, editTeacherToolStripMenuItem, deleteTeacherToolStripMenuItem, closeMenuToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // addTeacherToolStripMenuItem
            // 
            addTeacherToolStripMenuItem.Name = "addTeacherToolStripMenuItem";
            addTeacherToolStripMenuItem.Size = new Size(88, 20);
            addTeacherToolStripMenuItem.Text = "Přidat učitele";
            // 
            // editTeacherToolStripMenuItem
            // 
            editTeacherToolStripMenuItem.Name = "editTeacherToolStripMenuItem";
            editTeacherToolStripMenuItem.Size = new Size(95, 20);
            editTeacherToolStripMenuItem.Text = "Upravit učitele";
            // 
            // deleteTeacherToolStripMenuItem
            // 
            deleteTeacherToolStripMenuItem.Name = "deleteTeacherToolStripMenuItem";
            deleteTeacherToolStripMenuItem.Size = new Size(95, 20);
            deleteTeacherToolStripMenuItem.Text = "Smazat učitele";
            // 
            // closeMenuToolStripMenuItem
            // 
            closeMenuToolStripMenuItem.Name = "closeMenuToolStripMenuItem";
            closeMenuToolStripMenuItem.Size = new Size(94, 20);
            closeMenuToolStripMenuItem.Text = "Zpět do menu";
            closeMenuToolStripMenuItem.Click += closeMenuToolStripMenuItem_Click;
            // 
            // teachersDataGridView
            // 
            teachersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teachersDataGridView.Dock = DockStyle.Fill;
            teachersDataGridView.Location = new Point(0, 24);
            teachersDataGridView.Name = "teachersDataGridView";
            teachersDataGridView.ReadOnly = true;
            teachersDataGridView.Size = new Size(800, 426);
            teachersDataGridView.TabIndex = 1;
            // 
            // TeacherListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(teachersDataGridView);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "TeacherListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Seznam učitelů";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teachersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem addTeacherToolStripMenuItem;
        private ToolStripMenuItem editTeacherToolStripMenuItem;
        private ToolStripMenuItem deleteTeacherToolStripMenuItem;
        private ToolStripMenuItem closeMenuToolStripMenuItem;
        private DataGridView teachersDataGridView;
    }
}