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
            menuStrip = new MenuStrip();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            editStudentToolStripMenuItem = new ToolStripMenuItem();
            deleteStudentToolStripMenuItem = new ToolStripMenuItem();
            showGradesToolStripMenuItem = new ToolStripMenuItem();
            showSubjectsToolStripMenuItem1 = new ToolStripMenuItem();
            studentsDataGridView = new DataGridView();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, editStudentToolStripMenuItem, deleteStudentToolStripMenuItem, showGradesToolStripMenuItem, showSubjectsToolStripMenuItem1 });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(984, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
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
            editStudentToolStripMenuItem.Click += editStudentToolStripMenuItem_Click;
            // 
            // deleteStudentToolStripMenuItem
            // 
            deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            deleteStudentToolStripMenuItem.Size = new Size(106, 20);
            deleteStudentToolStripMenuItem.Text = "Smazat studenta";
            deleteStudentToolStripMenuItem.Click += deleteStudentToolStripMenuItem_Click;
            // 
            // showGradesToolStripMenuItem
            // 
            showGradesToolStripMenuItem.Name = "showGradesToolStripMenuItem";
            showGradesToolStripMenuItem.Size = new Size(111, 20);
            showGradesToolStripMenuItem.Text = "Známky studenta";
            showGradesToolStripMenuItem.Click += showGradesToolStripMenuItem_Click;
            // 
            // showSubjectsToolStripMenuItem1
            // 
            showSubjectsToolStripMenuItem1.Name = "showSubjectsToolStripMenuItem1";
            showSubjectsToolStripMenuItem1.Size = new Size(115, 20);
            showSubjectsToolStripMenuItem1.Text = "Seznam předmětů";
            showSubjectsToolStripMenuItem1.Click += showSubjectsToolStripMenuItem1_Click;
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
            studentsDataGridView.Size = new Size(984, 437);
            studentsDataGridView.TabIndex = 1;
            studentsDataGridView.CellFormatting += studentsDataGridView_CellFormatting;
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(studentsDataGridView);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "StudentListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seznam studentů";
            Load += StudentListForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem editStudentToolStripMenuItem;
        private ToolStripMenuItem deleteStudentToolStripMenuItem;
        private DataGridView studentsDataGridView;
        private ToolStripMenuItem showGradesToolStripMenuItem;
        private ToolStripMenuItem showSubjectsToolStripMenuItem1;
    }
}