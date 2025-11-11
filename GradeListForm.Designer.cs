namespace SchoolManager
{
    partial class GradeListForm
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
            newGradeToolStripMenuItem = new ToolStripMenuItem();
            editGradeToolStripMenuItem = new ToolStripMenuItem();
            deleteGradeToolStripMenuItem = new ToolStripMenuItem();
            gradesDataGridView = new DataGridView();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { newGradeToolStripMenuItem, editGradeToolStripMenuItem, deleteGradeToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // newGradeToolStripMenuItem
            // 
            newGradeToolStripMenuItem.Name = "newGradeToolStripMenuItem";
            newGradeToolStripMenuItem.Size = new Size(91, 20);
            newGradeToolStripMenuItem.Text = "Nová známka";
            newGradeToolStripMenuItem.Click += newGradeToolStripMenuItem_Click;
            // 
            // editGradeToolStripMenuItem
            // 
            editGradeToolStripMenuItem.Name = "editGradeToolStripMenuItem";
            editGradeToolStripMenuItem.Size = new Size(102, 20);
            editGradeToolStripMenuItem.Text = "Upravit známku";
            editGradeToolStripMenuItem.Click += editGradeToolStripMenuItem_Click;
            // 
            // deleteGradeToolStripMenuItem
            // 
            deleteGradeToolStripMenuItem.Name = "deleteGradeToolStripMenuItem";
            deleteGradeToolStripMenuItem.Size = new Size(102, 20);
            deleteGradeToolStripMenuItem.Text = "Smazat známku";
            deleteGradeToolStripMenuItem.Click += deleteGradeToolStripMenuItem_Click;
            // 
            // gradesDataGridView
            // 
            gradesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gradesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gradesDataGridView.Dock = DockStyle.Fill;
            gradesDataGridView.Location = new Point(0, 24);
            gradesDataGridView.Name = "gradesDataGridView";
            gradesDataGridView.Size = new Size(800, 426);
            gradesDataGridView.TabIndex = 1;
            // 
            // GradeListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gradesDataGridView);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "GradeListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Známky studenta";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem newGradeToolStripMenuItem;
        private ToolStripMenuItem editGradeToolStripMenuItem;
        private ToolStripMenuItem deleteGradeToolStripMenuItem;
        private DataGridView gradesDataGridView;
    }
}